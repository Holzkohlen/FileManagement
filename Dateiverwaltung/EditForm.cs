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
        public EditForm(Backend code)
        {
            InitializeComponent();
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
            if (btn_Edit.Text != "Speichern")
            {
                btn_Edit.Text = "Speichern";
            }
            else
            {
                btn_Edit.Text = "Bearbeiten";
            }
            
        }
    }
}
