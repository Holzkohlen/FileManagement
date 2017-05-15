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
    public partial class Form1 : Form
    {
        Backend code;

        public Form1()
        {
            InitializeComponent();
            code = new Backend();
            printCustomers();
        }

        private void printCustomers()
        {
            try
            {
                foreach (Customer temp in code.Customers)
                {
                    string[] row = { temp.ID.ToString(), temp.Nachname, temp.Vorname, temp.Strasse, temp.PLZ, temp.Ort };
                    dataGridView1.Rows.Add(row);
                }
            }
            catch (Exception e)
            { MessageBox.Show(e.ToString(), "ERROR"); }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            code.zeug();
        }
    }
}
