using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.Remoting.Messaging;
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
            radioButton_SerachID.CheckedChanged += (sender, e) =>
            {
                radioButton_SearchName.Checked = radioButton_SerachID.Checked ? false : radioButton_SearchName.Checked;
            };
            radioButton_SearchName.CheckedChanged += (sender, e) =>
            {
                radioButton_SerachID.Checked = radioButton_SearchName.Checked ? false : radioButton_SerachID.Checked;
            };
        }
        private DataTable dataTable;
        private DataTable dataTable_itemdb;
        private DataSet dataSet = new DataSet();
        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                Stopwatch stopwatch = Stopwatch.StartNew();
                //建立_LT[xml.itemdb.]所需對照的Data
                this.dataTable = new DataTable("itemDataTable");
                this.dataTable.Columns.Add("ID");
                this.dataTable.Columns.Add("Description");
                dataSet1.Tables.Add(this.dataTable);
                string filePath = "ItemDB.china.txt";
                ReadDataFromFile(filePath, this.dataTable);

                //建立ItemDB資料表
                XElement xmlData = XElement.Load("ItemDB.xml");
                DataTable dataTable_itemdb = getTable();

                //對Mabi_Item節點進行搜尋
                foreach (XElement element in xmlData.Elements("Mabi_Item"))
                {
                    DataRow row = dataTable_itemdb.NewRow();
                    //取得所有子節點名稱與屬性
                    foreach (XAttribute attribute in element.Attributes())
                    {
                        string attributeName = attribute.Name.ToString();
                        string attributeValue = attribute.Value;

                        //處理_LT[xml.itemdb.]字段
                        if ((attributeName == "Text_Name1" ||
                             attributeName == "Text_Desc1") &&
                             attributeValue.Contains("_LT[xml.itemdb"))
                        {
                            row[attributeName] = foundNames(attributeName, attributeValue, row);
                        }
                        else
                        {
                            if (dataTable_itemdb.Columns.Contains(attributeName))
                            {
                                row[attributeName] = attributeValue;
                            }
                        }
                    }
                    dataTable_itemdb.Rows.Add(row);
                }

                //將資料存入dataSet.Tables
                dataSet.Tables.Add(dataTable_itemdb);
                dataGridView1.DataSource = dataSet.Tables[0];
                dataGridView1.Columns[1].Visible = false;
                dataGridView1.Columns[2].Visible = false;
                dataGridView1.Columns[12].Visible = false;

                stopwatch.Stop();
                label1.Text = $"ItemDB 讀取耗時 : {stopwatch.Elapsed.TotalMilliseconds / 1000} 秒";
                
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
                
                int row = e.RowIndex;
                int col = e.ColumnIndex;
                DataGridView dt = sender as DataGridView;
                string ColumnName = dt.Columns[col].DataPropertyName;
                textBox_ItemCategory.Text = dt.Rows[row].Cells[1].Value.ToString();
                textBox_ItemXML.Text = dt.Rows[row].Cells[2].Value.ToString();
                textBox_ItemDesc.Text = dt.Rows[row].Cells[5].Value.ToString();
                label_ItemID.Text = "道具編號: " + dt.Rows[row].Cells[0].Value.ToString();
                label_ItemName.Text = "道具名稱: " + dt.Rows[row].Cells[4].Value.ToString();
                label_Bundle.Text = "最大堆疊: " + dt.Rows[row].Cells[6].Value.ToString();
                groupBox_checkbox.Text = "Action Flag: " + dt.Rows[row].Cells[9].Value.ToString();
                Update_checkbox(dt, row, col);
                Update_picturebox(dt, row, col);
            }
        }
        private bool Update_checkbox(DataGridView dt, int row, int col)
        {
            //預設所有Checkbox為不勾選
            foreach (Control control in groupBox_checkbox.Controls)
            {
                if (control is CheckBox checkBox)
                {
                    checkBox.Checked = false;
                }
            }

            switch (dt.Rows[row].Cells[9].Value.ToString())
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
            //例外處理
            if (dt.Rows[row].Cells[1].Value.ToString().Contains("destroyable"))
            {
                checkBox_Destroy.Checked = true;
            }
            if (dt.Rows[row].Cells[1].Value.ToString().Contains("not_dropable"))
            {
                checkBox_DropFree.Checked = false;
                checkBox_DropLock.Checked = false;
            }
            if (dt.Rows[row].Cells[1].Value.ToString().Contains("not_mailbox"))
            {
                checkBox_Mail.Checked = false;
            }
            if (dt.Rows[row].Cells[12].Value.ToString().Contains("true"))
            {
                checkBox_dyeable.Checked = true;
                if (dt.Rows[row].Cells[1].Value.ToString().Contains("not_dyeable"))
                {
                    checkBox_dyeable.Checked = false;
                }
            }
            return true;
        }
        private bool Update_picturebox(DataGridView dt, int row, int col)
        {
            //從伺服器擷取對應ID圖片
            string imageUrl = "http://suiyue.me/Info/item/" + dt.Rows[row].Cells[0].Value.ToString() + ".png";
            pictureBox1.Image = null;
            WebRequest request = WebRequest.Create(imageUrl);
            try
            {
                WebResponse response = request.GetResponse();
                System.Drawing.Image image;
                if (((HttpWebResponse)response).StatusCode == HttpStatusCode.OK)
                {
                    // 從 WebResponse 中取得圖片
                    Stream stream = response.GetResponseStream();
                    // 使用 Image.FromStream 方法從stream中創建圖片
                    image = System.Drawing.Image.FromStream(stream);
                    pictureBox1.Image = image;
                    stream.Close();
                }
                else
                {
                    pictureBox1.Image = null;
                }
                response.Close();
            }
            catch (Exception ex)
            {
                pictureBox1.Image = null;
            }
            return true;
        }
        private void ReadDataFromFile(string filePath, DataTable dataTable)
        {
            //將ItemDB.china.txt內容逐一寫入dataTable
            try
            {
                // 讀取txt文件的每一行
                string[] lines = File.ReadAllLines(filePath);
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
        }
        private void button_ItemSelect_Click(object sender, EventArgs e)
        {
            Stopwatch stopwatch = Stopwatch.StartNew();
            try
            {
                if (!string.IsNullOrEmpty(textBox_ItemSerach.Text))
                {
                    
                    string searchText = textBox_ItemSerach.Text;
                    var query = from row in dataSet.Tables[0].AsEnumerable()
                                where row.Field<string>(radioButton_SerachID.Checked ? "ID" : "Text_Name1").Contains(searchText)
                                select row;
                    DataTable filteredDataTable = query.CopyToDataTable();
                    dataGridView1.DataSource = filteredDataTable;
                    stopwatch.Stop();
                    label1.Text = $"ItemDB 搜尋耗時 : {stopwatch.Elapsed.TotalMilliseconds / 1000} 秒, 共 {query.Count()} 筆資料";
                }
            }
            catch(Exception ex)
            {
                label1.Text = $"ItemDB 搜尋耗時 : ";
                MessageBox.Show("查無結果");
            }
        }
        private string foundNames(string attributeName, string attributeValue, DataRow row)
        {
            //將內容解析出特定範圍字串，並對dataSet1進行Select匹配
            string cellContent = attributeValue.Split(']')[0].Split('.')[2];
            if (!string.IsNullOrEmpty(cellContent))
            {
                DataRow[] foundRows = dataSet1.Tables["itemDataTable"].Select($"ID='{cellContent}'");
                if (foundRows != null)
                {
                    foreach (DataRow rows in foundRows)
                    {
                        return rows["Description"].ToString();
                    }
                }
            }
            return attributeValue;
        }
        private DataTable getTable () {
            DataTable dataTable_itemdb = new DataTable();
            dataTable_itemdb.Columns.Add("ID");
            //dataTable_itemdb.Columns.Add("DB_StoreType");
            dataTable_itemdb.Columns.Add("Category");
            dataTable_itemdb.Columns.Add("XML");
            dataTable_itemdb.Columns.Add("Text_Name0");
            //dataTable_itemdb.Columns.Add("Locale");
            //dataTable_itemdb.Columns.Add("feature");
            dataTable_itemdb.Columns.Add("Text_Name1");
            dataTable_itemdb.Columns.Add("Text_Desc1");
            //dataTable_itemdb.Columns.Add("Bundle_Type");
            dataTable_itemdb.Columns.Add("Bundle_Max");
            dataTable_itemdb.Columns.Add("Price_Buy");
            dataTable_itemdb.Columns.Add("Price_Sell");
            dataTable_itemdb.Columns.Add("Attr_ActionFlag");
            //dataTable_itemdb.Columns.Add("Attr_Type");
            //dataTable_itemdb.Columns.Add("Attr_Grade");
            //dataTable_itemdb.Columns.Add("Attr_RaceFilter");
            //dataTable_itemdb.Columns.Add("File_MaleMesh");
            //dataTable_itemdb.Columns.Add("File_FemaleMesh");
            //dataTable_itemdb.Columns.Add("File_GiantMesh");
            //dataTable_itemdb.Columns.Add("File_FemaleGiantMesh");
            //dataTable_itemdb.Columns.Add("File_FieldMesh");
            //dataTable_itemdb.Columns.Add("File_InvImage");
            dataTable_itemdb.Columns.Add("Inv_XSize");
            dataTable_itemdb.Columns.Add("Inv_YSize");
            //dataTable_itemdb.Columns.Add("App_WeaponActionType");
            //dataTable_itemdb.Columns.Add("App_WearType");
            dataTable_itemdb.Columns.Add("App_UseC4Layer");
            //dataTable_itemdb.Columns.Add("App_Color1");
            //dataTable_itemdb.Columns.Add("App_Color2");
            //dataTable_itemdb.Columns.Add("App_Color3");
            //dataTable_itemdb.Columns.Add("App_Color5");
            //dataTable_itemdb.Columns.Add("App_Color6");
            //dataTable_itemdb.Columns.Add("App_Color7");
            //dataTable_itemdb.Columns.Add("App_ColorOrder");
            //dataTable_itemdb.Columns.Add("App_AnimationType");
            //dataTable_itemdb.Columns.Add("App_SittingType");
            //dataTable_itemdb.Columns.Add("Taste_Beauty");
            //dataTable_itemdb.Columns.Add("Taste_Indivisuality");
            //dataTable_itemdb.Columns.Add("Taste_Luxury");
            //dataTable_itemdb.Columns.Add("Taste_Toughness");
            //dataTable_itemdb.Columns.Add("Taste_Utility");
            //dataTable_itemdb.Columns.Add("Taste_Rarity");
            //dataTable_itemdb.Columns.Add("Taste_Meaning");
            //dataTable_itemdb.Columns.Add("Taste_Adult");
            //dataTable_itemdb.Columns.Add("Taste_Maniac");
            //dataTable_itemdb.Columns.Add("Taste_Anime");
            //dataTable_itemdb.Columns.Add("Taste_Sexy");
            //dataTable_itemdb.Columns.Add("File_WallMesh");
            //dataTable_itemdb.Columns.Add("Metalware_UItooltip");
            //dataTable_itemdb.Columns.Add("Enchant_UItooltip");
            //dataTable_itemdb.Columns.Add("Upgrade_UItooltip");
            //dataTable_itemdb.Columns.Add("Par_BlockUseFlag");
            //dataTable_itemdb.Columns.Add("Par_UpgradeMax");
            //dataTable_itemdb.Columns.Add("Par_GemUpgradeMax");
            //dataTable_itemdb.Columns.Add("Par_DurabilityMax");
            //dataTable_itemdb.Columns.Add("Par_Defense");
            //dataTable_itemdb.Columns.Add("Par_ProtectRate");
            //dataTable_itemdb.Columns.Add("Par_AttackMin");
            //dataTable_itemdb.Columns.Add("Par_AttackMax");
            //dataTable_itemdb.Columns.Add("Par_WAttackMin");
            //dataTable_itemdb.Columns.Add("Par_WAttackMax");
            //dataTable_itemdb.Columns.Add("Par_CriticalRate");
            //dataTable_itemdb.Columns.Add("Par_AttackBalance");
            //dataTable_itemdb.Columns.Add("Par_EffectiveRange");
            //dataTable_itemdb.Columns.Add("Par_AttackSpeed");
            //dataTable_itemdb.Columns.Add("Par_DownHitCount");
            //dataTable_itemdb.Columns.Add("Par_BasicOption");
            //dataTable_itemdb.Columns.Add("Attr_ItemEnhanceSet");
            //dataTable_itemdb.Columns.Add("Shopping_Book_Type");
            //dataTable_itemdb.Columns.Add("Food_BlockUseFlag");
            //dataTable_itemdb.Columns.Add("Food_Type");
            //dataTable_itemdb.Columns.Add("Food_Amount");
            //dataTable_itemdb.Columns.Add("Food_AmountFlag");
            //dataTable_itemdb.Columns.Add("Food_Str");
            //dataTable_itemdb.Columns.Add("Food_Int");
            //dataTable_itemdb.Columns.Add("Food_Dex");
            //dataTable_itemdb.Columns.Add("Food_Will");
            //dataTable_itemdb.Columns.Add("Food_Luck");
            //dataTable_itemdb.Columns.Add("Food_Life");
            //dataTable_itemdb.Columns.Add("Food_Mana");
            //dataTable_itemdb.Columns.Add("Food_Stamina");
            //dataTable_itemdb.Columns.Add("Food_Fatness");
            //dataTable_itemdb.Columns.Add("Food_Upper");
            //dataTable_itemdb.Columns.Add("Food_Lower");
            //dataTable_itemdb.Columns.Add("Food_Toxic");
            //dataTable_itemdb.Columns.Add("FoodEffectXML");
            //dataTable_itemdb.Columns.Add("SmartSearchFlag");
            //dataTable_itemdb.Columns.Add("AuctionSearchFlag");
            return dataTable_itemdb;
        }
        private void button_ItemReset_Click(object sender, EventArgs e)
        {
            Stopwatch stopwatch = Stopwatch.StartNew();
            dataGridView1.DataSource = dataSet.Tables[0];
            dataGridView1.Columns[1].Visible = false;
            dataGridView1.Columns[2].Visible = false;
            dataGridView1.Columns[12].Visible = false;
            stopwatch.Stop();
            label1.Text = $"ItemDB 重置耗時 : {stopwatch.Elapsed.TotalMilliseconds / 1000} 秒";

        }
    }
}
