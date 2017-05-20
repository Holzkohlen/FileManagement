using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dateiverwaltung
{
    public partial class EditForm : Form
    {
        Backend code;
        bool bEditMode;
        public EditForm(Backend code)
        {
            InitializeComponent();
            this.code = code;
            bEditMode = false;
        }

        private void EditForm_Load(object sender, EventArgs e)
        {

        }

        private void cb_Search_TextChanged(object sender, EventArgs e)
        {
            //if (!cb_Search.DroppedDown)
            //{
            //    string temp = cb_Search.Text;
            //    cb_Search.DroppedDown = true;
            //    cb_Search.Text = temp;

            //}
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            if (btn_EditCostumer.Text != "Speichern")
            {
                btn_EditCostumer.Text = "Speichern";
                offWrite(false);
                btn_AddCostumer.Enabled = false;
                bEditMode = true;
            }
            else
            {
                btn_EditCostumer.Text = "Bearbeiten";
                offWrite(true);
                btn_AddCostumer.Enabled = true;
                bEditMode = false;
                tabControl1.TabPages[tabControl1.SelectedIndex].Enabled = true;
            }
            
        }

        private void btn_add_Click(object sender, EventArgs e) //Kunde hinzufügen
        {
            if (btn_AddCostumer.Text != "Speichern") //Hinzufügen
            {
                btn_AddCostumer.Text = "Speichern";
                offWrite(false);
                btn_EditCostumer.Enabled = false;
                bEditMode = true;           

            }
            else  //Speichern
            {
                btn_AddCostumer.Text = "Hinzufügen";
                offWrite(true);
                btn_EditCostumer.Enabled = true;
                bEditMode = false;

                code.addCustomer(tb_Vorname.Text, tb_Name.Text, tb_Strasse.Text, tb_PLZ.Text, tb_Ort.Text);
                tabControl1.TabPages[tabControl1.SelectedIndex].Enabled = true;
            }
        }

        private void offWrite(bool bModus)
        {
            tb_Name.ReadOnly = bModus;
            tb_Vorname.ReadOnly = bModus;
            tb_Strasse.ReadOnly = bModus;
            tb_Ort.ReadOnly = bModus;
            tb_PLZ.ReadOnly = bModus;
            btn_Borrow.Enabled = bModus;
            btn_return.Enabled = bModus;
            cb_BorrowSearch.Enabled = bModus;
            cb_Search.Enabled = bModus;
            cb_WichMedia.Enabled = bModus;
            dgv_Borrowed.Enabled = bModus;
            
            
            
            
            //Ganzer Tab geht dann nicht
            foreach (TabPage tab in tabControl1.TabPages)
            {
                tab.Enabled = bModus;
            }
            tabControl1.TabPages[tabControl1.SelectedIndex].Enabled = !bModus;
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if(tabControl1.SelectedTab.Name != "tab_Customers")
            {
                this.Size = new System.Drawing.Size(this.Width, 174);
                tabControl1.Height = 174;
            }
            else
            {
                this.Size = new System.Drawing.Size(this.Width, 248);
                tabControl1.Height = 248;
            }
            
        }

        static void Rezise()
        {
            
        }
    }
}
