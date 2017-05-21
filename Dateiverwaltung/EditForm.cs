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
        Form1 mainForm;
        string sSearchtext;
        int iCustomerIndex;

        public EditForm(Backend code, Form1 mainForm)
        {
            try
            {
                InitializeComponent();
                sSearchtext = "Suchen...";
                this.code = code;
                bEditMode = false;
                this.mainForm = mainForm;
                fillComboBox();

                btn_EditCostumer.Enabled = false; //Erst muss Kunde gewählt werden
                cb_LendSearch.Enabled = false; //Erst muss Klasse gewählt werden
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "ERROR");
            }
        }

        private void fillComboBox() //Befüllt die Vorschläge der ComboBox mit dem Namen der Kunden
        {
            cb_Search.Items.Clear();
            foreach (Customer temp in code.CustomerListe)
            {
                string s = temp.Nachname + ", " + temp.Vorname;
                cb_Search.Items.Add(s);
            }
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

        private void clearTextboxen() //Löscht Inhalt der Kunden-Textboxen
        {
            TextBox[] tbs = { tb_Name, tb_Vorname, tb_PLZ, tb_Strasse, tb_Ort };
            for(int i = 0; i < tbs.Length; i++)
            {
                tbs[i].Text = "";
            }
        }

        private void btn_Edit_Click(object sender, EventArgs e) //Kunde bearbeiten
        {
            if (btn_EditCostumer.Text != "Übernehmen")
            {
                btn_EditCostumer.Text = "Übernehmen";
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
                tabControl.TabPages[tabControl.SelectedIndex].Enabled = true;

                code.CustomerListe[iCustomerIndex].Nachname = tb_Name.Text;
                code.CustomerListe[iCustomerIndex].Vorname = tb_Vorname.Text;
                code.CustomerListe[iCustomerIndex].Ort = tb_Ort.Text;
                code.CustomerListe[iCustomerIndex].PLZ = tb_PLZ.Text;
                code.CustomerListe[iCustomerIndex].Strasse = tb_Strasse.Text;
                mainForm.printCustomers();
            }
        }

        private void btn_add_Click(object sender, EventArgs e) //Kunde hinzufügen
        {
            if (btn_AddCostumer.Text != "Speichern") //Hinzufügen
            {
                clearTextboxen();
                cb_Search.Text = sSearchtext;
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
                clearTextboxen();
                tabControl.TabPages[tabControl.SelectedIndex].Enabled = true;
                mainForm.addCustomer();
                fillComboBox();
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
            cb_LendSearch.Enabled = bModus;
            cb_Search.Enabled = bModus;
            cb_WichMedia.Enabled = bModus;
            dgv_Borrowed.Enabled = bModus;




            //Ganzer Tab geht dann nicht
            foreach (TabPage tab in tabControl.TabPages)
            {
                tab.Enabled = bModus;
            }
            tabControl.TabPages[tabControl.SelectedIndex].Enabled = !bModus;
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        static void Rezise()
        {

        }

        #region Medien hinzufügen ButtonClick Handler
        private void btn_Add_Book_Click(object sender, EventArgs e)
        {
            string[] sArray = { tb_Book_Titel.Text, tb_Book_Autor.Text, tb_Book_Genre.Text, nud_CD_Length.Text, dtp_CD_Release.Text };
            if (code.addMedia(sArray, 1))
            {
                mainForm.updateMedienAnzeige();
            }
            else
            {
                MessageBox.Show("Medium konnte nicht erfolgreich erstellt werden.\n Bitte überprüfen Sie Ihre Angaben", "Fehler");
            }
        }
        private void btn_Add_EBook_Click(object sender, EventArgs e)
        {
            string[] sArray = { tb_EBook_Titel.Text, tb_EBook_Autor.Text, tb_EBook_Genre.Text, nud_EBook_Seiten.Text, dtp_EBook_Release.Text };
            if (code.addMedia(sArray, 2))
            {
                mainForm.updateMedienAnzeige();
            }
            else
            {
                MessageBox.Show("Medium konnte nicht erfolgreich erstellt werden.\n Bitte überprüfen Sie Ihre Angaben", "Fehler");
            }
        }
        private void btn_Add_DVD_Click(object sender, EventArgs e)
        {
            string[] sArray = { tb_DVD_Titel.Text, tb_DVD_Regisseur.Text, tb_DVD_Genre.Text, nud_EBook_Seiten.Text, tb_DVD_FSK.Text, dtp_EBook_Release.Text };
            if (code.addMedia(sArray, 4))
            {
                mainForm.updateMedienAnzeige();
            }
            else
            {
                MessageBox.Show("Medium konnte nicht erfolgreich erstellt werden.\n Bitte überprüfen Sie Ihre Angaben", "Fehler");
            }
        }
        private void btn_Add_CD_Click(object sender, EventArgs e)
        {
            string[] sArray = { tb_CD_Titel.Text, tb_CD_Interpret.Text, tb_CD_Genre.Text, nud_CD_Length.Text, dtp_CD_Release.Text };
            if (code.addMedia(sArray, 3))
            {
                mainForm.updateMedienAnzeige();
            }
            else
            {
                MessageBox.Show("Medium konnte nicht erfolgreich erstellt werden.\n Bitte überprüfen Sie Ihre Angaben", "Fehler");
            }
        }
        private void btn_Add_BluRay_Click(object sender, EventArgs e)
        {
            string[] sArray = { tb_BluRay_Titel.Text, tb_BluRay_Regisseur.Text, tb_BluRay_Genre.Text, nud_BluRay_Length.Text, tb_BluRay_FSK.Text, dtp_BluRay_Release.Text };
            if (code.addMedia(sArray, 5))
            {
                mainForm.updateMedienAnzeige();
            }
            else
            {
                MessageBox.Show("Medium konnte nicht erfolgreich erstellt werden.\n Bitte überprüfen Sie Ihre Angaben", "Fehler");
            }
        }
        #endregion

        private void tabControl_Selected(object sender, TabControlEventArgs e)
        {
            if (tabControl.SelectedTab == tabControl.TabPages[0])
            {
                this.Size = new System.Drawing.Size(this.Width, 248);
                tabControl.Height = 248;
            }
            else
            {
                tabControl.Height = 174;
                this.Size = new System.Drawing.Size(this.Width, 174);
            } 
        }

        private void cb_WichMedia_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = (ComboBox)sender;
            string type = (string)cb.SelectedItem;
            cb_LendSearch.Enabled = true;
            cb_LendSearch.Items.Clear();
            switch(type)
            {
                case "Buch":
                    foreach(Media temp in code.MedienListe)
                    {
                        if(temp.Klasse.Equals("Book"))
                        {
                            cb_LendSearch.Items.Add(temp.Titel);
                        }
                    }
                    break;
                case "EBook":
                    foreach (Media temp in code.MedienListe)
                    {
                        if (temp.Klasse.Equals("EBook"))
                        {
                            cb_LendSearch.Items.Add(temp.Titel);
                        }
                    }
                    break;
                case "CD":
                    foreach (Media temp in code.MedienListe)
                    {
                        if (temp.Klasse.Equals("CD"))
                        {
                            cb_LendSearch.Items.Add(temp.Titel);
                        }
                    }
                    break;
                case "DVD":
                    foreach (Media temp in code.MedienListe)
                    {
                        if (temp.Klasse.Equals("DVD"))
                        {
                            cb_LendSearch.Items.Add(temp.Titel);
                        }
                    }
                    break;
                case "BluRay":
                    foreach (Media temp in code.MedienListe)
                    {
                        if (temp.Klasse.Equals("BluRay"))
                        {
                            cb_LendSearch.Items.Add(temp.Titel);
                        }
                    }
                    break;
            }
        }

        private void cb_LendSearch_Click(object sender, EventArgs e)
        {
            ComboBox cb = (ComboBox)sender;
            if(cb.Text.Equals(sSearchtext))
            {
                cb.Text = "";
                cb.ForeColor = Color.Black;
            }
        }

        private void cb_Search_SelectedValueChanged(object sender, EventArgs e) //Kunde ausgewählt zum Bearbeiten
        {
            ComboBox cb = (ComboBox)sender;
            string name = (string)cb.SelectedItem;
            string[] s = name.Split(',');
            s[1] = s[1].Trim();
            for(int i = 0; i < code.CustomerListe.Count; i++)
            {
                Customer temp = code.CustomerListe[i];
                if((temp.Nachname.Equals(s[0]))&&(temp.Vorname.Equals(s[1]))) //Problem wenn >1 Kunde mit dem gleichen Namen!!!!
                {
                    iCustomerIndex = i;
                    tb_Name.Text = temp.Nachname;
                    tb_Vorname.Text = temp.Vorname;
                    tb_Strasse.Text = temp.Strasse;
                    tb_PLZ.Text = temp.PLZ;
                    tb_Ort.Text = temp.Ort;
                    btn_EditCostumer.Enabled = true;
                }
            }
        }

        private void btn_Borrow_Click(object sender, EventArgs e)
        {
            string[] sArray = { "Buch", "EBook", "CD", "DVD", "BluRay" };
            for(int i = 0; i < code.MedienListe.Count; i++)
            {
                if(code.MedienListe[i].Titel.Equals(cb_LendSearch.Text))
                {
                    if ((tb_Name.Equals(code.CustomerListe[iCustomerIndex].Nachname)) && (sArray.Contains(cb_WichMedia.Text)))
                    {
                        //LEih shit aus

                    }
                    else
                    {
                        //FEHLER
                    }
                }
            }
        }

        private void cb_LendSearch_SelectedValueChanged(object sender, EventArgs e)
        {
            

        }

        private void label30_Click(object sender, EventArgs e)
        {

        }

        private void tb_BluRay_FSK_TextChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
