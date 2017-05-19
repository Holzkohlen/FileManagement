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
        string sDatumsformat;

        public Form1()
        {
            try
            {
                InitializeComponent();
                sDatumsformat = "dd. MMMM yyyy";
                code = new Backend();
                printCustomers();
                printMedia();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "ERROR");
            }
        }

        private void printCustomers()
        {
            foreach (Customer temp in code.CustomerListe)
            {
                string[] row = { temp.ID.ToString(), temp.Nachname, temp.Vorname, temp.Strasse, temp.PLZ, temp.Ort };
                dgv_Customers.Rows.Add(row);
            }
        }

        private void printMedia() //Gibt Medien-Objekte in der jeweiligen DataGridView aus
        {
            string[] row;
            for (int i = 0; i < code.MedienListe.Count; i++)
            {
                switch (code.MedienListe[i].Klasse)
                {
                    case "Book":
                        Book tempBook = (Book)code.MedienListe[i];
                        row = new string[5] { Convert.ToString(tempBook.ID), tempBook.Titel, tempBook.Autor, tempBook.Genre, tempBook.Release.ToString(sDatumsformat) };
                        dgv_Books.Rows.Add(row);
                        break;
                    case "EBook":
                        EBook tempEBook = (EBook)code.MedienListe[i];
                        row = new string[5] { Convert.ToString(tempEBook.ID), tempEBook.Titel, tempEBook.Autor, tempEBook.Genre, tempEBook.Release.ToString(sDatumsformat) };
                        dgv_EBooks.Rows.Add(row);
                        break;
                    case "CD": //ID Titel Interpret Genre Release
                        CD tempCD = (CD)code.MedienListe[i];
                        row = new string[5] { Convert.ToString(tempCD.ID), tempCD.Titel, tempCD.Interpret, tempCD.Genre, tempCD.Release.ToString(sDatumsformat) };
                        dgv_CDs.Rows.Add(row);
                        break;
                    case "DVD": //ID Titel Regisseur Länge Genre FSK Release
                        DVD tempDVD = (DVD)code.MedienListe[i];
                        row = new string[7] { Convert.ToString(tempDVD.ID), tempDVD.Titel, tempDVD.Director, Convert.ToString(tempDVD.Length), tempDVD.Genre, Convert.ToString(tempDVD.Age), tempDVD.Release.ToString(sDatumsformat) };
                        dgv_DVDs.Rows.Add(row);
                        break;
                    case "BluRay":
                        BluRay tempBluRay = (BluRay)code.MedienListe[i];
                        row = new string[7] { Convert.ToString(tempBluRay.ID), tempBluRay.Titel, tempBluRay.Director, Convert.ToString(tempBluRay.Length), tempBluRay.Genre, Convert.ToString(tempBluRay.Age), tempBluRay.Release.ToString(sDatumsformat) };
                        dgv_BluRays.Rows.Add(row);
                        break;
                }
            }
        }

        private void tb_Search_Click(object sender, EventArgs e)
        {
            if (tb_Search.Text.Equals("Suchen"))
            {
                tb_Search.Text = "";
                tb_Search.ForeColor = Color.Black;
            }
        }

        private void btn_Edit_Click(object sender, EventArgs e) //öffnet zweite Forms zum Bearbeiten von Objekten
        {
            edit = new EditForm(code);
            edit.Show();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e) //Zeigt beim Schließen abfrage, ob gespeichert werden soll
        {
            var closeMsg = MessageBox.Show("Möchten sie Speichern?", "Sie gehen?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

            if (closeMsg == DialogResult.Yes) //SPEICHERN
            {
                code.saveAll();
            }
            else if (closeMsg == DialogResult.No) //NICHT SPEICHERN
            {
                //NICHT SPEICHERN
            }
            else //Abbrechen
            {                
                e.Cancel = true;
            }
        }

        #region Keep for now, Delete before abgabe
        private void button1_Click(object sender, EventArgs e)
        {
            code.test();
        }
        #endregion
    }
}
