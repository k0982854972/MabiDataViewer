using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using MabiDataViewer.Models;
using static System.Net.Mime.MediaTypeNames;

namespace MabiDataViewer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            dataGridView1.AllowUserToAddRows = false;
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                Stopwatch stopwatch = Stopwatch.StartNew();
                DataTable dataTable_itemName = new DataTable("itemDataTable");
                dataTable_itemName.Columns.Add("ID");
                dataTable_itemName.Columns.Add("Description");
                dataSet1.Tables.Add(dataTable_itemName);
                string filePath = "ItemDB.china.txt";
                ReadDataFromFile(filePath, dataTable_itemName);
                dataGridView2.DataSource = dataTable_itemName;
                /*
                // 使用 XElement.Load 從 XML 檔案中讀取資料
                XElement xmlData = XElement.Load("ItemDB.xml"); // 請替換為您的 XML 檔案路徑
                DataSet dataSet = new DataSet();
                // 創建一個 DataTable 並添加列
                DataTable dataTable_itemdb = new DataTable();
                dataTable_itemdb.Columns.Add("ID");
                dataTable_itemdb.Columns.Add("DB_StoreType");
                dataTable_itemdb.Columns.Add("Category");
                dataTable_itemdb.Columns.Add("XML");
                dataTable_itemdb.Columns.Add("Text_Name0");
                dataTable_itemdb.Columns.Add("Locale");
                dataTable_itemdb.Columns.Add("feature");
                dataTable_itemdb.Columns.Add("Text_Name1");
                dataTable_itemdb.Columns.Add("Text_Desc1");
                dataTable_itemdb.Columns.Add("Bundle_Type");
                dataTable_itemdb.Columns.Add("Bundle_Max");
                dataTable_itemdb.Columns.Add("Price_Buy");
                dataTable_itemdb.Columns.Add("Price_Sell");
                dataTable_itemdb.Columns.Add("Attr_ActionFlag");
                dataTable_itemdb.Columns.Add("Attr_Type");
                dataTable_itemdb.Columns.Add("Attr_Grade");
                dataTable_itemdb.Columns.Add("Attr_RaceFilter");
                dataTable_itemdb.Columns.Add("File_MaleMesh");
                dataTable_itemdb.Columns.Add("File_FemaleMesh");
                dataTable_itemdb.Columns.Add("File_GiantMesh");
                dataTable_itemdb.Columns.Add("File_FemaleGiantMesh");
                dataTable_itemdb.Columns.Add("File_FieldMesh");
                dataTable_itemdb.Columns.Add("File_InvImage");
                dataTable_itemdb.Columns.Add("Inv_XSize");
                dataTable_itemdb.Columns.Add("Inv_YSize");
                dataTable_itemdb.Columns.Add("App_WeaponActionType");
                dataTable_itemdb.Columns.Add("App_WearType");
                dataTable_itemdb.Columns.Add("App_UseC4Layer");
                dataTable_itemdb.Columns.Add("App_Color1");
                dataTable_itemdb.Columns.Add("App_Color2");
                dataTable_itemdb.Columns.Add("App_Color3");
                dataTable_itemdb.Columns.Add("App_Color5");
                dataTable_itemdb.Columns.Add("App_Color6");
                dataTable_itemdb.Columns.Add("App_Color7");
                dataTable_itemdb.Columns.Add("App_ColorOrder");
                dataTable_itemdb.Columns.Add("App_AnimationType");
                dataTable_itemdb.Columns.Add("App_SittingType");
                dataTable_itemdb.Columns.Add("Taste_Beauty");
                dataTable_itemdb.Columns.Add("Taste_Indivisuality");
                dataTable_itemdb.Columns.Add("Taste_Luxury");
                dataTable_itemdb.Columns.Add("Taste_Toughness");
                dataTable_itemdb.Columns.Add("Taste_Utility");
                dataTable_itemdb.Columns.Add("Taste_Rarity");
                dataTable_itemdb.Columns.Add("Taste_Meaning");
                dataTable_itemdb.Columns.Add("Taste_Adult");
                dataTable_itemdb.Columns.Add("Taste_Maniac");
                dataTable_itemdb.Columns.Add("Taste_Anime");
                dataTable_itemdb.Columns.Add("Taste_Sexy");
                dataTable_itemdb.Columns.Add("File_WallMesh");
                dataTable_itemdb.Columns.Add("Metalware_UItooltip");
                dataTable_itemdb.Columns.Add("Enchant_UItooltip");
                dataTable_itemdb.Columns.Add("Upgrade_UItooltip");
                dataTable_itemdb.Columns.Add("Par_BlockUseFlag");
                dataTable_itemdb.Columns.Add("Par_UpgradeMax");
                dataTable_itemdb.Columns.Add("Par_GemUpgradeMax");
                dataTable_itemdb.Columns.Add("Par_DurabilityMax");
                dataTable_itemdb.Columns.Add("Par_Defense");
                dataTable_itemdb.Columns.Add("Par_ProtectRate");
                dataTable_itemdb.Columns.Add("Par_AttackMin");
                dataTable_itemdb.Columns.Add("Par_AttackMax");
                dataTable_itemdb.Columns.Add("Par_WAttackMin");
                dataTable_itemdb.Columns.Add("Par_WAttackMax");
                dataTable_itemdb.Columns.Add("Par_CriticalRate");
                dataTable_itemdb.Columns.Add("Par_AttackBalance");
                dataTable_itemdb.Columns.Add("Par_EffectiveRange");
                dataTable_itemdb.Columns.Add("Par_AttackSpeed");
                dataTable_itemdb.Columns.Add("Par_DownHitCount");
                dataTable_itemdb.Columns.Add("Par_BasicOption");
                dataTable_itemdb.Columns.Add("Attr_ItemEnhanceSet");
                dataTable_itemdb.Columns.Add("Shopping_Book_Type");
                dataTable_itemdb.Columns.Add("Food_BlockUseFlag");
                dataTable_itemdb.Columns.Add("Food_Type");
                dataTable_itemdb.Columns.Add("Food_Amount");
                dataTable_itemdb.Columns.Add("Food_AmountFlag");
                dataTable_itemdb.Columns.Add("Food_Str");
                dataTable_itemdb.Columns.Add("Food_Int");
                dataTable_itemdb.Columns.Add("Food_Dex");
                dataTable_itemdb.Columns.Add("Food_Will");
                dataTable_itemdb.Columns.Add("Food_Luck");
                dataTable_itemdb.Columns.Add("Food_Life");
                dataTable_itemdb.Columns.Add("Food_Mana");
                dataTable_itemdb.Columns.Add("Food_Stamina");
                dataTable_itemdb.Columns.Add("Food_Fatness");
                dataTable_itemdb.Columns.Add("Food_Upper");
                dataTable_itemdb.Columns.Add("Food_Lower");
                dataTable_itemdb.Columns.Add("Food_Toxic");
                dataTable_itemdb.Columns.Add("FoodEffectXML");
                dataTable_itemdb.Columns.Add("SmartSearchFlag");
                dataTable_itemdb.Columns.Add("AuctionSearchFlag");
                // 添加其他列以匹配 XML 中的其他屬性
                // 使用 LINQ to XML 查詢 XML 資料並填充到 DataTable 中
                foreach (XElement element in xmlData.Elements("Mabi_Item"))
                {
                    DataRow row = dataTable_itemdb.NewRow();
                    // 取得節點的所有屬性
                    foreach (XAttribute attribute in element.Attributes())
                    {
                        string attributeName = attribute.Name.LocalName;
                        string attributeValue = attribute.Value;

                        // 使用 attributeName 和 attributeValue 進行相應的處理
                        
                        if ((attribute.Name == "Text_Name1" || attribute.Name == "Text_Desc1") && attribute.Value.Contains("_LT[xml.itemdb"))
                        {
                            string result = "";
                            string namestring = attributeValue;
                            int startIndex = namestring.IndexOf("_LT[xml.itemdb.") + "_LT[xml.itemdb.".Length;
                            int endIndex = namestring.IndexOf("]", startIndex);
                            if (startIndex != -1 && endIndex != -1)
                            {
                                // 截取所需的字串
                                result = namestring.Substring(startIndex, endIndex - startIndex);
                                DataRow[] foundRows = dataSet1.Tables["itemDataTable"].Select($"ID='{result}'");
                                if (foundRows.Length > 0)
                                {
                                    foreach (DataRow rows in foundRows)
                                    {
                                        row[attributeName] = rows["Description"].ToString();
                                    }

                                }
                                else
                                {
                                    row[attributeName] = attribute.Value;
                                }
                            }
                        }
                        else
                        {
                            row[attributeName] = attribute.Value;
                        }
                    }
                    dataTable_itemdb.Rows.Add(row);
                    
                }
                dataSet.Tables.Add(dataTable_itemdb);
                dataGridView1.DataSource = dataSet.Tables[0];
                stopwatch.Stop();
                TimeSpan elapsedTime = stopwatch.Elapsed;
                label1.Text = $"ItemDB 讀取耗時 : {elapsedTime.TotalMilliseconds/1000} 秒";
                */
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
        private void dataGridView_donate_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0) // 确保用户点击的是行而不是表头
            {
                pictureBox1.Image = null;
                int row = e.RowIndex;
                int col = e.ColumnIndex;
                DataGridView dt = sender as DataGridView;
                string ColumnName = dt.Columns[col].DataPropertyName;
                textBox_ItemDesc.Text = dt.Rows[row].Cells[8].Value.ToString();
                textBox_ItemCategory.Text = dt.Rows[row].Cells[2].Value.ToString();
                textBox_ItemXML.Text = dt.Rows[row].Cells[3].Value.ToString();
                label_ItemID.Text = "道具編號: " + dt.Rows[row].Cells[0].Value.ToString();
                label_ItemName.Text = "道具名稱: " + dt.Rows[row].Cells[7].Value.ToString();
                label_ItemFlag.Text = "Action Flag: " + dt.Rows[row].Cells[13].Value.ToString();
                label_Bundle.Text = "最大堆疊: " + dt.Rows[row].Cells[10].Value.ToString();

                    
                Update_checkbox(dt, row, col);
                Update_picturebox(dt, row, col);
            }
        }
        private bool Update_checkbox(DataGridView dt, int row, int col)
        {
            foreach (Control control in groupBox_checkbox.Controls)
            {
                if (control is CheckBox checkBox)
                {
                    checkBox.Checked = false;
                }
            }
            switch (dt.Rows[row].Cells[13].Value.ToString())
            {
                case "0":
                    foreach (Control control in groupBox_checkbox.Controls)
                    {
                        if (control is CheckBox checkBox)
                        {
                            checkBox.Checked = true;
                        }
                    }
                    checkBox_DropLock.Checked = false; checkBox_BankCharacter.Checked = false; checkBox_Destroy.Checked = false;
                    break;
                case "1":
                    checkBox_DropLock.Checked = true; checkBox_Mail.Checked = true;
                    break;
                case "2":
                    break;
                case "3":
                    checkBox_DropLock.Checked = true; checkBox_BankAccount.Checked = true;
                    break;
                case "4":
                    checkBox_Trade.Checked = true; checkBox_DropFree.Checked = true;
                    break;
                case "5":
                    checkBox_DropLock.Checked = true; checkBox_BankCharacter.Checked = true;
                    break;
                case "6":
                case "7":
                case "8":
                    break;
                case "9":
                    checkBox_DropLock.Checked = true;
                    break;
                case "10":
                    checkBox_Destroy.Checked = true; checkBox_BankCharacter.Checked = true;
                    break;
                case "12":
                    checkBox_Destroy.Checked = true; checkBox_BankAccount.Checked = true; checkBox_Pet.Checked = true;
                    break;
                case "13":
                    checkBox_BankCharacter.Checked = true;
                    break;
                case "14":
                    checkBox_TradeLimit.Checked = true; checkBox_DropLock.Checked = true; checkBox_BankAccount.Checked = true;
                    break;
                case "16":
                    checkBox_DropLock.Checked = true;
                    break;
                case "17":
                    checkBox_DropLock.Checked = true; checkBox_BankAccount.Checked = true;
                    break;

            }
            if (dt.Rows[row].Cells[2].Value.ToString().Contains("destroyable"))
            {
                checkBox_Destroy.Checked = true;
            }
            if (dt.Rows[row].Cells[2].Value.ToString().Contains("not_dropable"))
            {
                checkBox_DropFree.Checked = false;
                checkBox_DropLock.Checked = false;
            }
            if (dt.Rows[row].Cells[2].Value.ToString().Contains("not_mailbox"))
            {
                checkBox_Mail.Checked = false;
            }
            if (dt.Rows[row].Cells[27].Value.ToString().Contains("true"))
            {
                checkBox_dyeable.Checked = true;
                if (dt.Rows[row].Cells[2].Value.ToString().Contains("not_dyeable"))
                {
                    checkBox_dyeable.Checked = false;
                }
            }
            return true;
        }
        private bool Update_picturebox(DataGridView dt, int row, int col)
        {
            string imageUrl = "http://suiyue.me/Info/item/" + dt.Rows[row].Cells[0].Value.ToString()+".png";
            WebRequest request = WebRequest.Create(imageUrl);
            try
            {
                WebResponse response = request.GetResponse();
                System.Drawing.Image image;
                if (((HttpWebResponse)response).StatusCode == HttpStatusCode.OK)
                {
                    // 從 WebResponse 中取得圖片流
                    Stream stream = response.GetResponseStream();
                    // 使用 Image.FromStream 方法從流中創建圖片
                    image = System.Drawing.Image.FromStream(stream);
                    pictureBox1.Image = image;
                }
                else
                {
                    pictureBox1.Image = null;
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
                pictureBox1.Image = null;
            }
            return true;
        }
        private void ReadDataFromFile(string filePath, DataTable dataTable)
        {
            Stopwatch stopwatch = Stopwatch.StartNew();
            try
            {
                // 讀取txt文件的每一行
                string[] lines = File.ReadAllLines(filePath);

                // 解析每一行的資料，並將其加入 DataTable
                foreach (string line in lines)
                {
                    string[] parts = line.Split('\t');
                    if (parts.Length == 2)
                    {
                        dataTable.Rows.Add(parts[0], parts[1]);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("發生錯誤: " + ex.Message);
            }
            stopwatch.Stop();
            TimeSpan elapsedTime = stopwatch.Elapsed;
            Console.Write($"ItemDB 搜尋耗時 : {elapsedTime.TotalMilliseconds / 1000} 秒");
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox_Select.Text))
            {
                Stopwatch stopwatch = Stopwatch.StartNew();
                string searchText = textBox_Select.Text;
                int rowIndex = -1;
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.Cells["ID"].Value != null && row.Cells["ID"].Value.ToString() == searchText)
                    {
                        row.Selected = true;
                        rowIndex = row.Index;
                        break;
                    }
                    if (row.Cells["Text_Name1"].Value != null && row.Cells["Text_Name1"].Value.ToString() == searchText)
                    {
                        row.Selected = true;
                        rowIndex = row.Index;
                        break;
                    }
                }

                if (rowIndex != -1)
                {
                    dataGridView1.FirstDisplayedScrollingRowIndex = rowIndex;
                }
                else
                {
                    MessageBox.Show("找不到符合的資料。");
                }

                stopwatch.Stop();
                TimeSpan elapsedTime = stopwatch.Elapsed;
                label1.Text = $"ItemDB 搜尋耗時 : {elapsedTime.TotalMilliseconds/1000} 秒";
            }
        }

        private void button_test_Click(object sender, EventArgs e)
        {
            Stopwatch stopwatch = Stopwatch.StartNew();
            DataSet dataSet = new DataSet();
            dataGridView1.DataSource = null;
            try
            {
                // 使用 XElement.Load 從 XML 檔案中讀取資料
                XElement xmlData = XElement.Load("ItemDB.xml");
                DataTable dataTable_itemdb = new DataTable();
                dataTable_itemdb.Columns.Add("ID");
                dataTable_itemdb.Columns.Add("DB_StoreType");
                dataTable_itemdb.Columns.Add("Category");
                dataTable_itemdb.Columns.Add("XML");
                dataTable_itemdb.Columns.Add("Text_Name0");
                dataTable_itemdb.Columns.Add("Locale");
                dataTable_itemdb.Columns.Add("feature");
                dataTable_itemdb.Columns.Add("Text_Name1");
                dataTable_itemdb.Columns.Add("Text_Desc1");
                dataTable_itemdb.Columns.Add("Bundle_Type");
                dataTable_itemdb.Columns.Add("Bundle_Max");
                dataTable_itemdb.Columns.Add("Price_Buy");
                dataTable_itemdb.Columns.Add("Price_Sell");
                dataTable_itemdb.Columns.Add("Attr_ActionFlag");
                dataTable_itemdb.Columns.Add("Attr_Type");
                dataTable_itemdb.Columns.Add("Attr_Grade");
                dataTable_itemdb.Columns.Add("Attr_RaceFilter");
                dataTable_itemdb.Columns.Add("File_MaleMesh");
                dataTable_itemdb.Columns.Add("File_FemaleMesh");
                dataTable_itemdb.Columns.Add("File_GiantMesh");
                dataTable_itemdb.Columns.Add("File_FemaleGiantMesh");
                dataTable_itemdb.Columns.Add("File_FieldMesh");
                dataTable_itemdb.Columns.Add("File_InvImage");
                dataTable_itemdb.Columns.Add("Inv_XSize");
                dataTable_itemdb.Columns.Add("Inv_YSize");
                dataTable_itemdb.Columns.Add("App_WeaponActionType");
                dataTable_itemdb.Columns.Add("App_WearType");
                dataTable_itemdb.Columns.Add("App_UseC4Layer");
                dataTable_itemdb.Columns.Add("App_Color1");
                dataTable_itemdb.Columns.Add("App_Color2");
                dataTable_itemdb.Columns.Add("App_Color3");
                dataTable_itemdb.Columns.Add("App_Color5");
                dataTable_itemdb.Columns.Add("App_Color6");
                dataTable_itemdb.Columns.Add("App_Color7");
                dataTable_itemdb.Columns.Add("App_ColorOrder");
                dataTable_itemdb.Columns.Add("App_AnimationType");
                dataTable_itemdb.Columns.Add("App_SittingType");
                dataTable_itemdb.Columns.Add("Taste_Beauty");
                dataTable_itemdb.Columns.Add("Taste_Indivisuality");
                dataTable_itemdb.Columns.Add("Taste_Luxury");
                dataTable_itemdb.Columns.Add("Taste_Toughness");
                dataTable_itemdb.Columns.Add("Taste_Utility");
                dataTable_itemdb.Columns.Add("Taste_Rarity");
                dataTable_itemdb.Columns.Add("Taste_Meaning");
                dataTable_itemdb.Columns.Add("Taste_Adult");
                dataTable_itemdb.Columns.Add("Taste_Maniac");
                dataTable_itemdb.Columns.Add("Taste_Anime");
                dataTable_itemdb.Columns.Add("Taste_Sexy");
                dataTable_itemdb.Columns.Add("File_WallMesh");
                dataTable_itemdb.Columns.Add("Metalware_UItooltip");
                dataTable_itemdb.Columns.Add("Enchant_UItooltip");
                dataTable_itemdb.Columns.Add("Upgrade_UItooltip");
                dataTable_itemdb.Columns.Add("Par_BlockUseFlag");
                dataTable_itemdb.Columns.Add("Par_UpgradeMax");
                dataTable_itemdb.Columns.Add("Par_GemUpgradeMax");
                dataTable_itemdb.Columns.Add("Par_DurabilityMax");
                dataTable_itemdb.Columns.Add("Par_Defense");
                dataTable_itemdb.Columns.Add("Par_ProtectRate");
                dataTable_itemdb.Columns.Add("Par_AttackMin");
                dataTable_itemdb.Columns.Add("Par_AttackMax");
                dataTable_itemdb.Columns.Add("Par_WAttackMin");
                dataTable_itemdb.Columns.Add("Par_WAttackMax");
                dataTable_itemdb.Columns.Add("Par_CriticalRate");
                dataTable_itemdb.Columns.Add("Par_AttackBalance");
                dataTable_itemdb.Columns.Add("Par_EffectiveRange");
                dataTable_itemdb.Columns.Add("Par_AttackSpeed");
                dataTable_itemdb.Columns.Add("Par_DownHitCount");
                dataTable_itemdb.Columns.Add("Par_BasicOption");
                dataTable_itemdb.Columns.Add("Attr_ItemEnhanceSet");
                dataTable_itemdb.Columns.Add("Shopping_Book_Type");
                dataTable_itemdb.Columns.Add("Food_BlockUseFlag");
                dataTable_itemdb.Columns.Add("Food_Type");
                dataTable_itemdb.Columns.Add("Food_Amount");
                dataTable_itemdb.Columns.Add("Food_AmountFlag");
                dataTable_itemdb.Columns.Add("Food_Str");
                dataTable_itemdb.Columns.Add("Food_Int");
                dataTable_itemdb.Columns.Add("Food_Dex");
                dataTable_itemdb.Columns.Add("Food_Will");
                dataTable_itemdb.Columns.Add("Food_Luck");
                dataTable_itemdb.Columns.Add("Food_Life");
                dataTable_itemdb.Columns.Add("Food_Mana");
                dataTable_itemdb.Columns.Add("Food_Stamina");
                dataTable_itemdb.Columns.Add("Food_Fatness");
                dataTable_itemdb.Columns.Add("Food_Upper");
                dataTable_itemdb.Columns.Add("Food_Lower");
                dataTable_itemdb.Columns.Add("Food_Toxic");
                dataTable_itemdb.Columns.Add("FoodEffectXML");
                dataTable_itemdb.Columns.Add("SmartSearchFlag");
                dataTable_itemdb.Columns.Add("AuctionSearchFlag");

                foreach (XElement element in xmlData.Elements("Mabi_Item"))
                {
                    DataRow row = dataTable_itemdb.NewRow();
                    foreach (XAttribute attribute in element.Attributes())
                    {
                        string attributeName = attribute.Name.LocalName;
                        string attributeValue = attribute.Value;

                        if ((attribute.Name == "Text_Name1" || attribute.Name == "Text_Desc1") && attribute.Value.Contains("_LT[xml.itemdb"))
                        {
                            string result = "";
                            string namestring = attributeValue;
                            int startIndex = namestring.IndexOf("_LT[xml.itemdb.") + "_LT[xml.itemdb.".Length;
                            int endIndex = namestring.IndexOf("]", startIndex);
                            if (startIndex != -1 && endIndex != -1)
                            {
                                // 截取所需的字串
                                result = namestring.Substring(startIndex, endIndex - startIndex);
                                DataRow[] foundRows = dataSet1.Tables["itemDataTable"].Select($"ID='{result}'");
                                if (foundRows.Length > 0)
                                {
                                    foreach (DataRow rows in foundRows)
                                    {
                                        row[attributeName] = rows["Description"].ToString();
                                    }
                                }
                                else
                                {
                                    row[attributeName] = attribute.Value;
                                }
                            }
                        }
                        else
                        {
                            row[attributeName] = attribute.Value;
                        }
                    }
                    dataTable_itemdb.Rows.Add(row);
                    
                }
                dataSet.Tables.Add(dataTable_itemdb);
                dataGridView1.DataSource = dataSet.Tables[0];

                stopwatch.Stop();
                TimeSpan elapsedTime = stopwatch.Elapsed;
                label1.Text = $"ItemDB 搜尋耗時 : {elapsedTime.TotalMilliseconds / 1000} 秒";
            }
            catch (Exception ex)
            {
                MessageBox.Show("發生錯誤: " + ex);
            }
        }
    }
}
