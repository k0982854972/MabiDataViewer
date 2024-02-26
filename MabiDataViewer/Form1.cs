using System;
using System.Data;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace MabiDataViewer
{
    public partial class Form1 : Form
    {
        private DataTable dataTable_itemDB, dataTable_ItemString;
        private DataSet dataSet_ItemDB = new DataSet();
        private DataSet dataSet_ItemString = new DataSet();
        private DataTable dataTable_OptionSet, dataTable_OptionSetString;
        private DataSet dataSet_OptionSet = new DataSet();
        private DataSet dataSet_OptionSetString = new DataSet();
        private ItemDB _itemDB;
        private OptionSet _optionSet;
        private string OptionSetLevel, OptionSetIsAlwaysSuccess;
        private int[] level_rates = { 0, 75, 70, 65, 60, 55, 50, 35, 33, 30, 27, 22, 16, 11, 7, 5 };
        private double[] powder_rates = { 0, 0, 0.05, 0.1, 0.5, 0.6, 0.6 };
        private double OptionSetSuccessRate;

        public Form1()
        {
            InitializeComponent();
            _itemDB = new ItemDB(this);
            _optionSet = new OptionSet(this);
            comboBox_OptionSetPowder.SelectedIndex = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Stopwatch stopwatch = Stopwatch.StartNew();
            try
            {
                label1.Text = "正在讀取XML文件...";
                Task.Run(() =>
                {
                    //將ItemString資料存入dataSet_ItemString
                    dataSet_ItemString.Tables.Add(_itemDB.GetItemStringName(this.dataTable_ItemString));
                    //將ItemDB資料存入dataSet_ItemDB
                    dataSet_ItemDB.Tables.Add(_itemDB.GetItemDB(dataTable_itemDB, dataSet_ItemString));
                
                    dataSet_OptionSetString.Tables.Add(_optionSet.GetOptionSetStringName(this.dataTable_OptionSetString));
                    dataSet_OptionSet.Tables.Add(_optionSet.GetOptionSet(dataTable_OptionSet, dataSet_OptionSetString));

                    this.Invoke(new MethodInvoker(() =>
                    {
                        dataGridView_ItemDB.DataSource = dataSet_ItemDB.Tables[0];
                        dataGridView_ItemDB.Columns[1].Visible = false;
                        dataGridView_ItemDB.Columns[2].Visible = false;
                        dataGridView_ItemDB.Columns[12].Visible = false;

                        dataGridView_OptionSet.DataSource = dataSet_OptionSet.Tables[0];
                        dataGridView_OptionSet.Columns[10].Visible = false;
                        dataGridView_OptionSet.Columns[11].Visible = false;

                        
                        button_ItemSearch.Enabled = true; button_ItemReset.Enabled = true;
                        button_OptionSetSearch.Enabled = true; button_OptionSetReset.Enabled = true;
                        foreach (DataGridViewColumn col in dataGridView_ItemDB.Columns)
                        {
                            col.SortMode = DataGridViewColumnSortMode.NotSortable;
                        }
                        foreach (DataGridViewColumn col in dataGridView_OptionSet.Columns)
                        {
                            col.SortMode = DataGridViewColumnSortMode.NotSortable;
                        }
                        stopwatch.Stop();
                        label1.Text = $"首次加載耗時 : {stopwatch.Elapsed.TotalMilliseconds / 1000} 秒";
                    }));
                });
            }
            catch (Exception ex)
            {
                label1.Text = "讀取XML文件失敗";
                MessageBox.Show(ex.Message);
            }
        }

        private void checkBox_CheckedChanged(object sender, EventArgs e)
        {

            System.Windows.Forms.CheckBox checkBox = (System.Windows.Forms.CheckBox)sender;

            // 检查哪个复选框被选中，并取消另一个复选框的选中状态
            if (checkBox == checkBox_OptionSetDayBonus && checkBox.Checked)
            {
                checkBox_OptionSetHelperBonus.Checked = false;
            }
            else if (checkBox == checkBox_OptionSetHelperBonus && checkBox.Checked)
            {
                checkBox_OptionSetDayBonus.Checked = false;
            }
            label_OptionSetRate.Text = _optionSet.GetOptionSetSucceseRate(OptionSetSuccessRate, powder_rates[comboBox_OptionSetPowder.SelectedIndex], level_rates[int.Parse(OptionSetLevel)], OptionSetLevel, OptionSetIsAlwaysSuccess, checkBox_OptionSetDayBonus, checkBox_OptionSetHelperBonus);
        }

        private void comboBox_OptionSetPowder_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dataSet_OptionSet.Tables.Count > 0) 
            { 
                label_OptionSetRate.Text = _optionSet.GetOptionSetSucceseRate(OptionSetSuccessRate, powder_rates[comboBox_OptionSetPowder.SelectedIndex], level_rates[int.Parse(OptionSetLevel)], OptionSetLevel, OptionSetIsAlwaysSuccess, checkBox_OptionSetDayBonus, checkBox_OptionSetHelperBonus);
            }
        }

        private void dataGridView_ItemDB_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0) // 确保用户点击的是行而不是表头
            {
                int row = e.RowIndex;
                int col = e.ColumnIndex;
                DataGridView dt = sender as DataGridView;
                textBox_ItemCategory.Text = dt.Rows[row].Cells[1].Value.ToString();
                textBox_ItemXML.Text = dt.Rows[row].Cells[2].Value.ToString();
                textBox_ItemDesc.Text = dt.Rows[row].Cells[5].Value.ToString().Replace("\\n", Environment.NewLine);
                label_ItemID.Text = "道具編號: " + dt.Rows[row].Cells[0].Value.ToString();
                label_ItemName.Text = "道具名稱: " + dt.Rows[row].Cells[4].Value.ToString();
                label_Bundle.Text = "最大堆疊: " + dt.Rows[row].Cells[6].Value.ToString();
                label_ItemSize.Text = "道具大小: " + dt.Rows[row].Cells[10].Value.ToString() + "x" + dt.Rows[row].Cells[11].Value.ToString();
                groupBox_ActionFlag.Text = "Action Flag: " + dt.Rows[row].Cells[9].Value.ToString();
                pictureBox1.Image = _itemDB.GetItemPicture(dt.Rows[row].Cells[0].Value.ToString());
                _itemDB.GetActionFlag(dt, row);
            }
        }

        private void dataGridView_OptionSet_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0) // 确保用户点击的是行而不是表头
            {
                int row = e.RowIndex;
                int col = e.ColumnIndex;
                DataGridView dt = sender as DataGridView;
                string[] ranks = { "", "F", "E", "D", "C", "B", "A", "9", "8", "7", "6", "5", "4", "3", "2", "1" };
                string[] usages = { "接頭", "接尾", "Unused(不可當作一般賦予使用)", "自然力(不可當作一般賦予使用)", "改造賦予(不可當作一般賦予使用)", "", "", "聖火(不可當作一般賦予使用)", "工匠改造(不可當作一般賦予使用)" };
                checkBox_OptionSetDayBonus.Enabled = true; checkBox_OptionSetHelperBonus.Enabled = true; comboBox_OptionSetPowder.Enabled = true;
                OptionSetLevel = dt.Rows[row].Cells[5].Value.ToString();
                OptionSetIsAlwaysSuccess = dt.Rows[row].Cells[11].Value.ToString();
                label_OptionSetID.Text = "賦予編號: " + dt.Rows[row].Cells[0].Value.ToString();
                label_OptionSetName.Text = "賦予名稱: " + dt.Rows[row].Cells[2].Value.ToString();
                label_OptionSetLevel.Text = "賦予等級: Rank " + ranks[int.Parse(dt.Rows[row].Cells[5].Value.ToString())];
                label_OptionSetIgnore.Text = "無視墊捲: " + dt.Rows[row].Cells[7].Value.ToString();
                label_OptionSetUsage.Text = "賦予詞綴: " + usages[int.Parse(dt.Rows[row].Cells[10].Value.ToString())];
                label_OptionSetFee.Text = "修理倍率: " + dt.Rows[row].Cells[6].Value.ToString() + "%";
                label_OptionSetRate.Text = _optionSet.GetOptionSetSucceseRate(OptionSetSuccessRate, powder_rates[comboBox_OptionSetPowder.SelectedIndex], level_rates[int.Parse(OptionSetLevel)], OptionSetLevel, OptionSetIsAlwaysSuccess, checkBox_OptionSetDayBonus, checkBox_OptionSetHelperBonus);
                textBox_OptionSetDesc.Text = dt.Rows[row].Cells[4].Value.ToString().Replace("\\n", Environment.NewLine);
                textBox_OptionSetAllow.Text = dt.Rows[row].Cells[8].Value.ToString().Replace("|", Environment.NewLine);
                textBox_OptionSetBlock.Text = dt.Rows[row].Cells[9].Value.ToString().Replace("|", Environment.NewLine);
                
            }
        }

        private void button_ItemSearch_Click(object sender, EventArgs e)
        {
            Stopwatch stopwatch = Stopwatch.StartNew();
            try
            {
                if (!string.IsNullOrEmpty(textBox_ItemKeyword.Text))
                {
                    dataGridView_ItemDB.DataSource = _itemDB.GetItemFilteredSerach(textBox_ItemKeyword.Text, dataSet_ItemDB);
                }
            }
            catch(Exception ex)
            {
                label1.Text = $"ItemDB 搜尋耗時 : ";
                MessageBox.Show(ex.Message);
            }
            stopwatch.Stop();
            label1.Text = $"ItemDB 搜尋耗時 : {stopwatch.Elapsed.TotalMilliseconds / 1000} 秒";
        }

        private void button_ItemReset_Click(object sender, EventArgs e)
        {
            Stopwatch stopwatch = Stopwatch.StartNew();
            dataGridView_ItemDB.DataSource = dataSet_ItemDB.Tables[0];
            stopwatch.Stop();
            label1.Text = $"ItemDB 重置耗時 : {stopwatch.Elapsed.TotalMilliseconds / 1000} 秒";
        }

        private void button_OptionSetSearch_Click(object sender, EventArgs e)
        {
            Stopwatch stopwatch = Stopwatch.StartNew();
            try
            {
                if (!string.IsNullOrEmpty(textBox_OptionSetKeyword.Text))
                {
                    dataGridView_OptionSet.DataSource = _optionSet.GetOptionSetFilteredSerach(textBox_OptionSetKeyword.Text, dataSet_OptionSet);
                }
            }
            catch (Exception ex)
            {
                label2.Text = $"OptionSet 搜尋耗時 : ";
                MessageBox.Show(ex.Message);
            }
            stopwatch.Stop();
            label2.Text = $"OptionSet 搜尋耗時 : {stopwatch.Elapsed.TotalMilliseconds / 1000} 秒";
        }

        private void button_OptionSetReset_Click(object sender, EventArgs e)
        {
            Stopwatch stopwatch = Stopwatch.StartNew();
            dataGridView_OptionSet.DataSource = dataSet_OptionSet.Tables[0];
            stopwatch.Stop();
            label2.Text = $"OptionSet 重置耗時 : {stopwatch.Elapsed.TotalMilliseconds / 1000} 秒";
        }
    }
}
