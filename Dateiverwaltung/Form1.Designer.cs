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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dateiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hilfeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.überToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tab_Customers = new System.Windows.Forms.TabPage();
            this.tab_Books = new System.Windows.Forms.TabPage();
            this.tab_CDs = new System.Windows.Forms.TabPage();
            this.tab_DVDs = new System.Windows.Forms.TabPage();
            this.tab_BluRays = new System.Windows.Forms.TabPage();
            this.tab_Ebooks = new System.Windows.Forms.TabPage();
            this.tb_Search = new System.Windows.Forms.TextBox();
            this.btn_Edit = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nachname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vorname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Strasse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PLZ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ort = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tab_Customers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dateiToolStripMenuItem,
            this.hilfeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1029, 24);
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
            this.überToolStripMenuItem.Size = new System.Drawing.Size(99, 22);
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
            this.tabControl1.Size = new System.Drawing.Size(674, 419);
            this.tabControl1.TabIndex = 1;
            // 
            // tab_Customers
            // 
            this.tab_Customers.Controls.Add(this.dataGridView1);
            this.tab_Customers.Location = new System.Drawing.Point(4, 22);
            this.tab_Customers.Name = "tab_Customers";
            this.tab_Customers.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Customers.Size = new System.Drawing.Size(666, 393);
            this.tab_Customers.TabIndex = 0;
            this.tab_Customers.Text = "Kunden";
            this.tab_Customers.UseVisualStyleBackColor = true;
            // 
            // tab_Books
            // 
            this.tab_Books.Location = new System.Drawing.Point(4, 22);
            this.tab_Books.Name = "tab_Books";
            this.tab_Books.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Books.Size = new System.Drawing.Size(666, 393);
            this.tab_Books.TabIndex = 1;
            this.tab_Books.Text = "Bücher";
            this.tab_Books.UseVisualStyleBackColor = true;
            // 
            // tab_CDs
            // 
            this.tab_CDs.Location = new System.Drawing.Point(4, 22);
            this.tab_CDs.Name = "tab_CDs";
            this.tab_CDs.Padding = new System.Windows.Forms.Padding(3);
            this.tab_CDs.Size = new System.Drawing.Size(666, 393);
            this.tab_CDs.TabIndex = 2;
            this.tab_CDs.Text = "CDs";
            this.tab_CDs.UseVisualStyleBackColor = true;
            // 
            // tab_DVDs
            // 
            this.tab_DVDs.Location = new System.Drawing.Point(4, 22);
            this.tab_DVDs.Name = "tab_DVDs";
            this.tab_DVDs.Padding = new System.Windows.Forms.Padding(3);
            this.tab_DVDs.Size = new System.Drawing.Size(666, 393);
            this.tab_DVDs.TabIndex = 3;
            this.tab_DVDs.Text = "DVDs";
            this.tab_DVDs.UseVisualStyleBackColor = true;
            // 
            // tab_BluRays
            // 
            this.tab_BluRays.Location = new System.Drawing.Point(4, 22);
            this.tab_BluRays.Name = "tab_BluRays";
            this.tab_BluRays.Padding = new System.Windows.Forms.Padding(3);
            this.tab_BluRays.Size = new System.Drawing.Size(666, 393);
            this.tab_BluRays.TabIndex = 4;
            this.tab_BluRays.Text = "BluRays";
            this.tab_BluRays.UseVisualStyleBackColor = true;
            // 
            // tab_Ebooks
            // 
            this.tab_Ebooks.Location = new System.Drawing.Point(4, 22);
            this.tab_Ebooks.Name = "tab_Ebooks";
            this.tab_Ebooks.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Ebooks.Size = new System.Drawing.Size(666, 393);
            this.tab_Ebooks.TabIndex = 5;
            this.tab_Ebooks.Text = "E-Books";
            this.tab_Ebooks.UseVisualStyleBackColor = true;
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
            this.btn_Edit.Location = new System.Drawing.Point(110, 413);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(75, 23);
            this.btn_Edit.TabIndex = 3;
            this.btn_Edit.Text = "Bearbeiten";
            this.btn_Edit.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Nachname,
            this.Vorname,
            this.Strasse,
            this.PLZ,
            this.Ort});
            this.dataGridView1.Location = new System.Drawing.Point(6, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(654, 381);
            this.dataGridView1.TabIndex = 4;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            // 
            // Nachname
            // 
            this.Nachname.HeaderText = "Nachname";
            this.Nachname.Name = "Nachname";
            // 
            // Vorname
            // 
            this.Vorname.HeaderText = "Vorname";
            this.Vorname.Name = "Vorname";
            // 
            // Strasse
            // 
            this.Strasse.HeaderText = "Straße";
            this.Strasse.Name = "Strasse";
            // 
            // PLZ
            // 
            this.PLZ.HeaderText = "PLZ";
            this.PLZ.Name = "PLZ";
            // 
            // Ort
            // 
            this.Ort.HeaderText = "Ort";
            this.Ort.Name = "Ort";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 448);
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.TabPage tab_Books;
        private System.Windows.Forms.TabPage tab_CDs;
        private System.Windows.Forms.TabPage tab_DVDs;
        private System.Windows.Forms.TabPage tab_BluRays;
        private System.Windows.Forms.TabPage tab_Ebooks;
        private System.Windows.Forms.TextBox tb_Search;
        private System.Windows.Forms.Button btn_Edit;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nachname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vorname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Strasse;
        private System.Windows.Forms.DataGridViewTextBoxColumn PLZ;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ort;
    }
}

