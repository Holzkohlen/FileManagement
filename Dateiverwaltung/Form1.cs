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
        EditForm edit;

        public Form1()
        {
            InitializeComponent();
            code = new Backend();
            printCustomers();
            printBooks();
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

        private void printBooks()
        {
            try
            {
                foreach(Book temp in code.Books)
                {
                    string[] row = { temp.ID.ToString(), temp.Titel, temp.Autor, temp.Genre };
                    dataGridView2.Rows.Add(row);
                }
            }
            catch(Exception e)
            {
                MessageBox.Show(e.ToString(), "ERROR");
            }
        }

        private void tb_Search_Click(object sender, EventArgs e)
        {
            if(tb_Search.Text.Equals("Suchen"))
            {
                tb_Search.Text = "";
                tb_Search.ForeColor = Color.Black;
            }
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            edit = new EditForm();
            edit.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            code.test();
        }



        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            var closeMsg = MessageBox.Show("Möchten sie Speichern?", "Sie gehen?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

            if (closeMsg == DialogResult.Yes)
            { 
                //SPEICHERN
            }
            else if (closeMsg == DialogResult.No)
            {
                //NICHT SPEICHERN
            }
            else {
                //Abbrechen
                e.Cancel = true;
            }
        }

    }
}
