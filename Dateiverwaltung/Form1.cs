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
        AboutForm about;
        string sDatumsformat;
        DataGridView[] aDataGrids;
        string sSearchText;

        public Form1()
        {
            try
            {
                InitializeComponent();
                sSearchText = "Suchen...";
                sDatumsformat = "dd. MMMM yyyy";
                code = new Backend();
                printCustomers();
                printMedia();
                aDataGrids = new DataGridView[] { dgv_Customers, dgv_Books, dgv_CDs, dgv_DVDs, dgv_BluRays, dgv_EBooks };
                tbSearch_AutoComplete();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "ERROR");
            }
        }

        private void tbSearch_AutoComplete()
        {
            try
            {
                AutoCompleteStringCollection col = new AutoCompleteStringCollection();
                foreach (Customer temp in code.CustomerListe)
                {
                    string s = temp.Vorname + " " + temp.Nachname;
                    col.Add(s);
                }
                tb_Search.AutoCompleteCustomSource = col;
            }
            catch(NullReferenceException e)
            {
                //Keine Kunden oder keine customer.xml Datei vorhanden
            }
        }

        public void printCustomers() //Gibt Kunden in Liste aus
        {
            dgv_Customers.Rows.Clear();
            try
            {
                foreach (Customer temp in code.CustomerListe)
                {
                    string[] row = { temp.ID.ToString(), temp.Nachname, temp.Vorname, temp.Strasse, temp.PLZ, temp.Ort };
                    dgv_Customers.Rows.Add(row);
                }
            }
            catch(Exception e)
            {

            }
        }

        public void addCustomer() //Fügt den zuletzt erstellten Kunden der Liste hinzu
        {
            Customer temp = code.CustomerListe[code.CustomerListe.Count - 1];
            string[] row = { temp.ID.ToString(), temp.Nachname, temp.Vorname, temp.Strasse, temp.PLZ, temp.Ort };
            dgv_Customers.Rows.Add(row);
        }

        public void updateMedienAnzeige() //Fügt das zuletzt erstellte Medium der jeweiligen Liste hinzu
        {
            string[] row;
            int i = code.MedienListe.Count - 1;
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
            if (tb_Search.Text.Equals(sSearchText))
            {
                tb_Search.Text = "";
                tb_Search.ForeColor = Color.Black;
            }
        }

        private void btn_Edit_Click(object sender, EventArgs e) //öffnet zweite Forms zum Bearbeiten von Objekten
        {
            edit = new EditForm(code, this);
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

        private void tb_Search_TextChanged(object sender, EventArgs e) //Suchalgorithmus
        {
            try
            {
                int iRow = -1;
                String sSearch = tb_Search.Text.ToUpper();
                int iTabIndex; //0:Kunde 1:Buch 2:Cd 3:DVD 4:BluRay 5:EBook


                //tabControl1.SelectedTab == tabControl1.TabPages["Kunden"]? iTabIndex = 0:
                switch (tabControl1.SelectedTab.Name)
                {
                    case "tab_Customers": iTabIndex = 0; break;
                    case "tab_Books": iTabIndex = 1; break;
                    case "tab_CDs": iTabIndex = 2; break;
                    case "tab_DVDs": iTabIndex = 3; break;
                    case "tab_BluRays": iTabIndex = 4; break;
                    default: iTabIndex = 5; break;
                }

                aDataGrids[iTabIndex].ClearSelection();

                if ((sSearch != null) && (sSearch != "") && (tb_Search.Text != sSearchText))
                {
                    foreach (DataGridViewRow row in aDataGrids[iTabIndex].Rows)
                    {
                        for (int i = 0; i < aDataGrids[iTabIndex].Columns.Count; i++)
                        {
                            if (row.Cells[i].Value.ToString().ToUpper().Equals(sSearch))
                            {
                                iRow = row.Index;
                                break;
                            }
                            else if (row.Cells[i].Value.ToString().ToUpper().Contains(sSearch) && iRow == -1)
                            {
                                iRow = row.Index;
                            }
                        }
                    }
                    //if nothing found set color red
                    if (iRow == -1)
                    {
                        tb_Search.BackColor = Color.Red;
                    }
                    //if found set color white, select the row and go to the row
                    else
                    {
                        tb_Search.BackColor = Color.White;
                        aDataGrids[iTabIndex].Rows[iRow].Selected = true;
                        aDataGrids[iTabIndex].FirstDisplayedScrollingRowIndex = iRow;
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString(), "ERROR");
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e) //Reset Search-Feld bei Tab-Wechsel
        {
            tb_Search.Text = sSearchText;
            tb_Search.ForeColor = Color.DimGray;
        }

        private void tb_Search_Leave(object sender, EventArgs e) //Wenn Searchbox nicht mehr aktives Element is => RESET
        {
            if(tb_Search.Text.Equals(""))
            {
                tb_Search.Text = sSearchText;
                tb_Search.ForeColor = Color.DimGray;
            }
        }

        private void speichernToolStripMenuItem_Click(object sender, EventArgs e)
        {
            code.saveAll();
        }

        private void beendenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void überToolStripMenuItem_Click(object sender, EventArgs e)
        {
            about = new AboutForm();
            about.Show();
        }
    }
}
