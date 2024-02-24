using System;
using System.IO;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Net;

namespace MabiDataViewer
{
    internal class ItemDB
    {
        private readonly Form1 _form1;
        public ItemDB(Form1 form1)
        {
            _form1 = form1;
        }

        public DataTable GetItemStringName(DataTable dataTable)
        {
            try
            {
                string filePath = "ItemDB.china.txt"; //需放置於程式同層目錄
                dataTable = new DataTable("itemDataTable");
                dataTable.Columns.Add("ID"); dataTable.Columns.Add("Description");
                // 讀取txt文件的每一行，並存入dataTable
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
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return dataTable;
        }

        public DataTable GetItemDB(DataTable dataTable, DataSet dataSet)
        {
            try
            {
                XElement xmlData = XElement.Load("ItemDB.xml"); //需放置於程式同層目錄
                dataTable = getTable();
                //對Mabi_Item節點進行搜尋
                foreach (XElement element in from Items in xmlData.Descendants("Mabi_Item") select Items)
                {
                    DataRow row = dataTable.NewRow();
                    foreach (XAttribute attribute in element.Attributes())
                    {
                        //取得每次節點的名稱與屬性
                        string attributeName = attribute.Name.ToString();
                        string attributeValue = attribute.Value;

                        //處理_LT[xml.itemdb.]字段
                        if ((attributeName == "Text_Name1" ||
                             attributeName == "Text_Desc1") &&
                             attributeValue.Contains("_LT[xml.itemdb"))
                        {
                            row[attributeName] = foundNames(attributeValue, dataSet);
                        }
                        else
                        {
                            if (dataTable.Columns.Contains(attributeName))
                            {
                                row[attributeName] = attributeValue;
                            }
                        }
                    }
                    dataTable.Rows.Add(row);
                }
                return dataTable;
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
            return dataTable;
        }

        public DataTable GetItemFilteredSerach(string filtered, DataSet dataSet)
        {
            try
            {
                var query = from row in dataSet.Tables[0].AsEnumerable()
                        where row.Field<string>(_form1.radioButton_SerachID.Checked ? "ID" : "Text_Name1").Contains(filtered)
                        select row;

                DataTable filteredDataTable = query.CopyToDataTable();
                return filteredDataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("未搜尋到任何結果");
            }
            return null;
        }

        public System.Drawing.Image GetItemPicture(string itemID)
        {
            try
            {
                //從伺服器擷取對應ID圖片
                string imageUrl = $"http://suiyue.me/Info/item/{itemID}.png";
                WebRequest request = WebRequest.Create(imageUrl);
                WebResponse response = request.GetResponse();
                if (((HttpWebResponse)response).StatusCode == HttpStatusCode.OK)
                {
                    System.Drawing.Image image;
                    // 從 WebResponse 中取得圖片
                    Stream stream = response.GetResponseStream();
                    // 使用 Image.FromStream 方法從stream中創建圖片
                    image = System.Drawing.Image.FromStream(stream);
                    stream.Close();
                    return image;
                }
                response.Close();
            }
            catch (Exception ex) 
            { 
                return null;
            }
            return null;
        }

        public bool GetActionFlag(DataGridView dt, int row)
        {
            switch (dt.Rows[row].Cells[9].Value.ToString())
            {
                case "0":
                    foreach (Control control in _form1.groupBox_ActionFlag.Controls)
                    {
                        if (control is CheckBox checkBox)
                        {
                            checkBox.Checked = true;
                        }
                    }
                    _form1.checkBox_DropLock.Checked = false; _form1.checkBox_BankCharacter.Checked = false; _form1.checkBox_Destroy.Checked = false;
                    break;
                case "1":
                    _form1.checkBox_DropLock.Checked = true; _form1.checkBox_Mail.Checked = true;
                    break;
                case "2":
                    break;
                case "3":
                    _form1.checkBox_DropLock.Checked = true; _form1.checkBox_BankAccount.Checked = true;
                    break;
                case "4":
                    _form1.checkBox_Trade.Checked = true; _form1.checkBox_DropFree.Checked = true;
                    break;
                case "5":
                    _form1.checkBox_DropLock.Checked = true; _form1.checkBox_BankCharacter.Checked = true;
                    break;
                case "6":
                case "7":
                case "8":
                    break;
                case "9":
                    _form1.checkBox_DropLock.Checked = true;
                    break;
                case "10":
                    _form1.checkBox_Destroy.Checked = true; _form1.checkBox_BankCharacter.Checked = true;
                    break;
                case "12":
                    _form1.checkBox_Destroy.Checked = true; _form1.checkBox_BankAccount.Checked = true; _form1.checkBox_Pet.Checked = true;
                    break;
                case "13":
                    _form1.checkBox_BankCharacter.Checked = true;
                    break;
                case "14":
                    _form1.checkBox_TradeLimit.Checked = true; _form1.checkBox_DropLock.Checked = true; _form1.checkBox_BankAccount.Checked = true;
                    break;
                case "16":
                    _form1.checkBox_DropLock.Checked = true;
                    break;
                case "17":
                    _form1.checkBox_DropLock.Checked = true; _form1.checkBox_BankAccount.Checked = true;
                    break;

            }
            //例外處理
            if (dt.Rows[row].Cells[1].Value.ToString().Contains("destroyable"))
            {
                _form1.checkBox_Destroy.Checked = true;
            }
            if (dt.Rows[row].Cells[1].Value.ToString().Contains("not_dropable"))
            {
                _form1.checkBox_DropFree.Checked = false;
                _form1.checkBox_DropLock.Checked = false;
            }
            if (dt.Rows[row].Cells[1].Value.ToString().Contains("not_mailbox"))
            {
                _form1.checkBox_Mail.Checked = false;
            }
            if (dt.Rows[row].Cells[12].Value.ToString().Contains("true"))
            {
                _form1.checkBox_dyeable.Checked = true;
                if (dt.Rows[row].Cells[1].Value.ToString().Contains("not_dyeable"))
                {
                    _form1.checkBox_dyeable.Checked = false;
                }
            }
            return true;
        }

        private static DataTable getTable()
        {
            DataTable dataTable = new DataTable();
            dataTable = new DataTable();
            dataTable.Columns.Add("ID");
            //dataTable.Columns.Add("DB_StoreType");
            dataTable.Columns.Add("Category");
            dataTable.Columns.Add("XML");
            dataTable.Columns.Add("Text_Name0");
            //dataTable.Columns.Add("Locale");
            //dataTable.Columns.Add("feature");
            dataTable.Columns.Add("Text_Name1");
            dataTable.Columns.Add("Text_Desc1");
            //dataTable.Columns.Add("Bundle_Type");
            dataTable.Columns.Add("Bundle_Max");
            dataTable.Columns.Add("Price_Buy");
            dataTable.Columns.Add("Price_Sell");
            dataTable.Columns.Add("Attr_ActionFlag");
            //dataTable.Columns.Add("Attr_Type");
            //dataTable.Columns.Add("Attr_Grade");
            //dataTable.Columns.Add("Attr_RaceFilter");
            //dataTable.Columns.Add("File_MaleMesh");
            //dataTable.Columns.Add("File_FemaleMesh");
            //dataTable.Columns.Add("File_GiantMesh");
            //dataTable.Columns.Add("File_FemaleGiantMesh");
            //dataTable.Columns.Add("File_FieldMesh");
            //dataTable.Columns.Add("File_InvImage");
            dataTable.Columns.Add("Inv_XSize");
            dataTable.Columns.Add("Inv_YSize");
            //dataTable.Columns.Add("App_WeaponActionType");
            //dataTable.Columns.Add("App_WearType");
            dataTable.Columns.Add("App_UseC4Layer");
            //dataTable.Columns.Add("App_Color1");
            //dataTable.Columns.Add("App_Color2");
            //dataTable.Columns.Add("App_Color3");
            //dataTable.Columns.Add("App_Color5");
            //dataTable.Columns.Add("App_Color6");
            //dataTable.Columns.Add("App_Color7");
            //dataTable.Columns.Add("App_ColorOrder");
            //dataTable.Columns.Add("App_AnimationType");
            //dataTable.Columns.Add("App_SittingType");
            //dataTable.Columns.Add("Taste_Beauty");
            //dataTable.Columns.Add("Taste_Indivisuality");
            //dataTable.Columns.Add("Taste_Luxury");
            //dataTable.Columns.Add("Taste_Toughness");
            //dataTable.Columns.Add("Taste_Utility");
            //dataTable.Columns.Add("Taste_Rarity");
            //dataTable.Columns.Add("Taste_Meaning");
            //dataTable.Columns.Add("Taste_Adult");
            //dataTable.Columns.Add("Taste_Maniac");
            //dataTable.Columns.Add("Taste_Anime");
            //dataTable.Columns.Add("Taste_Sexy");
            //dataTable.Columns.Add("File_WallMesh");
            //dataTable.Columns.Add("Metalware_UItooltip");
            //dataTable.Columns.Add("Enchant_UItooltip");
            //dataTable.Columns.Add("Upgrade_UItooltip");
            //dataTable.Columns.Add("Par_BlockUseFlag");
            //dataTable.Columns.Add("Par_UpgradeMax");
            //dataTable.Columns.Add("Par_GemUpgradeMax");
            //dataTable.Columns.Add("Par_DurabilityMax");
            //dataTable.Columns.Add("Par_Defense");
            //dataTable.Columns.Add("Par_ProtectRate");
            //dataTable.Columns.Add("Par_AttackMin");
            //dataTable.Columns.Add("Par_AttackMax");
            //dataTable.Columns.Add("Par_WAttackMin");
            //dataTable.Columns.Add("Par_WAttackMax");
            //dataTable.Columns.Add("Par_CriticalRate");
            //dataTable.Columns.Add("Par_AttackBalance");
            //dataTable.Columns.Add("Par_EffectiveRange");
            //dataTable.Columns.Add("Par_AttackSpeed");
            //dataTable.Columns.Add("Par_DownHitCount");
            //dataTable.Columns.Add("Par_BasicOption");
            //dataTable.Columns.Add("Attr_ItemEnhanceSet");
            //dataTable.Columns.Add("Shopping_Book_Type");
            //dataTable.Columns.Add("Food_BlockUseFlag");
            //dataTable.Columns.Add("Food_Type");
            //dataTable.Columns.Add("Food_Amount");
            //dataTable.Columns.Add("Food_AmountFlag");
            //dataTable.Columns.Add("Food_Str");
            //dataTable.Columns.Add("Food_Int");
            //dataTable.Columns.Add("Food_Dex");
            //dataTable.Columns.Add("Food_Will");
            //dataTable.Columns.Add("Food_Luck");
            //dataTable.Columns.Add("Food_Life");
            //dataTable.Columns.Add("Food_Mana");
            //dataTable.Columns.Add("Food_Stamina");
            //dataTable.Columns.Add("Food_Fatness");
            //dataTable.Columns.Add("Food_Upper");
            //dataTable.Columns.Add("Food_Lower");
            //dataTable.Columns.Add("Food_Toxic");
            //dataTable.Columns.Add("FoodEffectXML");
            //dataTable.Columns.Add("SmartSearchFlag");
            //dataTable.Columns.Add("AuctionSearchFlag");
            return dataTable;
        }

        private string foundNames(string attributeValue, DataSet dataSet)
        {
            //將內容解析出特定範圍字串，並對dataSet1進行Select匹配
            string cellContent = attributeValue.Split(']')[0].Split('.')[2];
            if (!string.IsNullOrEmpty(cellContent))
            {
                DataRow[] foundRows = dataSet.Tables["itemDataTable"].Select($"ID='{cellContent}'");
                if (foundRows != null)
                {
                    foreach (DataRow rows in foundRows)
                    {
                        return rows["Description"].ToString();
                    }
                }
            }
            return null;
        }
    }
}
