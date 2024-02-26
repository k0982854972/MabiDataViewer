using System.Drawing;

namespace MabiDataViewer
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dataGridView_ItemDB = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label_ItemSize = new System.Windows.Forms.Label();
            this.groupBox_ItemSelect = new System.Windows.Forms.GroupBox();
            this.button_ItemReset = new System.Windows.Forms.Button();
            this.button_ItemSearch = new System.Windows.Forms.Button();
            this.radioButton_SearchName = new System.Windows.Forms.RadioButton();
            this.radioButton_SerachID = new System.Windows.Forms.RadioButton();
            this.label_ItemKeyword = new System.Windows.Forms.Label();
            this.textBox_ItemKeyword = new System.Windows.Forms.TextBox();
            this.label_Bundle = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label_XML = new System.Windows.Forms.Label();
            this.label_Category = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox_ActionFlag = new System.Windows.Forms.GroupBox();
            this.checkBox_Mail = new System.Windows.Forms.CheckBox();
            this.checkBox_dyeable = new System.Windows.Forms.CheckBox();
            this.checkBox_TradeLimit = new System.Windows.Forms.CheckBox();
            this.checkBox_Trade = new System.Windows.Forms.CheckBox();
            this.checkBox_BankCharacter = new System.Windows.Forms.CheckBox();
            this.checkBox_DropFree = new System.Windows.Forms.CheckBox();
            this.checkBox_Pet = new System.Windows.Forms.CheckBox();
            this.checkBox_BankAccount = new System.Windows.Forms.CheckBox();
            this.checkBox_DropLock = new System.Windows.Forms.CheckBox();
            this.checkBox_Destroy = new System.Windows.Forms.CheckBox();
            this.textBox_ItemDesc = new System.Windows.Forms.TextBox();
            this.label_ItemName = new System.Windows.Forms.Label();
            this.textBox_ItemCategory = new System.Windows.Forms.TextBox();
            this.label_ItemID = new System.Windows.Forms.Label();
            this.textBox_ItemXML = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label_OptionSetRate = new System.Windows.Forms.Label();
            this.checkBox_OptionSetHelperBonus = new System.Windows.Forms.CheckBox();
            this.checkBox_OptionSetDayBonus = new System.Windows.Forms.CheckBox();
            this.label_OptionSetPowder = new System.Windows.Forms.Label();
            this.comboBox_OptionSetPowder = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox_OptionSetDesc = new System.Windows.Forms.GroupBox();
            this.textBox_OptionSetBlock = new System.Windows.Forms.TextBox();
            this.label_OptionSetBlock = new System.Windows.Forms.Label();
            this.textBox_OptionSetAllow = new System.Windows.Forms.TextBox();
            this.label_OptionSetAllow = new System.Windows.Forms.Label();
            this.label_OptionSetDesc = new System.Windows.Forms.Label();
            this.label_OptionSetID = new System.Windows.Forms.Label();
            this.textBox_OptionSetDesc = new System.Windows.Forms.TextBox();
            this.label_OptionSetFee = new System.Windows.Forms.Label();
            this.label_OptionSetName = new System.Windows.Forms.Label();
            this.label_OptionSetUsage = new System.Windows.Forms.Label();
            this.label_OptionSetLevel = new System.Windows.Forms.Label();
            this.label_OptionSetIgnore = new System.Windows.Forms.Label();
            this.groupBox_OptionSetSelect = new System.Windows.Forms.GroupBox();
            this.radioButton_OptionSetName = new System.Windows.Forms.RadioButton();
            this.button_OptionSetReset = new System.Windows.Forms.Button();
            this.button_OptionSetSearch = new System.Windows.Forms.Button();
            this.radioButton_OptionSetDesc = new System.Windows.Forms.RadioButton();
            this.radioButton_OptionSetID = new System.Windows.Forms.RadioButton();
            this.label_OptionSetKeyword = new System.Windows.Forms.Label();
            this.textBox_OptionSetKeyword = new System.Windows.Forms.TextBox();
            this.dataGridView_OptionSet = new System.Windows.Forms.DataGridView();
            this.ToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.dataSet1 = new System.Data.DataSet();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ItemDB)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox_ItemSelect.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox_ActionFlag.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox_OptionSetDesc.SuspendLayout();
            this.groupBox_OptionSetSelect.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_OptionSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_ItemDB
            // 
            this.dataGridView_ItemDB.AllowUserToAddRows = false;
            this.dataGridView_ItemDB.AllowUserToDeleteRows = false;
            this.dataGridView_ItemDB.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_ItemDB.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_ItemDB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_ItemDB.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView_ItemDB.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_ItemDB.Name = "dataGridView_ItemDB";
            this.dataGridView_ItemDB.ReadOnly = true;
            this.dataGridView_ItemDB.RowTemplate.Height = 24;
            this.dataGridView_ItemDB.Size = new System.Drawing.Size(1060, 914);
            this.dataGridView_ItemDB.TabIndex = 0;
            this.dataGridView_ItemDB.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_ItemDB_CellClick);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1454, 940);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label_ItemSize);
            this.tabPage1.Controls.Add(this.groupBox_ItemSelect);
            this.tabPage1.Controls.Add(this.label_Bundle);
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Controls.Add(this.label_XML);
            this.tabPage1.Controls.Add(this.label_Category);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.groupBox_ActionFlag);
            this.tabPage1.Controls.Add(this.textBox_ItemDesc);
            this.tabPage1.Controls.Add(this.label_ItemName);
            this.tabPage1.Controls.Add(this.textBox_ItemCategory);
            this.tabPage1.Controls.Add(this.label_ItemID);
            this.tabPage1.Controls.Add(this.textBox_ItemXML);
            this.tabPage1.Controls.Add(this.dataGridView_ItemDB);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1446, 914);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "ItemDB";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label_ItemSize
            // 
            this.label_ItemSize.AutoSize = true;
            this.label_ItemSize.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_ItemSize.Location = new System.Drawing.Point(1062, 268);
            this.label_ItemSize.Name = "label_ItemSize";
            this.label_ItemSize.Size = new System.Drawing.Size(78, 21);
            this.label_ItemSize.TabIndex = 30;
            this.label_ItemSize.Text = "道具大小:";
            // 
            // groupBox_ItemSelect
            // 
            this.groupBox_ItemSelect.Controls.Add(this.button_ItemReset);
            this.groupBox_ItemSelect.Controls.Add(this.button_ItemSearch);
            this.groupBox_ItemSelect.Controls.Add(this.radioButton_SearchName);
            this.groupBox_ItemSelect.Controls.Add(this.radioButton_SerachID);
            this.groupBox_ItemSelect.Controls.Add(this.label_ItemKeyword);
            this.groupBox_ItemSelect.Controls.Add(this.textBox_ItemKeyword);
            this.groupBox_ItemSelect.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox_ItemSelect.Location = new System.Drawing.Point(1066, 2);
            this.groupBox_ItemSelect.Name = "groupBox_ItemSelect";
            this.groupBox_ItemSelect.Size = new System.Drawing.Size(375, 85);
            this.groupBox_ItemSelect.TabIndex = 29;
            this.groupBox_ItemSelect.TabStop = false;
            this.groupBox_ItemSelect.Text = "搜尋道具";
            // 
            // button_ItemReset
            // 
            this.button_ItemReset.Enabled = false;
            this.button_ItemReset.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button_ItemReset.Location = new System.Drawing.Point(282, 24);
            this.button_ItemReset.Name = "button_ItemReset";
            this.button_ItemReset.Size = new System.Drawing.Size(82, 31);
            this.button_ItemReset.TabIndex = 33;
            this.button_ItemReset.Text = "重置結果";
            this.button_ItemReset.UseVisualStyleBackColor = true;
            this.button_ItemReset.Click += new System.EventHandler(this.button_ItemReset_Click);
            // 
            // button_ItemSearch
            // 
            this.button_ItemSearch.Enabled = false;
            this.button_ItemSearch.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button_ItemSearch.Location = new System.Drawing.Point(194, 24);
            this.button_ItemSearch.Name = "button_ItemSearch";
            this.button_ItemSearch.Size = new System.Drawing.Size(82, 31);
            this.button_ItemSearch.TabIndex = 30;
            this.button_ItemSearch.Text = "開始搜尋";
            this.button_ItemSearch.UseVisualStyleBackColor = true;
            this.button_ItemSearch.Click += new System.EventHandler(this.button_ItemSearch_Click);
            // 
            // radioButton_SearchName
            // 
            this.radioButton_SearchName.AutoSize = true;
            this.radioButton_SearchName.Location = new System.Drawing.Point(248, 54);
            this.radioButton_SearchName.Name = "radioButton_SearchName";
            this.radioButton_SearchName.Size = new System.Drawing.Size(124, 25);
            this.radioButton_SearchName.TabIndex = 32;
            this.radioButton_SearchName.Text = "道具名稱搜尋";
            this.radioButton_SearchName.UseVisualStyleBackColor = true;
            // 
            // radioButton_SerachID
            // 
            this.radioButton_SerachID.AutoSize = true;
            this.radioButton_SerachID.Checked = true;
            this.radioButton_SerachID.Location = new System.Drawing.Point(10, 54);
            this.radioButton_SerachID.Name = "radioButton_SerachID";
            this.radioButton_SerachID.Size = new System.Drawing.Size(109, 25);
            this.radioButton_SerachID.TabIndex = 31;
            this.radioButton_SerachID.TabStop = true;
            this.radioButton_SerachID.Text = "道具ID搜尋";
            this.radioButton_SerachID.UseVisualStyleBackColor = true;
            // 
            // label_ItemKeyword
            // 
            this.label_ItemKeyword.AutoSize = true;
            this.label_ItemKeyword.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_ItemKeyword.Location = new System.Drawing.Point(6, 30);
            this.label_ItemKeyword.Name = "label_ItemKeyword";
            this.label_ItemKeyword.Size = new System.Drawing.Size(58, 21);
            this.label_ItemKeyword.TabIndex = 30;
            this.label_ItemKeyword.Text = "關鍵字";
            // 
            // textBox_ItemKeyword
            // 
            this.textBox_ItemKeyword.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox_ItemKeyword.Location = new System.Drawing.Point(64, 25);
            this.textBox_ItemKeyword.Name = "textBox_ItemKeyword";
            this.textBox_ItemKeyword.Size = new System.Drawing.Size(122, 29);
            this.textBox_ItemKeyword.TabIndex = 30;
            this.ToolTip.SetToolTip(this.textBox_ItemKeyword, "輸入道具編號或名稱");
            // 
            // label_Bundle
            // 
            this.label_Bundle.AutoSize = true;
            this.label_Bundle.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_Bundle.Location = new System.Drawing.Point(1062, 235);
            this.label_Bundle.Name = "label_Bundle";
            this.label_Bundle.Size = new System.Drawing.Size(78, 21);
            this.label_Bundle.TabIndex = 28;
            this.label_Bundle.Text = "最大堆疊:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(1162, 459);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(192, 192);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // label_XML
            // 
            this.label_XML.AutoSize = true;
            this.label_XML.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_XML.Location = new System.Drawing.Point(1066, 758);
            this.label_XML.Name = "label_XML";
            this.label_XML.Size = new System.Drawing.Size(37, 27);
            this.label_XML.TabIndex = 26;
            this.label_XML.Text = "Xml";
            this.label_XML.UseCompatibleTextRendering = true;
            // 
            // label_Category
            // 
            this.label_Category.AutoSize = true;
            this.label_Category.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_Category.Location = new System.Drawing.Point(1062, 651);
            this.label_Category.Name = "label_Category";
            this.label_Category.Size = new System.Drawing.Size(80, 21);
            this.label_Category.TabIndex = 25;
            this.label_Category.Text = "Category";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(1062, 892);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 24;
            // 
            // groupBox_ActionFlag
            // 
            this.groupBox_ActionFlag.Controls.Add(this.checkBox_Mail);
            this.groupBox_ActionFlag.Controls.Add(this.checkBox_dyeable);
            this.groupBox_ActionFlag.Controls.Add(this.checkBox_TradeLimit);
            this.groupBox_ActionFlag.Controls.Add(this.checkBox_Trade);
            this.groupBox_ActionFlag.Controls.Add(this.checkBox_BankCharacter);
            this.groupBox_ActionFlag.Controls.Add(this.checkBox_DropFree);
            this.groupBox_ActionFlag.Controls.Add(this.checkBox_Pet);
            this.groupBox_ActionFlag.Controls.Add(this.checkBox_BankAccount);
            this.groupBox_ActionFlag.Controls.Add(this.checkBox_DropLock);
            this.groupBox_ActionFlag.Controls.Add(this.checkBox_Destroy);
            this.groupBox_ActionFlag.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox_ActionFlag.Location = new System.Drawing.Point(1066, 302);
            this.groupBox_ActionFlag.Name = "groupBox_ActionFlag";
            this.groupBox_ActionFlag.Size = new System.Drawing.Size(375, 152);
            this.groupBox_ActionFlag.TabIndex = 23;
            this.groupBox_ActionFlag.TabStop = false;
            this.groupBox_ActionFlag.Text = "Action Flag: ";
            // 
            // checkBox_Mail
            // 
            this.checkBox_Mail.AutoSize = true;
            this.checkBox_Mail.Enabled = false;
            this.checkBox_Mail.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_Mail.ForeColor = System.Drawing.SystemColors.ControlText;
            this.checkBox_Mail.Location = new System.Drawing.Point(220, 123);
            this.checkBox_Mail.Name = "checkBox_Mail";
            this.checkBox_Mail.Size = new System.Drawing.Size(61, 25);
            this.checkBox_Mail.TabIndex = 25;
            this.checkBox_Mail.Text = "郵寄";
            this.checkBox_Mail.UseVisualStyleBackColor = true;
            // 
            // checkBox_dyeable
            // 
            this.checkBox_dyeable.AutoSize = true;
            this.checkBox_dyeable.Enabled = false;
            this.checkBox_dyeable.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_dyeable.ForeColor = System.Drawing.SystemColors.ControlText;
            this.checkBox_dyeable.Location = new System.Drawing.Point(5, 123);
            this.checkBox_dyeable.Name = "checkBox_dyeable";
            this.checkBox_dyeable.Size = new System.Drawing.Size(61, 25);
            this.checkBox_dyeable.TabIndex = 24;
            this.checkBox_dyeable.Text = "染色";
            this.checkBox_dyeable.UseVisualStyleBackColor = true;
            // 
            // checkBox_TradeLimit
            // 
            this.checkBox_TradeLimit.AutoSize = true;
            this.checkBox_TradeLimit.Enabled = false;
            this.checkBox_TradeLimit.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_TradeLimit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.checkBox_TradeLimit.Location = new System.Drawing.Point(220, 23);
            this.checkBox_TradeLimit.Name = "checkBox_TradeLimit";
            this.checkBox_TradeLimit.Size = new System.Drawing.Size(131, 25);
            this.checkBox_TradeLimit.TabIndex = 23;
            this.checkBox_TradeLimit.Text = "玩家交易(1次)";
            this.checkBox_TradeLimit.UseVisualStyleBackColor = true;
            // 
            // checkBox_Trade
            // 
            this.checkBox_Trade.AutoSize = true;
            this.checkBox_Trade.Enabled = false;
            this.checkBox_Trade.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_Trade.ForeColor = System.Drawing.SystemColors.ControlText;
            this.checkBox_Trade.Location = new System.Drawing.Point(5, 23);
            this.checkBox_Trade.Name = "checkBox_Trade";
            this.checkBox_Trade.Size = new System.Drawing.Size(93, 25);
            this.checkBox_Trade.TabIndex = 14;
            this.checkBox_Trade.Text = "玩家交易";
            this.checkBox_Trade.UseVisualStyleBackColor = true;
            // 
            // checkBox_BankCharacter
            // 
            this.checkBox_BankCharacter.AutoSize = true;
            this.checkBox_BankCharacter.Enabled = false;
            this.checkBox_BankCharacter.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_BankCharacter.ForeColor = System.Drawing.SystemColors.ControlText;
            this.checkBox_BankCharacter.Location = new System.Drawing.Point(220, 73);
            this.checkBox_BankCharacter.Name = "checkBox_BankCharacter";
            this.checkBox_BankCharacter.Size = new System.Drawing.Size(137, 25);
            this.checkBox_BankCharacter.TabIndex = 21;
            this.checkBox_BankCharacter.Text = "銀行(角色綁定)";
            this.checkBox_BankCharacter.UseVisualStyleBackColor = true;
            // 
            // checkBox_DropFree
            // 
            this.checkBox_DropFree.AutoSize = true;
            this.checkBox_DropFree.BackColor = System.Drawing.Color.Transparent;
            this.checkBox_DropFree.Enabled = false;
            this.checkBox_DropFree.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_DropFree.ForeColor = System.Drawing.SystemColors.ControlText;
            this.checkBox_DropFree.Location = new System.Drawing.Point(5, 48);
            this.checkBox_DropFree.Name = "checkBox_DropFree";
            this.checkBox_DropFree.Size = new System.Drawing.Size(153, 25);
            this.checkBox_DropFree.TabIndex = 16;
            this.checkBox_DropFree.Text = "丟棄(可自由撿取)";
            this.checkBox_DropFree.UseVisualStyleBackColor = false;
            // 
            // checkBox_Pet
            // 
            this.checkBox_Pet.AutoSize = true;
            this.checkBox_Pet.Enabled = false;
            this.checkBox_Pet.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_Pet.ForeColor = System.Drawing.SystemColors.ControlText;
            this.checkBox_Pet.Location = new System.Drawing.Point(5, 98);
            this.checkBox_Pet.Name = "checkBox_Pet";
            this.checkBox_Pet.Size = new System.Drawing.Size(93, 25);
            this.checkBox_Pet.TabIndex = 22;
            this.checkBox_Pet.Text = "存放寵物";
            this.checkBox_Pet.UseVisualStyleBackColor = true;
            // 
            // checkBox_BankAccount
            // 
            this.checkBox_BankAccount.AutoSize = true;
            this.checkBox_BankAccount.Enabled = false;
            this.checkBox_BankAccount.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_BankAccount.ForeColor = System.Drawing.SystemColors.ControlText;
            this.checkBox_BankAccount.Location = new System.Drawing.Point(220, 48);
            this.checkBox_BankAccount.Name = "checkBox_BankAccount";
            this.checkBox_BankAccount.Size = new System.Drawing.Size(137, 25);
            this.checkBox_BankAccount.TabIndex = 20;
            this.checkBox_BankAccount.Text = "銀行(帳號共享)";
            this.checkBox_BankAccount.UseVisualStyleBackColor = true;
            // 
            // checkBox_DropLock
            // 
            this.checkBox_DropLock.AutoSize = true;
            this.checkBox_DropLock.Enabled = false;
            this.checkBox_DropLock.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_DropLock.ForeColor = System.Drawing.SystemColors.ControlText;
            this.checkBox_DropLock.Location = new System.Drawing.Point(5, 73);
            this.checkBox_DropLock.Name = "checkBox_DropLock";
            this.checkBox_DropLock.Size = new System.Drawing.Size(153, 25);
            this.checkBox_DropLock.TabIndex = 19;
            this.checkBox_DropLock.Text = "丟棄(保留所有權)";
            this.checkBox_DropLock.UseVisualStyleBackColor = true;
            // 
            // checkBox_Destroy
            // 
            this.checkBox_Destroy.AutoSize = true;
            this.checkBox_Destroy.Enabled = false;
            this.checkBox_Destroy.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_Destroy.ForeColor = System.Drawing.SystemColors.ControlText;
            this.checkBox_Destroy.Location = new System.Drawing.Point(220, 98);
            this.checkBox_Destroy.Name = "checkBox_Destroy";
            this.checkBox_Destroy.Size = new System.Drawing.Size(61, 25);
            this.checkBox_Destroy.TabIndex = 15;
            this.checkBox_Destroy.Text = "銷毀";
            this.checkBox_Destroy.UseVisualStyleBackColor = true;
            // 
            // textBox_ItemDesc
            // 
            this.textBox_ItemDesc.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox_ItemDesc.Location = new System.Drawing.Point(1066, 160);
            this.textBox_ItemDesc.Multiline = true;
            this.textBox_ItemDesc.Name = "textBox_ItemDesc";
            this.textBox_ItemDesc.ReadOnly = true;
            this.textBox_ItemDesc.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox_ItemDesc.Size = new System.Drawing.Size(375, 65);
            this.textBox_ItemDesc.TabIndex = 12;
            // 
            // label_ItemName
            // 
            this.label_ItemName.AutoSize = true;
            this.label_ItemName.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_ItemName.Location = new System.Drawing.Point(1062, 130);
            this.label_ItemName.Name = "label_ItemName";
            this.label_ItemName.Size = new System.Drawing.Size(78, 21);
            this.label_ItemName.TabIndex = 6;
            this.label_ItemName.Text = "道具名稱:";
            // 
            // textBox_ItemCategory
            // 
            this.textBox_ItemCategory.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox_ItemCategory.Location = new System.Drawing.Point(1066, 675);
            this.textBox_ItemCategory.Multiline = true;
            this.textBox_ItemCategory.Name = "textBox_ItemCategory";
            this.textBox_ItemCategory.ReadOnly = true;
            this.textBox_ItemCategory.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox_ItemCategory.Size = new System.Drawing.Size(375, 65);
            this.textBox_ItemCategory.TabIndex = 5;
            // 
            // label_ItemID
            // 
            this.label_ItemID.AutoSize = true;
            this.label_ItemID.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_ItemID.Location = new System.Drawing.Point(1062, 95);
            this.label_ItemID.Name = "label_ItemID";
            this.label_ItemID.Size = new System.Drawing.Size(78, 21);
            this.label_ItemID.TabIndex = 4;
            this.label_ItemID.Text = "道具編號:";
            // 
            // textBox_ItemXML
            // 
            this.textBox_ItemXML.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox_ItemXML.Location = new System.Drawing.Point(1066, 785);
            this.textBox_ItemXML.Multiline = true;
            this.textBox_ItemXML.Name = "textBox_ItemXML";
            this.textBox_ItemXML.ReadOnly = true;
            this.textBox_ItemXML.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox_ItemXML.Size = new System.Drawing.Size(375, 104);
            this.textBox_ItemXML.TabIndex = 2;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.groupBox_OptionSetDesc);
            this.tabPage2.Controls.Add(this.groupBox_OptionSetSelect);
            this.tabPage2.Controls.Add(this.dataGridView_OptionSet);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1446, 914);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "OptionSet";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label_OptionSetRate);
            this.groupBox1.Controls.Add(this.checkBox_OptionSetHelperBonus);
            this.groupBox1.Controls.Add(this.checkBox_OptionSetDayBonus);
            this.groupBox1.Controls.Add(this.label_OptionSetPowder);
            this.groupBox1.Controls.Add(this.comboBox_OptionSetPowder);
            this.groupBox1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox1.Location = new System.Drawing.Point(1066, 758);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(375, 132);
            this.groupBox1.TabIndex = 35;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "賦予成功率計算";
            // 
            // label_OptionSetRate
            // 
            this.label_OptionSetRate.AutoSize = true;
            this.label_OptionSetRate.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_OptionSetRate.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label_OptionSetRate.Location = new System.Drawing.Point(7, 94);
            this.label_OptionSetRate.Name = "label_OptionSetRate";
            this.label_OptionSetRate.Size = new System.Drawing.Size(0, 19);
            this.label_OptionSetRate.TabIndex = 46;
            this.ToolTip.SetToolTip(this.label_OptionSetRate, "((智力 - 25) / 350 + 1 + 魔法粉加成 + 星期四秋收加成) * 賦予卷軸基本成功率 + 透過賦予小幫手 = 最終成功率\r\n");
            // 
            // checkBox_OptionSetHelperBonus
            // 
            this.checkBox_OptionSetHelperBonus.AutoSize = true;
            this.checkBox_OptionSetHelperBonus.Enabled = false;
            this.checkBox_OptionSetHelperBonus.Location = new System.Drawing.Point(194, 60);
            this.checkBox_OptionSetHelperBonus.Name = "checkBox_OptionSetHelperBonus";
            this.checkBox_OptionSetHelperBonus.Size = new System.Drawing.Size(141, 25);
            this.checkBox_OptionSetHelperBonus.TabIndex = 45;
            this.checkBox_OptionSetHelperBonus.Text = "賦予小幫手加成";
            this.checkBox_OptionSetHelperBonus.UseVisualStyleBackColor = true;
            this.checkBox_OptionSetHelperBonus.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // checkBox_OptionSetDayBonus
            // 
            this.checkBox_OptionSetDayBonus.AutoSize = true;
            this.checkBox_OptionSetDayBonus.Enabled = false;
            this.checkBox_OptionSetDayBonus.Location = new System.Drawing.Point(11, 60);
            this.checkBox_OptionSetDayBonus.Name = "checkBox_OptionSetDayBonus";
            this.checkBox_OptionSetDayBonus.Size = new System.Drawing.Size(141, 25);
            this.checkBox_OptionSetDayBonus.TabIndex = 44;
            this.checkBox_OptionSetDayBonus.Text = "星期四秋收加成";
            this.checkBox_OptionSetDayBonus.UseVisualStyleBackColor = true;
            this.checkBox_OptionSetDayBonus.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // label_OptionSetPowder
            // 
            this.label_OptionSetPowder.AutoSize = true;
            this.label_OptionSetPowder.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_OptionSetPowder.Location = new System.Drawing.Point(6, 30);
            this.label_OptionSetPowder.Name = "label_OptionSetPowder";
            this.label_OptionSetPowder.Size = new System.Drawing.Size(138, 21);
            this.label_OptionSetPowder.TabIndex = 43;
            this.label_OptionSetPowder.Text = "請選擇魔法粉種類";
            // 
            // comboBox_OptionSetPowder
            // 
            this.comboBox_OptionSetPowder.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_OptionSetPowder.Enabled = false;
            this.comboBox_OptionSetPowder.FormattingEnabled = true;
            this.comboBox_OptionSetPowder.Items.AddRange(new object[] {
            "魔法粉 | 0",
            "聖魔法粉 | 0",
            "精製魔法粉 | 5",
            "精靈魔法粉 | 10",
            "古代魔法粉 | 50",
            "神聖魔法粉 | 60",
            "稀有魔法粉 | 60"});
            this.comboBox_OptionSetPowder.Location = new System.Drawing.Point(194, 26);
            this.comboBox_OptionSetPowder.Name = "comboBox_OptionSetPowder";
            this.comboBox_OptionSetPowder.Size = new System.Drawing.Size(170, 29);
            this.comboBox_OptionSetPowder.TabIndex = 0;
            this.comboBox_OptionSetPowder.SelectedIndexChanged += new System.EventHandler(this.comboBox_OptionSetPowder_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(1062, 892);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 20);
            this.label2.TabIndex = 43;
            // 
            // groupBox_OptionSetDesc
            // 
            this.groupBox_OptionSetDesc.Controls.Add(this.textBox_OptionSetBlock);
            this.groupBox_OptionSetDesc.Controls.Add(this.label_OptionSetBlock);
            this.groupBox_OptionSetDesc.Controls.Add(this.textBox_OptionSetAllow);
            this.groupBox_OptionSetDesc.Controls.Add(this.label_OptionSetAllow);
            this.groupBox_OptionSetDesc.Controls.Add(this.label_OptionSetDesc);
            this.groupBox_OptionSetDesc.Controls.Add(this.label_OptionSetID);
            this.groupBox_OptionSetDesc.Controls.Add(this.textBox_OptionSetDesc);
            this.groupBox_OptionSetDesc.Controls.Add(this.label_OptionSetFee);
            this.groupBox_OptionSetDesc.Controls.Add(this.label_OptionSetName);
            this.groupBox_OptionSetDesc.Controls.Add(this.label_OptionSetUsage);
            this.groupBox_OptionSetDesc.Controls.Add(this.label_OptionSetLevel);
            this.groupBox_OptionSetDesc.Controls.Add(this.label_OptionSetIgnore);
            this.groupBox_OptionSetDesc.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox_OptionSetDesc.Location = new System.Drawing.Point(1066, 93);
            this.groupBox_OptionSetDesc.Name = "groupBox_OptionSetDesc";
            this.groupBox_OptionSetDesc.Size = new System.Drawing.Size(375, 659);
            this.groupBox_OptionSetDesc.TabIndex = 38;
            this.groupBox_OptionSetDesc.TabStop = false;
            this.groupBox_OptionSetDesc.Text = "基本賦予資料";
            // 
            // textBox_OptionSetBlock
            // 
            this.textBox_OptionSetBlock.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox_OptionSetBlock.Location = new System.Drawing.Point(9, 545);
            this.textBox_OptionSetBlock.Multiline = true;
            this.textBox_OptionSetBlock.Name = "textBox_OptionSetBlock";
            this.textBox_OptionSetBlock.ReadOnly = true;
            this.textBox_OptionSetBlock.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox_OptionSetBlock.Size = new System.Drawing.Size(355, 106);
            this.textBox_OptionSetBlock.TabIndex = 42;
            // 
            // label_OptionSetBlock
            // 
            this.label_OptionSetBlock.AutoSize = true;
            this.label_OptionSetBlock.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_OptionSetBlock.Location = new System.Drawing.Point(6, 510);
            this.label_OptionSetBlock.Name = "label_OptionSetBlock";
            this.label_OptionSetBlock.Size = new System.Drawing.Size(142, 21);
            this.label_OptionSetBlock.TabIndex = 41;
            this.label_OptionSetBlock.Text = "不可賦予裝備類別:";
            // 
            // textBox_OptionSetAllow
            // 
            this.textBox_OptionSetAllow.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox_OptionSetAllow.Location = new System.Drawing.Point(9, 430);
            this.textBox_OptionSetAllow.Multiline = true;
            this.textBox_OptionSetAllow.Name = "textBox_OptionSetAllow";
            this.textBox_OptionSetAllow.ReadOnly = true;
            this.textBox_OptionSetAllow.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox_OptionSetAllow.Size = new System.Drawing.Size(355, 66);
            this.textBox_OptionSetAllow.TabIndex = 40;
            // 
            // label_OptionSetAllow
            // 
            this.label_OptionSetAllow.AutoSize = true;
            this.label_OptionSetAllow.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_OptionSetAllow.Location = new System.Drawing.Point(6, 395);
            this.label_OptionSetAllow.Name = "label_OptionSetAllow";
            this.label_OptionSetAllow.Size = new System.Drawing.Size(126, 21);
            this.label_OptionSetAllow.TabIndex = 39;
            this.label_OptionSetAllow.Text = "可賦予裝備類別:";
            // 
            // label_OptionSetDesc
            // 
            this.label_OptionSetDesc.AutoSize = true;
            this.label_OptionSetDesc.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_OptionSetDesc.Location = new System.Drawing.Point(6, 240);
            this.label_OptionSetDesc.Name = "label_OptionSetDesc";
            this.label_OptionSetDesc.Size = new System.Drawing.Size(78, 21);
            this.label_OptionSetDesc.TabIndex = 38;
            this.label_OptionSetDesc.Text = "賦予內容:";
            // 
            // label_OptionSetID
            // 
            this.label_OptionSetID.AutoSize = true;
            this.label_OptionSetID.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_OptionSetID.Location = new System.Drawing.Point(6, 30);
            this.label_OptionSetID.Name = "label_OptionSetID";
            this.label_OptionSetID.Size = new System.Drawing.Size(78, 21);
            this.label_OptionSetID.TabIndex = 31;
            this.label_OptionSetID.Text = "賦予編號:";
            // 
            // textBox_OptionSetDesc
            // 
            this.textBox_OptionSetDesc.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox_OptionSetDesc.Location = new System.Drawing.Point(9, 275);
            this.textBox_OptionSetDesc.Multiline = true;
            this.textBox_OptionSetDesc.Name = "textBox_OptionSetDesc";
            this.textBox_OptionSetDesc.ReadOnly = true;
            this.textBox_OptionSetDesc.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox_OptionSetDesc.Size = new System.Drawing.Size(355, 106);
            this.textBox_OptionSetDesc.TabIndex = 33;
            // 
            // label_OptionSetFee
            // 
            this.label_OptionSetFee.AutoSize = true;
            this.label_OptionSetFee.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_OptionSetFee.Location = new System.Drawing.Point(6, 205);
            this.label_OptionSetFee.Name = "label_OptionSetFee";
            this.label_OptionSetFee.Size = new System.Drawing.Size(78, 21);
            this.label_OptionSetFee.TabIndex = 37;
            this.label_OptionSetFee.Text = "修理倍率:";
            // 
            // label_OptionSetName
            // 
            this.label_OptionSetName.AutoSize = true;
            this.label_OptionSetName.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_OptionSetName.Location = new System.Drawing.Point(6, 65);
            this.label_OptionSetName.Name = "label_OptionSetName";
            this.label_OptionSetName.Size = new System.Drawing.Size(78, 21);
            this.label_OptionSetName.TabIndex = 32;
            this.label_OptionSetName.Text = "賦予名稱:";
            // 
            // label_OptionSetUsage
            // 
            this.label_OptionSetUsage.AutoSize = true;
            this.label_OptionSetUsage.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_OptionSetUsage.Location = new System.Drawing.Point(6, 135);
            this.label_OptionSetUsage.Name = "label_OptionSetUsage";
            this.label_OptionSetUsage.Size = new System.Drawing.Size(78, 21);
            this.label_OptionSetUsage.TabIndex = 36;
            this.label_OptionSetUsage.Text = "賦予詞綴:";
            // 
            // label_OptionSetLevel
            // 
            this.label_OptionSetLevel.AutoSize = true;
            this.label_OptionSetLevel.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_OptionSetLevel.Location = new System.Drawing.Point(6, 100);
            this.label_OptionSetLevel.Name = "label_OptionSetLevel";
            this.label_OptionSetLevel.Size = new System.Drawing.Size(78, 21);
            this.label_OptionSetLevel.TabIndex = 34;
            this.label_OptionSetLevel.Text = "賦予等級:";
            // 
            // label_OptionSetIgnore
            // 
            this.label_OptionSetIgnore.AutoSize = true;
            this.label_OptionSetIgnore.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_OptionSetIgnore.Location = new System.Drawing.Point(6, 170);
            this.label_OptionSetIgnore.Name = "label_OptionSetIgnore";
            this.label_OptionSetIgnore.Size = new System.Drawing.Size(78, 21);
            this.label_OptionSetIgnore.TabIndex = 35;
            this.label_OptionSetIgnore.Text = "無視墊捲:";
            // 
            // groupBox_OptionSetSelect
            // 
            this.groupBox_OptionSetSelect.Controls.Add(this.radioButton_OptionSetName);
            this.groupBox_OptionSetSelect.Controls.Add(this.button_OptionSetReset);
            this.groupBox_OptionSetSelect.Controls.Add(this.button_OptionSetSearch);
            this.groupBox_OptionSetSelect.Controls.Add(this.radioButton_OptionSetDesc);
            this.groupBox_OptionSetSelect.Controls.Add(this.radioButton_OptionSetID);
            this.groupBox_OptionSetSelect.Controls.Add(this.label_OptionSetKeyword);
            this.groupBox_OptionSetSelect.Controls.Add(this.textBox_OptionSetKeyword);
            this.groupBox_OptionSetSelect.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox_OptionSetSelect.Location = new System.Drawing.Point(1066, 2);
            this.groupBox_OptionSetSelect.Name = "groupBox_OptionSetSelect";
            this.groupBox_OptionSetSelect.Size = new System.Drawing.Size(375, 85);
            this.groupBox_OptionSetSelect.TabIndex = 30;
            this.groupBox_OptionSetSelect.TabStop = false;
            this.groupBox_OptionSetSelect.Text = "搜尋賦予";
            // 
            // radioButton_OptionSetName
            // 
            this.radioButton_OptionSetName.AutoSize = true;
            this.radioButton_OptionSetName.Location = new System.Drawing.Point(139, 54);
            this.radioButton_OptionSetName.Name = "radioButton_OptionSetName";
            this.radioButton_OptionSetName.Size = new System.Drawing.Size(92, 25);
            this.radioButton_OptionSetName.TabIndex = 34;
            this.radioButton_OptionSetName.Text = "賦予名稱";
            this.radioButton_OptionSetName.UseVisualStyleBackColor = true;
            // 
            // button_OptionSetReset
            // 
            this.button_OptionSetReset.Enabled = false;
            this.button_OptionSetReset.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button_OptionSetReset.Location = new System.Drawing.Point(282, 24);
            this.button_OptionSetReset.Name = "button_OptionSetReset";
            this.button_OptionSetReset.Size = new System.Drawing.Size(82, 31);
            this.button_OptionSetReset.TabIndex = 33;
            this.button_OptionSetReset.Text = "重置結果";
            this.button_OptionSetReset.UseVisualStyleBackColor = true;
            this.button_OptionSetReset.Click += new System.EventHandler(this.button_OptionSetReset_Click);
            // 
            // button_OptionSetSearch
            // 
            this.button_OptionSetSearch.Enabled = false;
            this.button_OptionSetSearch.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button_OptionSetSearch.Location = new System.Drawing.Point(194, 24);
            this.button_OptionSetSearch.Name = "button_OptionSetSearch";
            this.button_OptionSetSearch.Size = new System.Drawing.Size(82, 31);
            this.button_OptionSetSearch.TabIndex = 30;
            this.button_OptionSetSearch.Text = "開始搜尋";
            this.button_OptionSetSearch.UseVisualStyleBackColor = true;
            this.button_OptionSetSearch.Click += new System.EventHandler(this.button_OptionSetSearch_Click);
            // 
            // radioButton_OptionSetDesc
            // 
            this.radioButton_OptionSetDesc.AutoSize = true;
            this.radioButton_OptionSetDesc.Location = new System.Drawing.Point(279, 54);
            this.radioButton_OptionSetDesc.Name = "radioButton_OptionSetDesc";
            this.radioButton_OptionSetDesc.Size = new System.Drawing.Size(92, 25);
            this.radioButton_OptionSetDesc.TabIndex = 32;
            this.radioButton_OptionSetDesc.Text = "賦予內容";
            this.radioButton_OptionSetDesc.UseVisualStyleBackColor = true;
            // 
            // radioButton_OptionSetID
            // 
            this.radioButton_OptionSetID.AutoSize = true;
            this.radioButton_OptionSetID.Checked = true;
            this.radioButton_OptionSetID.Location = new System.Drawing.Point(10, 54);
            this.radioButton_OptionSetID.Name = "radioButton_OptionSetID";
            this.radioButton_OptionSetID.Size = new System.Drawing.Size(77, 25);
            this.radioButton_OptionSetID.TabIndex = 31;
            this.radioButton_OptionSetID.TabStop = true;
            this.radioButton_OptionSetID.Text = "賦予ID";
            this.radioButton_OptionSetID.UseVisualStyleBackColor = true;
            // 
            // label_OptionSetKeyword
            // 
            this.label_OptionSetKeyword.AutoSize = true;
            this.label_OptionSetKeyword.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_OptionSetKeyword.Location = new System.Drawing.Point(6, 30);
            this.label_OptionSetKeyword.Name = "label_OptionSetKeyword";
            this.label_OptionSetKeyword.Size = new System.Drawing.Size(58, 21);
            this.label_OptionSetKeyword.TabIndex = 30;
            this.label_OptionSetKeyword.Text = "關鍵字";
            // 
            // textBox_OptionSetKeyword
            // 
            this.textBox_OptionSetKeyword.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox_OptionSetKeyword.Location = new System.Drawing.Point(64, 25);
            this.textBox_OptionSetKeyword.Name = "textBox_OptionSetKeyword";
            this.textBox_OptionSetKeyword.Size = new System.Drawing.Size(122, 29);
            this.textBox_OptionSetKeyword.TabIndex = 30;
            this.ToolTip.SetToolTip(this.textBox_OptionSetKeyword, "輸入賦予編號、名稱、內容");
            // 
            // dataGridView_OptionSet
            // 
            this.dataGridView_OptionSet.AllowUserToAddRows = false;
            this.dataGridView_OptionSet.AllowUserToDeleteRows = false;
            this.dataGridView_OptionSet.AllowUserToResizeRows = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_OptionSet.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView_OptionSet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_OptionSet.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView_OptionSet.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_OptionSet.Name = "dataGridView_OptionSet";
            this.dataGridView_OptionSet.ReadOnly = true;
            this.dataGridView_OptionSet.RowTemplate.Height = 24;
            this.dataGridView_OptionSet.Size = new System.Drawing.Size(1060, 914);
            this.dataGridView_OptionSet.TabIndex = 1;
            this.dataGridView_OptionSet.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_OptionSet_CellClick);
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "NewDataSet";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1457, 945);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "MabiDataViewer";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ItemDB)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox_ItemSelect.ResumeLayout(false);
            this.groupBox_ItemSelect.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox_ActionFlag.ResumeLayout(false);
            this.groupBox_ActionFlag.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox_OptionSetDesc.ResumeLayout(false);
            this.groupBox_OptionSetDesc.PerformLayout();
            this.groupBox_OptionSetSelect.ResumeLayout(false);
            this.groupBox_OptionSetSelect.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_OptionSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_ItemDB;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox textBox_ItemXML;
        private System.Windows.Forms.Label label_ItemID;
        private System.Windows.Forms.TextBox textBox_ItemCategory;
        private System.Windows.Forms.Label label_ItemName;
        private System.Windows.Forms.ToolTip ToolTip;
        private System.Windows.Forms.TextBox textBox_ItemDesc;
        public System.Windows.Forms.CheckBox checkBox_Trade;
        public System.Windows.Forms.CheckBox checkBox_BankCharacter;
        public System.Windows.Forms.CheckBox checkBox_Pet;
        public System.Windows.Forms.CheckBox checkBox_DropLock;
        public System.Windows.Forms.CheckBox checkBox_Destroy;
        public System.Windows.Forms.CheckBox checkBox_BankAccount;
        public System.Windows.Forms.CheckBox checkBox_DropFree;
        public System.Windows.Forms.GroupBox groupBox_ActionFlag;
        public System.Windows.Forms.CheckBox checkBox_TradeLimit;
        public System.Windows.Forms.CheckBox checkBox_Mail;
        public System.Windows.Forms.CheckBox checkBox_dyeable;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_Category;
        private System.Windows.Forms.Label label_XML;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label_Bundle;
        private System.Windows.Forms.GroupBox groupBox_ItemSelect;
        private System.Windows.Forms.Label label_ItemKeyword;
        private System.Windows.Forms.TextBox textBox_ItemKeyword;
        public System.Windows.Forms.RadioButton radioButton_SearchName;
        public System.Windows.Forms.RadioButton radioButton_SerachID;
        private System.Windows.Forms.Button button_ItemReset;
        private System.Windows.Forms.Button button_ItemSearch;
        private System.Data.DataSet dataSet1;
        private System.Windows.Forms.DataGridView dataGridView_OptionSet;
        private System.Windows.Forms.GroupBox groupBox_OptionSetSelect;
        private System.Windows.Forms.Button button_OptionSetReset;
        private System.Windows.Forms.Button button_OptionSetSearch;
        public System.Windows.Forms.RadioButton radioButton_OptionSetDesc;
        public System.Windows.Forms.RadioButton radioButton_OptionSetID;
        private System.Windows.Forms.Label label_OptionSetKeyword;
        private System.Windows.Forms.TextBox textBox_OptionSetKeyword;
        public System.Windows.Forms.RadioButton radioButton_OptionSetName;
        private System.Windows.Forms.TextBox textBox_OptionSetDesc;
        private System.Windows.Forms.Label label_OptionSetName;
        private System.Windows.Forms.Label label_OptionSetID;
        private System.Windows.Forms.Label label_OptionSetIgnore;
        private System.Windows.Forms.Label label_OptionSetLevel;
        private System.Windows.Forms.GroupBox groupBox_OptionSetDesc;
        private System.Windows.Forms.Label label_OptionSetFee;
        private System.Windows.Forms.Label label_OptionSetUsage;
        private System.Windows.Forms.Label label_OptionSetDesc;
        private System.Windows.Forms.Label label_ItemSize;
        private System.Windows.Forms.TextBox textBox_OptionSetAllow;
        private System.Windows.Forms.Label label_OptionSetAllow;
        private System.Windows.Forms.TextBox textBox_OptionSetBlock;
        private System.Windows.Forms.Label label_OptionSetBlock;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBox_OptionSetPowder;
        private System.Windows.Forms.Label label_OptionSetPowder;
        private System.Windows.Forms.CheckBox checkBox_OptionSetDayBonus;
        private System.Windows.Forms.Label label_OptionSetRate;
        private System.Windows.Forms.CheckBox checkBox_OptionSetHelperBonus;
    }
}

