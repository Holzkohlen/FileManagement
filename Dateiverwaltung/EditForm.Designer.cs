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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tab_Customers = new System.Windows.Forms.TabPage();
            this.cb_Search = new System.Windows.Forms.ComboBox();
            this.tab_Books = new System.Windows.Forms.TabPage();
            this.tab_CDs = new System.Windows.Forms.TabPage();
            this.tab_DVDs = new System.Windows.Forms.TabPage();
            this.tab_BluRays = new System.Windows.Forms.TabPage();
            this.tab_Ebooks = new System.Windows.Forms.TabPage();
            this.btn_Edit = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Titel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Medium = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tab_Customers.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tab_Customers);
            this.tabControl1.Controls.Add(this.tab_Books);
            this.tabControl1.Controls.Add(this.tab_CDs);
            this.tabControl1.Controls.Add(this.tab_DVDs);
            this.tabControl1.Controls.Add(this.tab_BluRays);
            this.tabControl1.Controls.Add(this.tab_Ebooks);
            this.tabControl1.Location = new System.Drawing.Point(1, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(879, 250);
            this.tabControl1.TabIndex = 2;
            // 
            // tab_Customers
            // 
            this.tab_Customers.Controls.Add(this.comboBox2);
            this.tab_Customers.Controls.Add(this.comboBox1);
            this.tab_Customers.Controls.Add(this.button2);
            this.tab_Customers.Controls.Add(this.button1);
            this.tab_Customers.Controls.Add(this.dataGridView1);
            this.tab_Customers.Controls.Add(this.groupBox1);
            this.tab_Customers.Controls.Add(this.btn_Edit);
            this.tab_Customers.Controls.Add(this.cb_Search);
            this.tab_Customers.Location = new System.Drawing.Point(4, 22);
            this.tab_Customers.Name = "tab_Customers";
            this.tab_Customers.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Customers.Size = new System.Drawing.Size(871, 224);
            this.tab_Customers.TabIndex = 0;
            this.tab_Customers.Text = "Kunden";
            this.tab_Customers.UseVisualStyleBackColor = true;
            // 
            // cb_Search
            // 
            this.cb_Search.FormattingEnabled = true;
            this.cb_Search.Items.AddRange(new object[] {
            "Hans",
            "Hänsel",
            "Peter",
            "Robert",
            "Herbert"});
            this.cb_Search.Location = new System.Drawing.Point(3, 6);
            this.cb_Search.Name = "cb_Search";
            this.cb_Search.Size = new System.Drawing.Size(369, 21);
            this.cb_Search.TabIndex = 0;
            this.cb_Search.TextChanged += new System.EventHandler(this.cb_Search_TextChanged);
            // 
            // tab_Books
            // 
            this.tab_Books.Location = new System.Drawing.Point(4, 22);
            this.tab_Books.Name = "tab_Books";
            this.tab_Books.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Books.Size = new System.Drawing.Size(871, 463);
            this.tab_Books.TabIndex = 1;
            this.tab_Books.Text = "Bücher";
            this.tab_Books.UseVisualStyleBackColor = true;
            // 
            // tab_CDs
            // 
            this.tab_CDs.Location = new System.Drawing.Point(4, 22);
            this.tab_CDs.Name = "tab_CDs";
            this.tab_CDs.Padding = new System.Windows.Forms.Padding(3);
            this.tab_CDs.Size = new System.Drawing.Size(871, 463);
            this.tab_CDs.TabIndex = 2;
            this.tab_CDs.Text = "CDs";
            this.tab_CDs.UseVisualStyleBackColor = true;
            // 
            // tab_DVDs
            // 
            this.tab_DVDs.Location = new System.Drawing.Point(4, 22);
            this.tab_DVDs.Name = "tab_DVDs";
            this.tab_DVDs.Padding = new System.Windows.Forms.Padding(3);
            this.tab_DVDs.Size = new System.Drawing.Size(871, 463);
            this.tab_DVDs.TabIndex = 3;
            this.tab_DVDs.Text = "DVDs";
            this.tab_DVDs.UseVisualStyleBackColor = true;
            // 
            // tab_BluRays
            // 
            this.tab_BluRays.Location = new System.Drawing.Point(4, 22);
            this.tab_BluRays.Name = "tab_BluRays";
            this.tab_BluRays.Padding = new System.Windows.Forms.Padding(3);
            this.tab_BluRays.Size = new System.Drawing.Size(871, 463);
            this.tab_BluRays.TabIndex = 4;
            this.tab_BluRays.Text = "BluRays";
            this.tab_BluRays.UseVisualStyleBackColor = true;
            // 
            // tab_Ebooks
            // 
            this.tab_Ebooks.Location = new System.Drawing.Point(4, 22);
            this.tab_Ebooks.Name = "tab_Ebooks";
            this.tab_Ebooks.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Ebooks.Size = new System.Drawing.Size(871, 463);
            this.tab_Ebooks.TabIndex = 5;
            this.tab_Ebooks.Text = "E-Books";
            this.tab_Ebooks.UseVisualStyleBackColor = true;
            // 
            // btn_Edit
            // 
            this.btn_Edit.Location = new System.Drawing.Point(3, 193);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(369, 23);
            this.btn_Edit.TabIndex = 1;
            this.btn_Edit.Text = "Bearbeiten";
            this.btn_Edit.UseVisualStyleBackColor = true;
            this.btn_Edit.Click += new System.EventHandler(this.btn_Edit_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox5);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(3, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(369, 154);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " ";
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Vorname:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(64, 27);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(287, 20);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(64, 55);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(287, 20);
            this.textBox2.TabIndex = 3;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(64, 81);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(287, 20);
            this.textBox3.TabIndex = 5;
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
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(64, 106);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(82, 20);
            this.textBox4.TabIndex = 7;
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
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(182, 107);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(169, 20);
            this.textBox5.TabIndex = 9;
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
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Titel,
            this.Medium});
            this.dataGridView1.Location = new System.Drawing.Point(391, 35);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(467, 124);
            this.dataGridView1.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(391, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(467, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Zurückgeben";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(391, 193);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(467, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Ausleihen";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Buch",
            "COD",
            "Minecraft"});
            this.comboBox1.Location = new System.Drawing.Point(391, 166);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 6;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Minecraft 2",
            "Minecraft 4 the Revenge"});
            this.comboBox2.Location = new System.Drawing.Point(519, 166);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(339, 21);
            this.comboBox2.TabIndex = 7;
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
            this.Medium.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Medium.HeaderText = "Medium";
            this.Medium.Name = "Medium";
            // 
            // EditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 246);
            this.Controls.Add(this.tabControl1);
            this.Name = "EditForm";
            this.Text = "EditForm";
            this.Load += new System.EventHandler(this.EditForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tab_Customers.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tab_Customers;
        private System.Windows.Forms.ComboBox cb_Search;
        private System.Windows.Forms.TabPage tab_Books;
        private System.Windows.Forms.TabPage tab_CDs;
        private System.Windows.Forms.TabPage tab_DVDs;
        private System.Windows.Forms.TabPage tab_BluRays;
        private System.Windows.Forms.TabPage tab_Ebooks;
        private System.Windows.Forms.Button btn_Edit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Titel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Medium;
    }
}