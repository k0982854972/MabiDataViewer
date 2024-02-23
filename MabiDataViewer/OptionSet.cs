using System;
using System.IO;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;

namespace MabiDataViewer
{
    internal class OptionSet
    {
        private readonly Form1 _form1;
        public OptionSet(Form1 form1)
        {
            _form1 = form1;
        }

        public DataTable GetOptionSetStringName(DataTable dataTable)
        {
            try
            {
                string filePath = "OptionSet.china.txt"; //需放置於程式同層目錄
                dataTable = new DataTable("OptionSetDataTable");
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return dataTable;
        }

        public DataTable GetOptionSet(DataTable dataTable, DataSet dataSet)
        {
            try
            {
                XElement xmlData = XElement.Load("OptionSet.xml"); //需放置於程式同層目錄
                dataTable = getTable();
                //對Mabi_Item節點進行搜尋
                foreach (XElement element in from optionSet in xmlData.Descendants("OptionSet") select optionSet)
                {
                    DataRow row = dataTable.NewRow();
                    foreach (XAttribute attribute in element.Attributes())
                    {
                        //取得每次節點的名稱與屬性
                        string attributeName = attribute.Name.ToString();
                        string attributeValue = attribute.Value;

                        //處理_LT[xml.itemdb.]字段
                        if ((attributeName == "LocalName2" ||
                             attributeName == "OptionDesc") &&
                             attributeValue.Contains("_LT[xml.optionset"))
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
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return dataTable;
        }

        public DataTable GetOptionSetFilteredSerach(string filtered, DataSet dataSet)
        {
            try 
            { 
                var query = from row in dataSet.Tables[0].AsEnumerable()
                            where row.Field<string>(_form1.radioButton_OptionSetID.Checked ? "ID" : _form1.radioButton_OptionSetName.Checked ? "LocalName2" : "OptionDesc").Contains($"{filtered}")
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

        private static DataTable getTable()
        {
            DataTable dataTable = new DataTable();
            dataTable = new DataTable();
            dataTable.Columns.Add("ID");
            dataTable.Columns.Add("Name");
            dataTable.Columns.Add("LocalName2");
            dataTable.Columns.Add("OptionList");
            dataTable.Columns.Add("OptionDesc");
            dataTable.Columns.Add("Level");
            dataTable.Columns.Add("RepairCostRate");
            dataTable.Columns.Add("IsIgnoreLevel");
            dataTable.Columns.Add("AllowItem");
            dataTable.Columns.Add("BlockItem");
            dataTable.Columns.Add("Usage");
            dataTable.Columns.Add("IsAlwaysSuccess");
            return dataTable;
        }

        private string foundNames(string attributeValue, DataSet dataSet)
        {
            //將內容解析出特定範圍字串，並對dataSet1進行Select匹配
            string cellContent = attributeValue.Split(']')[0].Split('.')[2];
            if (!string.IsNullOrEmpty(cellContent))
            {
                DataRow[] foundRows = dataSet.Tables["OptionSetDataTable"].Select($"ID='{cellContent}'");
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
    }
}
