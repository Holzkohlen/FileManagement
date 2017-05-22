namespace Dateiverwaltung
{
    partial class EditForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditForm));
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tab_Customers = new System.Windows.Forms.TabPage();
            this.btn_AddCostumer = new System.Windows.Forms.Button();
            this.cb_LendSearch = new System.Windows.Forms.ComboBox();
            this.cb_WichMedia = new System.Windows.Forms.ComboBox();
            this.btn_Borrow = new System.Windows.Forms.Button();
            this.btn_return = new System.Windows.Forms.Button();
            this.dgv_Borrowed = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Titel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Medium = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tb_Ort = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_PLZ = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_Strasse = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_Vorname = new System.Windows.Forms.TextBox();
            this.tb_Name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_EditCostumer = new System.Windows.Forms.Button();
            this.cb_Search = new System.Windows.Forms.ComboBox();
            this.tab_Books = new System.Windows.Forms.TabPage();
            this.Daten = new System.Windows.Forms.GroupBox();
            this.num_Book_Pages = new System.Windows.Forms.NumericUpDown();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_Add_Book = new System.Windows.Forms.Button();
            this.cb_Search_Book = new System.Windows.Forms.ComboBox();
            this.btn_Edit_Book = new System.Windows.Forms.Button();
            this.tb_Book_Autor = new System.Windows.Forms.TextBox();
            this.dtp_Book_Release = new System.Windows.Forms.DateTimePicker();
            this.tb_Book_Genre = new System.Windows.Forms.TextBox();
            this.tb_Book_Titel = new System.Windows.Forms.TextBox();
            this.lb_Titel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tab_Ebooks = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.num_EBook_Pages = new System.Windows.Forms.NumericUpDown();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btn_Add_EBook = new System.Windows.Forms.Button();
            this.btn_Edit_EBook = new System.Windows.Forms.Button();
            this.cb_Search_EBook = new System.Windows.Forms.ComboBox();
            this.tb_EBook_Autor = new System.Windows.Forms.TextBox();
            this.dtp_EBook_Release = new System.Windows.Forms.DateTimePicker();
            this.tb_EBook_Genre = new System.Windows.Forms.TextBox();
            this.tb_EBook_Titel = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.tab_CDs = new System.Windows.Forms.TabPage();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.num_CD_Length = new System.Windows.Forms.NumericUpDown();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.btn_Add_CD = new System.Windows.Forms.Button();
            this.btn_Edit_CD = new System.Windows.Forms.Button();
            this.cb_Search_CD = new System.Windows.Forms.ComboBox();
            this.tb_CD_Interpret = new System.Windows.Forms.TextBox();
            this.dtp_CD_Release = new System.Windows.Forms.DateTimePicker();
            this.tb_CD_Genre = new System.Windows.Forms.TextBox();
            this.tb_CD_Titel = new System.Windows.Forms.TextBox();
            this.label48 = new System.Windows.Forms.Label();
            this.label50 = new System.Windows.Forms.Label();
            this.label51 = new System.Windows.Forms.Label();
            this.label52 = new System.Windows.Forms.Label();
            this.label54 = new System.Windows.Forms.Label();
            this.tab_DVDs = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cb_DVD_FSK = new System.Windows.Forms.ComboBox();
            this.num_DVD_Length = new System.Windows.Forms.NumericUpDown();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btn_Add_DVD = new System.Windows.Forms.Button();
            this.btn_Edit_DVD = new System.Windows.Forms.Button();
            this.cb_Search_DVD = new System.Windows.Forms.ComboBox();
            this.label29 = new System.Windows.Forms.Label();
            this.tb_DVD_Director = new System.Windows.Forms.TextBox();
            this.dtp_DVD_Release = new System.Windows.Forms.DateTimePicker();
            this.tb_DVD_Genre = new System.Windows.Forms.TextBox();
            this.tb_DVD_Titel = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.tab_BluRays = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cb_BluRay_FSK = new System.Windows.Forms.ComboBox();
            this.num_BluRay_Length = new System.Windows.Forms.NumericUpDown();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.btn_Add_BluRay = new System.Windows.Forms.Button();
            this.btn_Edit_BluRay = new System.Windows.Forms.Button();
            this.cb_Search_BluRay = new System.Windows.Forms.ComboBox();
            this.label30 = new System.Windows.Forms.Label();
            this.tb_BluRay_Director = new System.Windows.Forms.TextBox();
            this.dtp_BluRay_Release = new System.Windows.Forms.DateTimePicker();
            this.tb_BluRay_Genre = new System.Windows.Forms.TextBox();
            this.tb_BluRay_Titel = new System.Windows.Forms.TextBox();
            this.label31 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.tabControl.SuspendLayout();
            this.tab_Customers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Borrowed)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tab_Books.SuspendLayout();
            this.Daten.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_Book_Pages)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tab_Ebooks.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_EBook_Pages)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.tab_CDs.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_CD_Length)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.tab_DVDs.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_DVD_Length)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.tab_BluRays.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_BluRay_Length)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tab_Customers);
            this.tabControl.Controls.Add(this.tab_Books);
            this.tabControl.Controls.Add(this.tab_Ebooks);
            this.tabControl.Controls.Add(this.tab_CDs);
            this.tabControl.Controls.Add(this.tab_DVDs);
            this.tabControl.Controls.Add(this.tab_BluRays);
            this.tabControl.Location = new System.Drawing.Point(1, 1);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(879, 248);
            this.tabControl.TabIndex = 2;
            this.tabControl.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabControl_Selected);
            // 
            // tab_Customers
            // 
            this.tab_Customers.Controls.Add(this.btn_AddCostumer);
            this.tab_Customers.Controls.Add(this.cb_LendSearch);
            this.tab_Customers.Controls.Add(this.cb_WichMedia);
            this.tab_Customers.Controls.Add(this.btn_Borrow);
            this.tab_Customers.Controls.Add(this.btn_return);
            this.tab_Customers.Controls.Add(this.dgv_Borrowed);
            this.tab_Customers.Controls.Add(this.groupBox1);
            this.tab_Customers.Controls.Add(this.btn_EditCostumer);
            this.tab_Customers.Controls.Add(this.cb_Search);
            this.tab_Customers.Location = new System.Drawing.Point(4, 22);
            this.tab_Customers.Name = "tab_Customers";
            this.tab_Customers.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Customers.Size = new System.Drawing.Size(871, 222);
            this.tab_Customers.TabIndex = 0;
            this.tab_Customers.Text = "Kunden";
            this.tab_Customers.UseVisualStyleBackColor = true;
            // 
            // btn_AddCostumer
            // 
            this.btn_AddCostumer.Location = new System.Drawing.Point(196, 193);
            this.btn_AddCostumer.Name = "btn_AddCostumer";
            this.btn_AddCostumer.Size = new System.Drawing.Size(176, 23);
            this.btn_AddCostumer.TabIndex = 8;
            this.btn_AddCostumer.Text = "Hinzufügen";
            this.btn_AddCostumer.UseVisualStyleBackColor = true;
            this.btn_AddCostumer.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // cb_LendSearch
            // 
            this.cb_LendSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cb_LendSearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cb_LendSearch.ForeColor = System.Drawing.Color.DimGray;
            this.cb_LendSearch.FormattingEnabled = true;
            this.cb_LendSearch.Location = new System.Drawing.Point(519, 166);
            this.cb_LendSearch.Name = "cb_LendSearch";
            this.cb_LendSearch.Size = new System.Drawing.Size(339, 21);
            this.cb_LendSearch.TabIndex = 7;
            this.cb_LendSearch.Text = "Suchen...";
            // 
            // cb_WichMedia
            // 
            this.cb_WichMedia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_WichMedia.FormattingEnabled = true;
            this.cb_WichMedia.Items.AddRange(new object[] {
            "Buch",
            "EBook",
            "CD",
            "DVD",
            "BluRay"});
            this.cb_WichMedia.Location = new System.Drawing.Point(391, 166);
            this.cb_WichMedia.Name = "cb_WichMedia";
            this.cb_WichMedia.Size = new System.Drawing.Size(121, 21);
            this.cb_WichMedia.TabIndex = 6;
            this.cb_WichMedia.SelectedIndexChanged += new System.EventHandler(this.cb_WichMedia_SelectedIndexChanged);
            // 
            // btn_Borrow
            // 
            this.btn_Borrow.Location = new System.Drawing.Point(391, 193);
            this.btn_Borrow.Name = "btn_Borrow";
            this.btn_Borrow.Size = new System.Drawing.Size(467, 23);
            this.btn_Borrow.TabIndex = 5;
            this.btn_Borrow.Text = "Ausleihen";
            this.btn_Borrow.UseVisualStyleBackColor = true;
            this.btn_Borrow.Click += new System.EventHandler(this.btn_Borrow_Click);
            // 
            // btn_return
            // 
            this.btn_return.Location = new System.Drawing.Point(391, 6);
            this.btn_return.Name = "btn_return";
            this.btn_return.Size = new System.Drawing.Size(467, 23);
            this.btn_return.TabIndex = 4;
            this.btn_return.Text = "Zurückgeben";
            this.btn_return.UseVisualStyleBackColor = true;
            this.btn_return.Click += new System.EventHandler(this.btn_return_Click);
            // 
            // dgv_Borrowed
            // 
            this.dgv_Borrowed.AllowUserToAddRows = false;
            this.dgv_Borrowed.AllowUserToDeleteRows = false;
            this.dgv_Borrowed.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Borrowed.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Titel,
            this.Medium,
            this.Column4});
            this.dgv_Borrowed.Location = new System.Drawing.Point(391, 35);
            this.dgv_Borrowed.Name = "dgv_Borrowed";
            this.dgv_Borrowed.Size = new System.Drawing.Size(467, 124);
            this.dgv_Borrowed.TabIndex = 3;
            // 
            // ID
            // 
            this.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.Width = 43;
            // 
            // Titel
            // 
            this.Titel.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Titel.HeaderText = "Titel";
            this.Titel.Name = "Titel";
            // 
            // Medium
            // 
            this.Medium.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Medium.HeaderText = "Medium";
            this.Medium.Name = "Medium";
            this.Medium.Width = 69;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column4.HeaderText = "Ausgeliehen";
            this.Column4.Name = "Column4";
            this.Column4.Width = 90;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tb_Ort);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.tb_PLZ);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tb_Strasse);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tb_Vorname);
            this.groupBox1.Controls.Add(this.tb_Name);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(3, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(369, 154);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " KundenDaten";
            // 
            // tb_Ort
            // 
            this.tb_Ort.Location = new System.Drawing.Point(182, 107);
            this.tb_Ort.Name = "tb_Ort";
            this.tb_Ort.ReadOnly = true;
            this.tb_Ort.Size = new System.Drawing.Size(169, 20);
            this.tb_Ort.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(152, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Ort:";
            // 
            // tb_PLZ
            // 
            this.tb_PLZ.Location = new System.Drawing.Point(64, 106);
            this.tb_PLZ.Name = "tb_PLZ";
            this.tb_PLZ.ReadOnly = true;
            this.tb_PLZ.Size = new System.Drawing.Size(82, 20);
            this.tb_PLZ.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "PLZ.:";
            // 
            // tb_Strasse
            // 
            this.tb_Strasse.Location = new System.Drawing.Point(64, 81);
            this.tb_Strasse.Name = "tb_Strasse";
            this.tb_Strasse.ReadOnly = true;
            this.tb_Strasse.Size = new System.Drawing.Size(287, 20);
            this.tb_Strasse.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Straße:";
            // 
            // tb_Vorname
            // 
            this.tb_Vorname.Location = new System.Drawing.Point(64, 55);
            this.tb_Vorname.Name = "tb_Vorname";
            this.tb_Vorname.ReadOnly = true;
            this.tb_Vorname.Size = new System.Drawing.Size(287, 20);
            this.tb_Vorname.TabIndex = 3;
            // 
            // tb_Name
            // 
            this.tb_Name.Location = new System.Drawing.Point(64, 27);
            this.tb_Name.Name = "tb_Name";
            this.tb_Name.ReadOnly = true;
            this.tb_Name.Size = new System.Drawing.Size(287, 20);
            this.tb_Name.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Vorname:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // btn_EditCostumer
            // 
            this.btn_EditCostumer.Location = new System.Drawing.Point(3, 193);
            this.btn_EditCostumer.Name = "btn_EditCostumer";
            this.btn_EditCostumer.Size = new System.Drawing.Size(176, 23);
            this.btn_EditCostumer.TabIndex = 1;
            this.btn_EditCostumer.Text = "Bearbeiten";
            this.btn_EditCostumer.UseVisualStyleBackColor = true;
            this.btn_EditCostumer.Click += new System.EventHandler(this.btn_Edit_Click);
            // 
            // cb_Search
            // 
            this.cb_Search.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cb_Search.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cb_Search.FormattingEnabled = true;
            this.cb_Search.Location = new System.Drawing.Point(3, 6);
            this.cb_Search.Name = "cb_Search";
            this.cb_Search.Size = new System.Drawing.Size(369, 21);
            this.cb_Search.TabIndex = 0;
            this.cb_Search.SelectedValueChanged += new System.EventHandler(this.cb_Search_SelectedValueChanged);
            // 
            // tab_Books
            // 
            this.tab_Books.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tab_Books.Controls.Add(this.Daten);
            this.tab_Books.Location = new System.Drawing.Point(4, 22);
            this.tab_Books.Name = "tab_Books";
            this.tab_Books.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Books.Size = new System.Drawing.Size(871, 222);
            this.tab_Books.TabIndex = 1;
            this.tab_Books.Text = "Bücher";
            this.tab_Books.UseVisualStyleBackColor = true;
            // 
            // Daten
            // 
            this.Daten.Controls.Add(this.num_Book_Pages);
            this.Daten.Controls.Add(this.pictureBox1);
            this.Daten.Controls.Add(this.btn_Add_Book);
            this.Daten.Controls.Add(this.cb_Search_Book);
            this.Daten.Controls.Add(this.btn_Edit_Book);
            this.Daten.Controls.Add(this.tb_Book_Autor);
            this.Daten.Controls.Add(this.dtp_Book_Release);
            this.Daten.Controls.Add(this.tb_Book_Genre);
            this.Daten.Controls.Add(this.tb_Book_Titel);
            this.Daten.Controls.Add(this.lb_Titel);
            this.Daten.Controls.Add(this.label8);
            this.Daten.Controls.Add(this.label11);
            this.Daten.Controls.Add(this.label9);
            this.Daten.Controls.Add(this.label6);
            this.Daten.Location = new System.Drawing.Point(0, 0);
            this.Daten.Name = "Daten";
            this.Daten.Size = new System.Drawing.Size(868, 168);
            this.Daten.TabIndex = 5;
            this.Daten.TabStop = false;
            this.Daten.Text = " Daten";
            // 
            // num_Book_Pages
            // 
            this.num_Book_Pages.Location = new System.Drawing.Point(632, 53);
            this.num_Book_Pages.Maximum = new decimal(new int[] {
            80000,
            0,
            0,
            0});
            this.num_Book_Pages.Name = "num_Book_Pages";
            this.num_Book_Pages.Size = new System.Drawing.Size(120, 20);
            this.num_Book_Pages.TabIndex = 21;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Dateiverwaltung.Properties.Resources.Story;
            this.pictureBox1.Location = new System.Drawing.Point(763, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(95, 117);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // btn_Add_Book
            // 
            this.btn_Add_Book.Location = new System.Drawing.Point(375, 113);
            this.btn_Add_Book.Name = "btn_Add_Book";
            this.btn_Add_Book.Size = new System.Drawing.Size(377, 23);
            this.btn_Add_Book.TabIndex = 10;
            this.btn_Add_Book.Text = "Hinzufügen";
            this.btn_Add_Book.UseVisualStyleBackColor = true;
            this.btn_Add_Book.Click += new System.EventHandler(this.btn_Add_Media_Click);
            // 
            // cb_Search_Book
            // 
            this.cb_Search_Book.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cb_Search_Book.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cb_Search_Book.FormattingEnabled = true;
            this.cb_Search_Book.Items.AddRange(new object[] {
            "Hans",
            "Hänsel",
            "Peter",
            "Robert",
            "Herbert"});
            this.cb_Search_Book.Location = new System.Drawing.Point(18, 19);
            this.cb_Search_Book.Name = "cb_Search_Book";
            this.cb_Search_Book.Size = new System.Drawing.Size(734, 21);
            this.cb_Search_Book.TabIndex = 6;
            this.cb_Search_Book.SelectedValueChanged += new System.EventHandler(this.searchComboBoxen_SelectedValueChanged);
            // 
            // btn_Edit_Book
            // 
            this.btn_Edit_Book.Enabled = false;
            this.btn_Edit_Book.Location = new System.Drawing.Point(18, 113);
            this.btn_Edit_Book.Name = "btn_Edit_Book";
            this.btn_Edit_Book.Size = new System.Drawing.Size(351, 23);
            this.btn_Edit_Book.TabIndex = 9;
            this.btn_Edit_Book.Text = "Bearbeiten";
            this.btn_Edit_Book.UseVisualStyleBackColor = true;
            this.btn_Edit_Book.Click += new System.EventHandler(this.btn_Edit_Media_Click);
            // 
            // tb_Book_Autor
            // 
            this.tb_Book_Autor.Location = new System.Drawing.Point(398, 53);
            this.tb_Book_Autor.Name = "tb_Book_Autor";
            this.tb_Book_Autor.Size = new System.Drawing.Size(182, 20);
            this.tb_Book_Autor.TabIndex = 17;
            // 
            // dtp_Book_Release
            // 
            this.dtp_Book_Release.Location = new System.Drawing.Point(105, 87);
            this.dtp_Book_Release.MaxDate = new System.DateTime(3100, 2, 1, 0, 0, 0, 0);
            this.dtp_Book_Release.Name = "dtp_Book_Release";
            this.dtp_Book_Release.Size = new System.Drawing.Size(200, 20);
            this.dtp_Book_Release.TabIndex = 16;
            this.dtp_Book_Release.Value = new System.DateTime(2017, 5, 21, 0, 0, 0, 0);
            // 
            // tb_Book_Genre
            // 
            this.tb_Book_Genre.Location = new System.Drawing.Point(236, 53);
            this.tb_Book_Genre.Name = "tb_Book_Genre";
            this.tb_Book_Genre.Size = new System.Drawing.Size(115, 20);
            this.tb_Book_Genre.TabIndex = 14;
            // 
            // tb_Book_Titel
            // 
            this.tb_Book_Titel.Location = new System.Drawing.Point(51, 53);
            this.tb_Book_Titel.Name = "tb_Book_Titel";
            this.tb_Book_Titel.Size = new System.Drawing.Size(134, 20);
            this.tb_Book_Titel.TabIndex = 13;
            // 
            // lb_Titel
            // 
            this.lb_Titel.AutoSize = true;
            this.lb_Titel.Location = new System.Drawing.Point(15, 56);
            this.lb_Titel.Name = "lb_Titel";
            this.lb_Titel.Size = new System.Drawing.Size(30, 13);
            this.lb_Titel.TabIndex = 0;
            this.lb_Titel.Text = "Titel:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(586, 56);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Seiten:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(15, 89);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(87, 13);
            this.label11.TabIndex = 10;
            this.label11.Text = "Veröffentlichung:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(357, 56);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Autor:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(191, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Genre:";
            // 
            // tab_Ebooks
            // 
            this.tab_Ebooks.BackColor = System.Drawing.Color.Transparent;
            this.tab_Ebooks.Controls.Add(this.groupBox2);
            this.tab_Ebooks.Location = new System.Drawing.Point(4, 22);
            this.tab_Ebooks.Name = "tab_Ebooks";
            this.tab_Ebooks.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Ebooks.Size = new System.Drawing.Size(871, 222);
            this.tab_Ebooks.TabIndex = 5;
            this.tab_Ebooks.Text = "E-Books";
            // 
            // groupBox2
            // 
            this.groupBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox2.Controls.Add(this.num_EBook_Pages);
            this.groupBox2.Controls.Add(this.pictureBox2);
            this.groupBox2.Controls.Add(this.btn_Add_EBook);
            this.groupBox2.Controls.Add(this.btn_Edit_EBook);
            this.groupBox2.Controls.Add(this.cb_Search_EBook);
            this.groupBox2.Controls.Add(this.tb_EBook_Autor);
            this.groupBox2.Controls.Add(this.dtp_EBook_Release);
            this.groupBox2.Controls.Add(this.tb_EBook_Genre);
            this.groupBox2.Controls.Add(this.tb_EBook_Titel);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.label19);
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(868, 163);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = " Daten";
            // 
            // num_EBook_Pages
            // 
            this.num_EBook_Pages.Location = new System.Drawing.Point(632, 54);
            this.num_EBook_Pages.Maximum = new decimal(new int[] {
            80000,
            0,
            0,
            0});
            this.num_EBook_Pages.Name = "num_EBook_Pages";
            this.num_EBook_Pages.Size = new System.Drawing.Size(120, 20);
            this.num_EBook_Pages.TabIndex = 23;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Dateiverwaltung.Properties.Resources.Story;
            this.pictureBox2.Location = new System.Drawing.Point(763, 19);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(95, 117);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 22;
            this.pictureBox2.TabStop = false;
            // 
            // btn_Add_EBook
            // 
            this.btn_Add_EBook.Location = new System.Drawing.Point(375, 113);
            this.btn_Add_EBook.Name = "btn_Add_EBook";
            this.btn_Add_EBook.Size = new System.Drawing.Size(377, 23);
            this.btn_Add_EBook.TabIndex = 21;
            this.btn_Add_EBook.Text = "Hinzufügen";
            this.btn_Add_EBook.UseVisualStyleBackColor = true;
            this.btn_Add_EBook.Click += new System.EventHandler(this.btn_Add_Media_Click);
            // 
            // btn_Edit_EBook
            // 
            this.btn_Edit_EBook.Enabled = false;
            this.btn_Edit_EBook.Location = new System.Drawing.Point(18, 113);
            this.btn_Edit_EBook.Name = "btn_Edit_EBook";
            this.btn_Edit_EBook.Size = new System.Drawing.Size(351, 23);
            this.btn_Edit_EBook.TabIndex = 20;
            this.btn_Edit_EBook.Text = "Bearbeiten";
            this.btn_Edit_EBook.UseVisualStyleBackColor = true;
            this.btn_Edit_EBook.Click += new System.EventHandler(this.btn_Edit_Media_Click);
            // 
            // cb_Search_EBook
            // 
            this.cb_Search_EBook.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cb_Search_EBook.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cb_Search_EBook.FormattingEnabled = true;
            this.cb_Search_EBook.Items.AddRange(new object[] {
            "Hans",
            "Hänsel",
            "Peter",
            "Robert",
            "Herbert"});
            this.cb_Search_EBook.Location = new System.Drawing.Point(18, 19);
            this.cb_Search_EBook.Name = "cb_Search_EBook";
            this.cb_Search_EBook.Size = new System.Drawing.Size(734, 21);
            this.cb_Search_EBook.TabIndex = 6;
            this.cb_Search_EBook.SelectedValueChanged += new System.EventHandler(this.searchComboBoxen_SelectedValueChanged);
            // 
            // tb_EBook_Autor
            // 
            this.tb_EBook_Autor.Location = new System.Drawing.Point(398, 53);
            this.tb_EBook_Autor.Name = "tb_EBook_Autor";
            this.tb_EBook_Autor.Size = new System.Drawing.Size(182, 20);
            this.tb_EBook_Autor.TabIndex = 17;
            // 
            // dtp_EBook_Release
            // 
            this.dtp_EBook_Release.Location = new System.Drawing.Point(105, 87);
            this.dtp_EBook_Release.MaxDate = new System.DateTime(3100, 2, 1, 0, 0, 0, 0);
            this.dtp_EBook_Release.Name = "dtp_EBook_Release";
            this.dtp_EBook_Release.Size = new System.Drawing.Size(200, 20);
            this.dtp_EBook_Release.TabIndex = 16;
            this.dtp_EBook_Release.Value = new System.DateTime(2017, 5, 21, 0, 0, 0, 0);
            // 
            // tb_EBook_Genre
            // 
            this.tb_EBook_Genre.Location = new System.Drawing.Point(236, 53);
            this.tb_EBook_Genre.Name = "tb_EBook_Genre";
            this.tb_EBook_Genre.Size = new System.Drawing.Size(115, 20);
            this.tb_EBook_Genre.TabIndex = 14;
            // 
            // tb_EBook_Titel
            // 
            this.tb_EBook_Titel.Location = new System.Drawing.Point(51, 53);
            this.tb_EBook_Titel.Name = "tb_EBook_Titel";
            this.tb_EBook_Titel.Size = new System.Drawing.Size(134, 20);
            this.tb_EBook_Titel.TabIndex = 13;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(15, 56);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(30, 13);
            this.label13.TabIndex = 0;
            this.label13.Text = "Titel:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(586, 56);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(40, 13);
            this.label15.TabIndex = 4;
            this.label15.Text = "Seiten:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(15, 89);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(87, 13);
            this.label16.TabIndex = 10;
            this.label16.Text = "Veröffentlichung:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(357, 56);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(35, 13);
            this.label17.TabIndex = 1;
            this.label17.Text = "Autor:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(191, 56);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(39, 13);
            this.label19.TabIndex = 8;
            this.label19.Text = "Genre:";
            // 
            // tab_CDs
            // 
            this.tab_CDs.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tab_CDs.Controls.Add(this.groupBox6);
            this.tab_CDs.Location = new System.Drawing.Point(4, 22);
            this.tab_CDs.Name = "tab_CDs";
            this.tab_CDs.Padding = new System.Windows.Forms.Padding(3);
            this.tab_CDs.Size = new System.Drawing.Size(871, 222);
            this.tab_CDs.TabIndex = 8;
            this.tab_CDs.Text = "CD";
            this.tab_CDs.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.num_CD_Length);
            this.groupBox6.Controls.Add(this.pictureBox5);
            this.groupBox6.Controls.Add(this.btn_Add_CD);
            this.groupBox6.Controls.Add(this.btn_Edit_CD);
            this.groupBox6.Controls.Add(this.cb_Search_CD);
            this.groupBox6.Controls.Add(this.tb_CD_Interpret);
            this.groupBox6.Controls.Add(this.dtp_CD_Release);
            this.groupBox6.Controls.Add(this.tb_CD_Genre);
            this.groupBox6.Controls.Add(this.tb_CD_Titel);
            this.groupBox6.Controls.Add(this.label48);
            this.groupBox6.Controls.Add(this.label50);
            this.groupBox6.Controls.Add(this.label51);
            this.groupBox6.Controls.Add(this.label52);
            this.groupBox6.Controls.Add(this.label54);
            this.groupBox6.Location = new System.Drawing.Point(0, 0);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(868, 169);
            this.groupBox6.TabIndex = 9;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = " Daten";
            // 
            // num_CD_Length
            // 
            this.num_CD_Length.Location = new System.Drawing.Point(652, 53);
            this.num_CD_Length.Maximum = new decimal(new int[] {
            80000,
            0,
            0,
            0});
            this.num_CD_Length.Name = "num_CD_Length";
            this.num_CD_Length.Size = new System.Drawing.Size(100, 20);
            this.num_CD_Length.TabIndex = 26;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::Dateiverwaltung.Properties.Resources.Mukke;
            this.pictureBox5.Location = new System.Drawing.Point(763, 19);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(95, 118);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 25;
            this.pictureBox5.TabStop = false;
            // 
            // btn_Add_CD
            // 
            this.btn_Add_CD.Location = new System.Drawing.Point(375, 113);
            this.btn_Add_CD.Name = "btn_Add_CD";
            this.btn_Add_CD.Size = new System.Drawing.Size(377, 23);
            this.btn_Add_CD.TabIndex = 23;
            this.btn_Add_CD.Text = "Hinzufügen";
            this.btn_Add_CD.UseVisualStyleBackColor = true;
            this.btn_Add_CD.Click += new System.EventHandler(this.btn_Add_Media_Click);
            // 
            // btn_Edit_CD
            // 
            this.btn_Edit_CD.Enabled = false;
            this.btn_Edit_CD.Location = new System.Drawing.Point(18, 113);
            this.btn_Edit_CD.Name = "btn_Edit_CD";
            this.btn_Edit_CD.Size = new System.Drawing.Size(351, 23);
            this.btn_Edit_CD.TabIndex = 22;
            this.btn_Edit_CD.Text = "Bearbeiten";
            this.btn_Edit_CD.UseVisualStyleBackColor = true;
            this.btn_Edit_CD.Click += new System.EventHandler(this.btn_Edit_Media_Click);
            // 
            // cb_Search_CD
            // 
            this.cb_Search_CD.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cb_Search_CD.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cb_Search_CD.FormattingEnabled = true;
            this.cb_Search_CD.Items.AddRange(new object[] {
            "Hans",
            "Hänsel",
            "Peter",
            "Robert",
            "Herbert"});
            this.cb_Search_CD.Location = new System.Drawing.Point(18, 19);
            this.cb_Search_CD.Name = "cb_Search_CD";
            this.cb_Search_CD.Size = new System.Drawing.Size(734, 21);
            this.cb_Search_CD.TabIndex = 8;
            this.cb_Search_CD.SelectedValueChanged += new System.EventHandler(this.searchComboBoxen_SelectedValueChanged);
            // 
            // tb_CD_Interpret
            // 
            this.tb_CD_Interpret.Location = new System.Drawing.Point(406, 53);
            this.tb_CD_Interpret.Name = "tb_CD_Interpret";
            this.tb_CD_Interpret.Size = new System.Drawing.Size(194, 20);
            this.tb_CD_Interpret.TabIndex = 17;
            // 
            // dtp_CD_Release
            // 
            this.dtp_CD_Release.Location = new System.Drawing.Point(105, 87);
            this.dtp_CD_Release.MaxDate = new System.DateTime(3100, 2, 1, 0, 0, 0, 0);
            this.dtp_CD_Release.Name = "dtp_CD_Release";
            this.dtp_CD_Release.Size = new System.Drawing.Size(200, 20);
            this.dtp_CD_Release.TabIndex = 16;
            this.dtp_CD_Release.Value = new System.DateTime(2017, 5, 21, 0, 0, 0, 0);
            // 
            // tb_CD_Genre
            // 
            this.tb_CD_Genre.Location = new System.Drawing.Point(236, 53);
            this.tb_CD_Genre.Name = "tb_CD_Genre";
            this.tb_CD_Genre.Size = new System.Drawing.Size(109, 20);
            this.tb_CD_Genre.TabIndex = 14;
            // 
            // tb_CD_Titel
            // 
            this.tb_CD_Titel.Location = new System.Drawing.Point(51, 53);
            this.tb_CD_Titel.Name = "tb_CD_Titel";
            this.tb_CD_Titel.Size = new System.Drawing.Size(134, 20);
            this.tb_CD_Titel.TabIndex = 13;
            // 
            // label48
            // 
            this.label48.AutoSize = true;
            this.label48.Location = new System.Drawing.Point(15, 56);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(30, 13);
            this.label48.TabIndex = 0;
            this.label48.Text = "Titel:";
            // 
            // label50
            // 
            this.label50.AutoSize = true;
            this.label50.Location = new System.Drawing.Point(606, 56);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(40, 13);
            this.label50.TabIndex = 4;
            this.label50.Text = "Länge:";
            // 
            // label51
            // 
            this.label51.AutoSize = true;
            this.label51.Location = new System.Drawing.Point(15, 89);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(87, 13);
            this.label51.TabIndex = 10;
            this.label51.Text = "Veröffentlichung:";
            // 
            // label52
            // 
            this.label52.AutoSize = true;
            this.label52.Location = new System.Drawing.Point(351, 56);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(49, 13);
            this.label52.TabIndex = 1;
            this.label52.Text = "Interpret:";
            // 
            // label54
            // 
            this.label54.AutoSize = true;
            this.label54.Location = new System.Drawing.Point(191, 56);
            this.label54.Name = "label54";
            this.label54.Size = new System.Drawing.Size(39, 13);
            this.label54.TabIndex = 8;
            this.label54.Text = "Genre:";
            // 
            // tab_DVDs
            // 
            this.tab_DVDs.BackColor = System.Drawing.Color.Transparent;
            this.tab_DVDs.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tab_DVDs.Controls.Add(this.groupBox3);
            this.tab_DVDs.Location = new System.Drawing.Point(4, 22);
            this.tab_DVDs.Name = "tab_DVDs";
            this.tab_DVDs.Padding = new System.Windows.Forms.Padding(3);
            this.tab_DVDs.Size = new System.Drawing.Size(871, 222);
            this.tab_DVDs.TabIndex = 6;
            this.tab_DVDs.Text = "DVD";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.cb_DVD_FSK);
            this.groupBox3.Controls.Add(this.num_DVD_Length);
            this.groupBox3.Controls.Add(this.pictureBox3);
            this.groupBox3.Controls.Add(this.btn_Add_DVD);
            this.groupBox3.Controls.Add(this.btn_Edit_DVD);
            this.groupBox3.Controls.Add(this.cb_Search_DVD);
            this.groupBox3.Controls.Add(this.label29);
            this.groupBox3.Controls.Add(this.tb_DVD_Director);
            this.groupBox3.Controls.Add(this.dtp_DVD_Release);
            this.groupBox3.Controls.Add(this.tb_DVD_Genre);
            this.groupBox3.Controls.Add(this.tb_DVD_Titel);
            this.groupBox3.Controls.Add(this.label21);
            this.groupBox3.Controls.Add(this.label23);
            this.groupBox3.Controls.Add(this.label24);
            this.groupBox3.Controls.Add(this.label25);
            this.groupBox3.Controls.Add(this.label27);
            this.groupBox3.Location = new System.Drawing.Point(0, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(868, 169);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = " Daten";
            // 
            // cb_DVD_FSK
            // 
            this.cb_DVD_FSK.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_DVD_FSK.FormattingEnabled = true;
            this.cb_DVD_FSK.Items.AddRange(new object[] {
            "0",
            "6",
            "12",
            "16",
            "18"});
            this.cb_DVD_FSK.Location = new System.Drawing.Point(360, 87);
            this.cb_DVD_FSK.Name = "cb_DVD_FSK";
            this.cb_DVD_FSK.Size = new System.Drawing.Size(121, 21);
            this.cb_DVD_FSK.TabIndex = 26;
            // 
            // num_DVD_Length
            // 
            this.num_DVD_Length.Location = new System.Drawing.Point(654, 53);
            this.num_DVD_Length.Maximum = new decimal(new int[] {
            80000,
            0,
            0,
            0});
            this.num_DVD_Length.Name = "num_DVD_Length";
            this.num_DVD_Length.Size = new System.Drawing.Size(98, 20);
            this.num_DVD_Length.TabIndex = 25;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Dateiverwaltung.Properties.Resources.Movie;
            this.pictureBox3.Location = new System.Drawing.Point(763, 19);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(95, 118);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 24;
            this.pictureBox3.TabStop = false;
            // 
            // btn_Add_DVD
            // 
            this.btn_Add_DVD.Location = new System.Drawing.Point(375, 113);
            this.btn_Add_DVD.Name = "btn_Add_DVD";
            this.btn_Add_DVD.Size = new System.Drawing.Size(377, 23);
            this.btn_Add_DVD.TabIndex = 23;
            this.btn_Add_DVD.Text = "Hinzufügen";
            this.btn_Add_DVD.UseVisualStyleBackColor = true;
            this.btn_Add_DVD.Click += new System.EventHandler(this.btn_Add_Media_Click);
            // 
            // btn_Edit_DVD
            // 
            this.btn_Edit_DVD.Enabled = false;
            this.btn_Edit_DVD.Location = new System.Drawing.Point(18, 113);
            this.btn_Edit_DVD.Name = "btn_Edit_DVD";
            this.btn_Edit_DVD.Size = new System.Drawing.Size(351, 23);
            this.btn_Edit_DVD.TabIndex = 22;
            this.btn_Edit_DVD.Text = "Bearbeiten";
            this.btn_Edit_DVD.UseVisualStyleBackColor = true;
            this.btn_Edit_DVD.Click += new System.EventHandler(this.btn_Edit_Media_Click);
            // 
            // cb_Search_DVD
            // 
            this.cb_Search_DVD.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cb_Search_DVD.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cb_Search_DVD.FormattingEnabled = true;
            this.cb_Search_DVD.Items.AddRange(new object[] {
            "Hans",
            "Hänsel",
            "Peter",
            "Robert",
            "Herbert"});
            this.cb_Search_DVD.Location = new System.Drawing.Point(18, 19);
            this.cb_Search_DVD.Name = "cb_Search_DVD";
            this.cb_Search_DVD.Size = new System.Drawing.Size(734, 21);
            this.cb_Search_DVD.TabIndex = 8;
            this.cb_Search_DVD.SelectedValueChanged += new System.EventHandler(this.searchComboBoxen_SelectedValueChanged);
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(323, 90);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(30, 13);
            this.label29.TabIndex = 20;
            this.label29.Text = "FSK:";
            // 
            // tb_DVD_Director
            // 
            this.tb_DVD_Director.Location = new System.Drawing.Point(420, 53);
            this.tb_DVD_Director.Name = "tb_DVD_Director";
            this.tb_DVD_Director.Size = new System.Drawing.Size(182, 20);
            this.tb_DVD_Director.TabIndex = 17;
            // 
            // dtp_DVD_Release
            // 
            this.dtp_DVD_Release.Location = new System.Drawing.Point(105, 87);
            this.dtp_DVD_Release.MaxDate = new System.DateTime(3100, 2, 1, 0, 0, 0, 0);
            this.dtp_DVD_Release.Name = "dtp_DVD_Release";
            this.dtp_DVD_Release.Size = new System.Drawing.Size(200, 20);
            this.dtp_DVD_Release.TabIndex = 16;
            this.dtp_DVD_Release.Value = new System.DateTime(2017, 5, 21, 0, 0, 0, 0);
            // 
            // tb_DVD_Genre
            // 
            this.tb_DVD_Genre.Location = new System.Drawing.Point(236, 53);
            this.tb_DVD_Genre.Name = "tb_DVD_Genre";
            this.tb_DVD_Genre.Size = new System.Drawing.Size(115, 20);
            this.tb_DVD_Genre.TabIndex = 14;
            // 
            // tb_DVD_Titel
            // 
            this.tb_DVD_Titel.Location = new System.Drawing.Point(51, 53);
            this.tb_DVD_Titel.Name = "tb_DVD_Titel";
            this.tb_DVD_Titel.Size = new System.Drawing.Size(134, 20);
            this.tb_DVD_Titel.TabIndex = 13;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(15, 56);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(30, 13);
            this.label21.TabIndex = 0;
            this.label21.Text = "Titel:";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(608, 56);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(40, 13);
            this.label23.TabIndex = 4;
            this.label23.Text = "Länge:";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(15, 89);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(87, 13);
            this.label24.TabIndex = 10;
            this.label24.Text = "Veröffentlichung:";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(357, 56);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(57, 13);
            this.label25.TabIndex = 1;
            this.label25.Text = "Regisseur:";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(191, 56);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(39, 13);
            this.label27.TabIndex = 8;
            this.label27.Text = "Genre:";
            // 
            // tab_BluRays
            // 
            this.tab_BluRays.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tab_BluRays.Controls.Add(this.groupBox4);
            this.tab_BluRays.Location = new System.Drawing.Point(4, 22);
            this.tab_BluRays.Name = "tab_BluRays";
            this.tab_BluRays.Padding = new System.Windows.Forms.Padding(3);
            this.tab_BluRays.Size = new System.Drawing.Size(871, 222);
            this.tab_BluRays.TabIndex = 7;
            this.tab_BluRays.Text = "BluRay";
            this.tab_BluRays.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cb_BluRay_FSK);
            this.groupBox4.Controls.Add(this.num_BluRay_Length);
            this.groupBox4.Controls.Add(this.pictureBox4);
            this.groupBox4.Controls.Add(this.btn_Add_BluRay);
            this.groupBox4.Controls.Add(this.btn_Edit_BluRay);
            this.groupBox4.Controls.Add(this.cb_Search_BluRay);
            this.groupBox4.Controls.Add(this.label30);
            this.groupBox4.Controls.Add(this.tb_BluRay_Director);
            this.groupBox4.Controls.Add(this.dtp_BluRay_Release);
            this.groupBox4.Controls.Add(this.tb_BluRay_Genre);
            this.groupBox4.Controls.Add(this.tb_BluRay_Titel);
            this.groupBox4.Controls.Add(this.label31);
            this.groupBox4.Controls.Add(this.label33);
            this.groupBox4.Controls.Add(this.label34);
            this.groupBox4.Controls.Add(this.label35);
            this.groupBox4.Controls.Add(this.label37);
            this.groupBox4.Location = new System.Drawing.Point(0, 0);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(868, 169);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = " Daten";
            // 
            // cb_BluRay_FSK
            // 
            this.cb_BluRay_FSK.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_BluRay_FSK.FormattingEnabled = true;
            this.cb_BluRay_FSK.Items.AddRange(new object[] {
            "0",
            "6",
            "12",
            "16",
            "18"});
            this.cb_BluRay_FSK.Location = new System.Drawing.Point(360, 86);
            this.cb_BluRay_FSK.Name = "cb_BluRay_FSK";
            this.cb_BluRay_FSK.Size = new System.Drawing.Size(121, 21);
            this.cb_BluRay_FSK.TabIndex = 27;
            // 
            // num_BluRay_Length
            // 
            this.num_BluRay_Length.Location = new System.Drawing.Point(654, 53);
            this.num_BluRay_Length.Maximum = new decimal(new int[] {
            80000,
            0,
            0,
            0});
            this.num_BluRay_Length.Name = "num_BluRay_Length";
            this.num_BluRay_Length.Size = new System.Drawing.Size(98, 20);
            this.num_BluRay_Length.TabIndex = 26;
            this.num_BluRay_Length.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Dateiverwaltung.Properties.Resources.Movie;
            this.pictureBox4.Location = new System.Drawing.Point(763, 19);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(95, 118);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 25;
            this.pictureBox4.TabStop = false;
            // 
            // btn_Add_BluRay
            // 
            this.btn_Add_BluRay.Location = new System.Drawing.Point(375, 113);
            this.btn_Add_BluRay.Name = "btn_Add_BluRay";
            this.btn_Add_BluRay.Size = new System.Drawing.Size(377, 23);
            this.btn_Add_BluRay.TabIndex = 23;
            this.btn_Add_BluRay.Text = "Hinzufügen";
            this.btn_Add_BluRay.UseVisualStyleBackColor = true;
            this.btn_Add_BluRay.Click += new System.EventHandler(this.btn_Add_Media_Click);
            // 
            // btn_Edit_BluRay
            // 
            this.btn_Edit_BluRay.Enabled = false;
            this.btn_Edit_BluRay.Location = new System.Drawing.Point(18, 113);
            this.btn_Edit_BluRay.Name = "btn_Edit_BluRay";
            this.btn_Edit_BluRay.Size = new System.Drawing.Size(351, 23);
            this.btn_Edit_BluRay.TabIndex = 22;
            this.btn_Edit_BluRay.Text = "Bearbeiten";
            this.btn_Edit_BluRay.UseVisualStyleBackColor = true;
            this.btn_Edit_BluRay.Click += new System.EventHandler(this.btn_Edit_Media_Click);
            // 
            // cb_Search_BluRay
            // 
            this.cb_Search_BluRay.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cb_Search_BluRay.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cb_Search_BluRay.FormattingEnabled = true;
            this.cb_Search_BluRay.Items.AddRange(new object[] {
            "Hans",
            "Hänsel",
            "Peter",
            "Robert",
            "Herbert"});
            this.cb_Search_BluRay.Location = new System.Drawing.Point(18, 19);
            this.cb_Search_BluRay.Name = "cb_Search_BluRay";
            this.cb_Search_BluRay.Size = new System.Drawing.Size(734, 21);
            this.cb_Search_BluRay.TabIndex = 8;
            this.cb_Search_BluRay.SelectedValueChanged += new System.EventHandler(this.searchComboBoxen_SelectedValueChanged);
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(323, 90);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(30, 13);
            this.label30.TabIndex = 20;
            this.label30.Text = "FSK:";
            // 
            // tb_BluRay_Director
            // 
            this.tb_BluRay_Director.Location = new System.Drawing.Point(420, 53);
            this.tb_BluRay_Director.Name = "tb_BluRay_Director";
            this.tb_BluRay_Director.Size = new System.Drawing.Size(182, 20);
            this.tb_BluRay_Director.TabIndex = 17;
            // 
            // dtp_BluRay_Release
            // 
            this.dtp_BluRay_Release.Location = new System.Drawing.Point(105, 87);
            this.dtp_BluRay_Release.MaxDate = new System.DateTime(3100, 2, 1, 0, 0, 0, 0);
            this.dtp_BluRay_Release.Name = "dtp_BluRay_Release";
            this.dtp_BluRay_Release.Size = new System.Drawing.Size(200, 20);
            this.dtp_BluRay_Release.TabIndex = 16;
            // 
            // tb_BluRay_Genre
            // 
            this.tb_BluRay_Genre.Location = new System.Drawing.Point(236, 53);
            this.tb_BluRay_Genre.Name = "tb_BluRay_Genre";
            this.tb_BluRay_Genre.Size = new System.Drawing.Size(115, 20);
            this.tb_BluRay_Genre.TabIndex = 14;
            // 
            // tb_BluRay_Titel
            // 
            this.tb_BluRay_Titel.Location = new System.Drawing.Point(51, 53);
            this.tb_BluRay_Titel.Name = "tb_BluRay_Titel";
            this.tb_BluRay_Titel.Size = new System.Drawing.Size(134, 20);
            this.tb_BluRay_Titel.TabIndex = 13;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(15, 56);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(30, 13);
            this.label31.TabIndex = 0;
            this.label31.Text = "Titel:";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(608, 56);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(40, 13);
            this.label33.TabIndex = 4;
            this.label33.Text = "Länge:";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(15, 89);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(87, 13);
            this.label34.TabIndex = 10;
            this.label34.Text = "Veröffentlichung:";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(357, 56);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(57, 13);
            this.label35.TabIndex = 1;
            this.label35.Text = "Regisseur:";
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(191, 56);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(39, 13);
            this.label37.TabIndex = 8;
            this.label37.Text = "Genre:";
            // 
            // EditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(875, 248);
            this.Controls.Add(this.tabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "EditForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Daten Bearbeiten";
            this.tabControl.ResumeLayout(false);
            this.tab_Customers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Borrowed)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tab_Books.ResumeLayout(false);
            this.Daten.ResumeLayout(false);
            this.Daten.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_Book_Pages)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tab_Ebooks.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_EBook_Pages)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.tab_CDs.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_CD_Length)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.tab_DVDs.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_DVD_Length)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.tab_BluRays.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_BluRay_Length)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tab_Customers;
        private System.Windows.Forms.ComboBox cb_Search;
        private System.Windows.Forms.TabPage tab_Books;
        private System.Windows.Forms.TabPage tab_Ebooks;
        private System.Windows.Forms.Button btn_EditCostumer;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cb_LendSearch;
        private System.Windows.Forms.ComboBox cb_WichMedia;
        private System.Windows.Forms.Button btn_Borrow;
        private System.Windows.Forms.Button btn_return;
        private System.Windows.Forms.DataGridView dgv_Borrowed;
        private System.Windows.Forms.TextBox tb_Ort;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_PLZ;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_Strasse;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_Vorname;
        private System.Windows.Forms.TextBox tb_Name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox Daten;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lb_Titel;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tb_Book_Autor;
        private System.Windows.Forms.DateTimePicker dtp_Book_Release;
        private System.Windows.Forms.TextBox tb_Book_Genre;
        private System.Windows.Forms.TextBox tb_Book_Titel;
        private System.Windows.Forms.TabPage tab_DVDs;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox tb_DVD_Director;
        private System.Windows.Forms.DateTimePicker dtp_DVD_Release;
        private System.Windows.Forms.TextBox tb_DVD_Genre;
        private System.Windows.Forms.TextBox tb_DVD_Titel;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.TabPage tab_BluRays;
        private System.Windows.Forms.TabPage tab_CDs;
        private System.Windows.Forms.ComboBox cb_Search_Book;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cb_Search_EBook;
        private System.Windows.Forms.TextBox tb_EBook_Autor;
        private System.Windows.Forms.DateTimePicker dtp_EBook_Release;
        private System.Windows.Forms.TextBox tb_EBook_Genre;
        private System.Windows.Forms.TextBox tb_EBook_Titel;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.ComboBox cb_Search_DVD;
        private System.Windows.Forms.Button btn_AddCostumer;
        private System.Windows.Forms.Button btn_Add_Book;
        private System.Windows.Forms.Button btn_Edit_Book;
        private System.Windows.Forms.Button btn_Add_EBook;
        private System.Windows.Forms.Button btn_Edit_EBook;
        private System.Windows.Forms.Button btn_Add_DVD;
        private System.Windows.Forms.Button btn_Edit_DVD;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btn_Add_BluRay;
        private System.Windows.Forms.Button btn_Edit_BluRay;
        private System.Windows.Forms.ComboBox cb_Search_BluRay;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.TextBox tb_BluRay_Director;
        private System.Windows.Forms.DateTimePicker dtp_BluRay_Release;
        private System.Windows.Forms.TextBox tb_BluRay_Genre;
        private System.Windows.Forms.TextBox tb_BluRay_Titel;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button btn_Add_CD;
        private System.Windows.Forms.Button btn_Edit_CD;
        private System.Windows.Forms.ComboBox cb_Search_CD;
        private System.Windows.Forms.TextBox tb_CD_Interpret;
        private System.Windows.Forms.DateTimePicker dtp_CD_Release;
        private System.Windows.Forms.TextBox tb_CD_Genre;
        private System.Windows.Forms.TextBox tb_CD_Titel;
        private System.Windows.Forms.Label label48;
        private System.Windows.Forms.Label label50;
        private System.Windows.Forms.Label label51;
        private System.Windows.Forms.Label label52;
        private System.Windows.Forms.Label label54;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.NumericUpDown num_Book_Pages;
        private System.Windows.Forms.NumericUpDown num_EBook_Pages;
        private System.Windows.Forms.NumericUpDown num_DVD_Length;
        private System.Windows.Forms.NumericUpDown num_BluRay_Length;
        private System.Windows.Forms.NumericUpDown num_CD_Length;
        private System.Windows.Forms.ComboBox cb_DVD_FSK;
        private System.Windows.Forms.ComboBox cb_BluRay_FSK;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Titel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Medium;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}