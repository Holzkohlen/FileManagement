namespace Dateiverwaltung
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "01",
            "Kern",
            "Daniel"}, -1);
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem6 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem7 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem8 = new System.Windows.Forms.ListViewItem("");
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dateiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hilfeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.überToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tab_Customers = new System.Windows.Forms.TabPage();
            this.tab_Books = new System.Windows.Forms.TabPage();
            this.tb_Search = new System.Windows.Forms.TextBox();
            this.btn_Edit = new System.Windows.Forms.Button();
            this.tab_CDs = new System.Windows.Forms.TabPage();
            this.tab_DVDs = new System.Windows.Forms.TabPage();
            this.tab_BluRays = new System.Windows.Forms.TabPage();
            this.tab_Ebooks = new System.Windows.Forms.TabPage();
            this.listView1 = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Nachname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Vorname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tab_Customers.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dateiToolStripMenuItem,
            this.hilfeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1230, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dateiToolStripMenuItem
            // 
            this.dateiToolStripMenuItem.Name = "dateiToolStripMenuItem";
            this.dateiToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.dateiToolStripMenuItem.Text = "Datei";
            // 
            // hilfeToolStripMenuItem
            // 
            this.hilfeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.überToolStripMenuItem});
            this.hilfeToolStripMenuItem.Name = "hilfeToolStripMenuItem";
            this.hilfeToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.hilfeToolStripMenuItem.Text = "Hilfe";
            // 
            // überToolStripMenuItem
            // 
            this.überToolStripMenuItem.Name = "überToolStripMenuItem";
            this.überToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.überToolStripMenuItem.Text = "Über";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tab_Customers);
            this.tabControl1.Controls.Add(this.tab_Books);
            this.tabControl1.Controls.Add(this.tab_CDs);
            this.tabControl1.Controls.Add(this.tab_DVDs);
            this.tabControl1.Controls.Add(this.tab_BluRays);
            this.tabControl1.Controls.Add(this.tab_Ebooks);
            this.tabControl1.Location = new System.Drawing.Point(352, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(853, 643);
            this.tabControl1.TabIndex = 1;
            // 
            // tab_Customers
            // 
            this.tab_Customers.Controls.Add(this.listView1);
            this.tab_Customers.Location = new System.Drawing.Point(4, 22);
            this.tab_Customers.Name = "tab_Customers";
            this.tab_Customers.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Customers.Size = new System.Drawing.Size(845, 617);
            this.tab_Customers.TabIndex = 0;
            this.tab_Customers.Text = "Kunden";
            this.tab_Customers.UseVisualStyleBackColor = true;
            // 
            // tab_Books
            // 
            this.tab_Books.Location = new System.Drawing.Point(4, 22);
            this.tab_Books.Name = "tab_Books";
            this.tab_Books.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Books.Size = new System.Drawing.Size(845, 617);
            this.tab_Books.TabIndex = 1;
            this.tab_Books.Text = "Bücher";
            this.tab_Books.UseVisualStyleBackColor = true;
            // 
            // tb_Search
            // 
            this.tb_Search.Location = new System.Drawing.Point(25, 61);
            this.tb_Search.Name = "tb_Search";
            this.tb_Search.Size = new System.Drawing.Size(211, 20);
            this.tb_Search.TabIndex = 2;
            this.tb_Search.Text = "Suchen";
            // 
            // btn_Edit
            // 
            this.btn_Edit.Location = new System.Drawing.Point(161, 173);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(75, 23);
            this.btn_Edit.TabIndex = 3;
            this.btn_Edit.Text = "Bearbeiten";
            this.btn_Edit.UseVisualStyleBackColor = true;
            // 
            // tab_CDs
            // 
            this.tab_CDs.Location = new System.Drawing.Point(4, 22);
            this.tab_CDs.Name = "tab_CDs";
            this.tab_CDs.Padding = new System.Windows.Forms.Padding(3);
            this.tab_CDs.Size = new System.Drawing.Size(845, 617);
            this.tab_CDs.TabIndex = 2;
            this.tab_CDs.Text = "CDs";
            this.tab_CDs.UseVisualStyleBackColor = true;
            // 
            // tab_DVDs
            // 
            this.tab_DVDs.Location = new System.Drawing.Point(4, 22);
            this.tab_DVDs.Name = "tab_DVDs";
            this.tab_DVDs.Padding = new System.Windows.Forms.Padding(3);
            this.tab_DVDs.Size = new System.Drawing.Size(845, 617);
            this.tab_DVDs.TabIndex = 3;
            this.tab_DVDs.Text = "DVDs";
            this.tab_DVDs.UseVisualStyleBackColor = true;
            // 
            // tab_BluRays
            // 
            this.tab_BluRays.Location = new System.Drawing.Point(4, 22);
            this.tab_BluRays.Name = "tab_BluRays";
            this.tab_BluRays.Padding = new System.Windows.Forms.Padding(3);
            this.tab_BluRays.Size = new System.Drawing.Size(845, 617);
            this.tab_BluRays.TabIndex = 4;
            this.tab_BluRays.Text = "BluRays";
            this.tab_BluRays.UseVisualStyleBackColor = true;
            // 
            // tab_Ebooks
            // 
            this.tab_Ebooks.Location = new System.Drawing.Point(4, 22);
            this.tab_Ebooks.Name = "tab_Ebooks";
            this.tab_Ebooks.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Ebooks.Size = new System.Drawing.Size(845, 617);
            this.tab_Ebooks.TabIndex = 5;
            this.tab_Ebooks.Text = "E-Books";
            this.tab_Ebooks.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.Nachname,
            this.Vorname});
            this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3,
            listViewItem4,
            listViewItem5,
            listViewItem6,
            listViewItem7,
            listViewItem8});
            this.listView1.Location = new System.Drawing.Point(110, 115);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(589, 368);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // ID
            // 
            this.ID.Tag = "";
            this.ID.Text = "ID";
            // 
            // Nachname
            // 
            this.Nachname.Text = "Nachname";
            this.Nachname.Width = 67;
            // 
            // Vorname
            // 
            this.Vorname.Text = "Vorname";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1230, 735);
            this.Controls.Add(this.btn_Edit);
            this.Controls.Add(this.tb_Search);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tab_Customers.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dateiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hilfeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem überToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tab_Customers;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader Nachname;
        private System.Windows.Forms.ColumnHeader Vorname;
        private System.Windows.Forms.TabPage tab_Books;
        private System.Windows.Forms.TabPage tab_CDs;
        private System.Windows.Forms.TabPage tab_DVDs;
        private System.Windows.Forms.TabPage tab_BluRays;
        private System.Windows.Forms.TabPage tab_Ebooks;
        private System.Windows.Forms.TextBox tb_Search;
        private System.Windows.Forms.Button btn_Edit;
    }
}

