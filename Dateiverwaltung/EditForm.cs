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
        public EditForm()
        {
            InitializeComponent();
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
            if (btn_Edit.Text != "Speichern")
            {
                btn_Edit.Text = "Speichern";
                tb_Name.ReadOnly = false;     
                tb_Vorname.ReadOnly = false;
                tb_Strasse.ReadOnly = false;
                tb_Ort.ReadOnly = false;
                tb_PLZ.ReadOnly = false;
            }
            else
            {
                btn_Edit.Text = "Bearbeiten";
                tb_Name.ReadOnly = true;
                tb_Vorname.ReadOnly = true;
                tb_Strasse.ReadOnly = true;
                tb_Ort.ReadOnly = true;
                tb_PLZ.ReadOnly = true;
            }
            
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
