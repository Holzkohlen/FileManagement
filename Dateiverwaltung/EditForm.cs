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
        public EditForm()
        {
            InitializeComponent();
            code = new Backend();
        }
        //public EditForm(Backend code):this()
        //{ }

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
            }
            else
            {
                btn_EditCostumer.Text = "Bearbeiten";
                offWrite(true);
                btn_AddCostumer.Enabled = true;
            }
            
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (btn_AddCostumer.Text != "Speichern")
            {
                btn_AddCostumer.Text = "Speichern";
                offWrite(false);
                btn_EditCostumer.Enabled = false;           

            }
            else
            {
                btn_AddCostumer.Text = "Hinzufügen";
                offWrite(true);
                btn_EditCostumer.Enabled = true;

                code.addCustomer(tb_Vorname.Text, tb_Name.Text, tb_Strasse.Text, tb_PLZ.Text, tb_Ort.Text);
            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

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

        }
    }
}
