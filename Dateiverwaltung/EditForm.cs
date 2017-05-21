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
        bool bEditMode;  // <<== LÖSCHEN?!?
        Form1 mainForm;
        string sSearchtext;
        int iCustomerIndex;
        int iMedienIndex;

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

        private void fillComboBox() //Befüllt die Vorschläge der ComboBoxen
        {
            try
            {
                cb_Search.Items.Clear();
                foreach (Customer temp in code.CustomerListe)
                {
                    string s = temp.Nachname + ", " + temp.Vorname;
                    cb_Search.Items.Add(s);
                }
                cb_Search_Book.Items.Clear();
                cb_Search_EBook.Items.Clear();
                cb_Search_CD.Items.Clear();
                cb_Search_DVD.Items.Clear();
                cb_Search_BluRay.Items.Clear();
                foreach (Media temp in code.MedienListe)
                {
                    switch (temp.Klasse)
                    {
                        case "Book":
                            cb_Search_Book.Items.Add(temp.Titel);
                            break;
                        case "EBook":
                            cb_Search_EBook.Items.Add(temp.Titel);
                            break;
                        case "CD":
                            cb_Search_CD.Items.Add(temp.Titel);
                            break;
                        case "DVD":
                            cb_Search_DVD.Items.Add(temp.Titel);
                            break;
                        case "BluRay":
                            cb_Search_BluRay.Items.Add(temp.Titel);
                            break;
                    }
                }
            }
            catch (NullReferenceException e)
            {
                //Keine Kunden oder keine customer.xml Datei vorhanden
            }
        }

        private void clearTextboxen() //Löscht Inhalt aller Textboxen
        {
            TextBox[] tbs = { tb_Name, tb_Vorname, tb_PLZ, tb_Strasse, tb_Ort, tb_Book_Autor, tb_BluRay_Titel, tb_Book_Genre, tb_EBook_Autor, tb_EBook_Genre, tb_EBook_Titel, tb_CD_Genre, tb_CD_Interpret, tb_CD_Titel, tb_DVD_Director, tb_DVD_Genre, tb_DVD_Titel, tb_BluRay_Director, tb_BluRay_Genre, tb_BluRay_Titel };
            for (int i = 0; i < tbs.Length; i++)
            {
                tbs[i].Text = "";
            }
            fillComboBox(); //Nach Erstellung eines neuen Objektes, sollen die ComboBoxen Vorschläge neu eingelesen werden
        }

        private void btn_Edit_Click(object sender, EventArgs e) //Kunde bearbeiten
        {
            if (btn_EditCostumer.Text != "Übernehmen")
            {
                btn_EditCostumer.Text = "Übernehmen";
                offWrite(false);
                btn_AddCostumer.Enabled = true;
                btn_AddCostumer.Text = "Löschen";
                bEditMode = true;
            }
            else
            {
                btn_AddCostumer.Text = "Hinzufügen";
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

        private void btn_add_Click(object sender, EventArgs e) //Kunde hinzufügen/bearbeiten/löschen
        {
            if (btn_AddCostumer.Text == "Hinzufügen") //Hinzufügen
            {
                clearTextboxen();
                cb_Search.Text = sSearchtext;
                btn_AddCostumer.Text = "Speichern";
                offWrite(false);
                btn_EditCostumer.Enabled = false;
                bEditMode = true;

            }
            else if (btn_AddCostumer.Text == "Löschen")
            {
                var closeMsg = MessageBox.Show("Sind Sie sicher, dass Sie '" + code.CustomerListe[iCustomerIndex].Vorname + " " + code.CustomerListe[iCustomerIndex].Nachname + "' löschen wollen?", "Warnung", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (closeMsg == DialogResult.Yes) //LÖSCHEN
                {
                    code.CustomerListe.RemoveAt(iCustomerIndex);
                    clearTextboxen();
                    fillComboBox();
                    mainForm.printCustomers();
                    btn_AddCostumer.Text = "Hinzufügen";
                    cb_Search.Enabled = true;
                    cb_Search.Text = sSearchtext;
                }
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
            lockAllTabs(bModus);
        }

        private void lockAllTabs(bool bModus)
        {

            //Ganzer Tab geht dann nicht
            foreach (TabPage tab in tabControl.TabPages)
            {
                tab.Enabled = bModus;
            }
            tabControl.TabPages[tabControl.SelectedIndex].Enabled = !bModus;
        }

        static void Rezise()
        {

        } // <<== LÖSCHEN

        private void btn_Add_Media_Click(object sender, EventArgs e) //Medien hinzufügen Button Event Handler
        {
            Button b = (Button)sender;
            string[] sArray;
            bool bCheck = false;
            if (b.Text == "Löschen")
            {
                var closeMsg = MessageBox.Show("Sind Sie sicher, dass Sie '" + code.MedienListe[iMedienIndex] + "' löschen wollen?", "Warnung", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (closeMsg == DialogResult.Yes) //LÖSCHEN
                {
                    code.MedienListe.RemoveAt(iMedienIndex);
                    clearTextboxen();
                    fillComboBox();
                    mainForm.printMedia();
                    Button[] btns = { btn_Add_Book, btn_Add_EBook, btn_Add_CD, btn_Add_DVD, btn_Add_BluRay };
                    for (int i = 0; i < btns.Length; i++)
                    {
                        btns[i].Text = "Hinzufügen";
                    }
                }
            }
            else
            {
                switch (tabControl.SelectedIndex)
                {
                    case 1: //BOOK
                        sArray = new string[5] { tb_Book_Titel.Text, tb_Book_Autor.Text, tb_Book_Genre.Text, num_Book_Pages.Text, dtp_Book_Release.Value.ToString() };
                        bCheck = code.addMedia(sArray, tabControl.SelectedIndex);
                        break;
                    case 2: //EBOOK
                        sArray = new string[5] { tb_EBook_Titel.Text, tb_EBook_Autor.Text, tb_EBook_Genre.Text, num_EBook_Pages.Value.ToString(), dtp_EBook_Release.Value.ToString() };
                        bCheck = code.addMedia(sArray, tabControl.SelectedIndex);
                        break;
                    case 3: //CD
                        sArray = new string[5] { tb_CD_Titel.Text, tb_CD_Interpret.Text, tb_CD_Genre.Text, num_CD_Length.Value.ToString(), dtp_CD_Release.Value.ToString() };
                        bCheck = code.addMedia(sArray, tabControl.SelectedIndex);
                        break;
                    case 4: //DVD
                        sArray = new string[6] { tb_DVD_Titel.Text, tb_DVD_Director.Text, tb_DVD_Genre.Text, num_DVD_Length.Text, cb_DVD_FSK.Text, dtp_DVD_Release.Value.ToString() };
                        bCheck = code.addMedia(sArray, tabControl.SelectedIndex);
                        break;
                    case 5: //BLURAY
                        sArray = new string[6] { tb_BluRay_Titel.Text, tb_BluRay_Director.Text, tb_BluRay_Genre.Text, num_BluRay_Length.Value.ToString(), cb_BluRay_FSK.Text, dtp_BluRay_Release.Text };
                        bCheck = code.addMedia(sArray, tabControl.SelectedIndex);
                        break;
                }
                if (bCheck)
                {
                    clearTextboxen();
                    mainForm.printMedia();
                }
                else
                {
                    MessageBox.Show("Medium konnte nicht erfolgreich erstellt werden.\n Bitte überprüfen Sie Ihre Angaben", "Fehler");
                }
            }
        }

        private void btn_Edit_Media_Click(object sender, EventArgs e) //EventHandler fürs Bearbeiten von Medien-Objekten
        {
            try
            {
                Button b = (Button)sender;
                if (b.Text == "Bearbeiten")
                {
                    b.Text = "Übernehmen";
                    lockAllTabs(false);
                    Button[] btns = { btn_Add_Book, btn_Add_EBook, btn_Add_CD, btn_Add_DVD, btn_Add_BluRay };
                    for (int i = 0; i < btns.Length; i++)
                    {
                        btns[i].Text = "Löschen";
                    }
                    //Input-Boxen entsperren oder nicht ReadOnly machen
                }
                else if (b.Text == "Übernehmen")//Übernehmen
                {
                    Button[] btns = { btn_Add_Book, btn_Add_EBook, btn_Add_CD, btn_Add_DVD, btn_Add_BluRay };
                    for (int i = 0; i < btns.Length; i++)
                    {
                        btns[i].Text = "Hinzufügen";
                    }
                    b.Text = "Bearbeiten";
                    lockAllTabs(true);
                    tabControl.TabPages[tabControl.SelectedIndex].Enabled = true;
                    switch (tabControl.SelectedIndex)
                    {
                        case 1: //Book
                            Book tempBook = (Book)code.MedienListe[iMedienIndex];
                            tempBook.Titel = tb_Book_Titel.Text;
                            tempBook.Autor = tb_Book_Autor.Text;
                            tempBook.Genre = tb_Book_Genre.Text;
                            tempBook.Seitenanzahl = Int32.Parse(num_Book_Pages.Text);
                            tempBook.Release = dtp_Book_Release.Value;
                            btn_Edit_Book.Enabled = false;
                            break;
                        case 2: //EBook
                            EBook tempEBook = (EBook)code.MedienListe[iMedienIndex];
                            tempEBook.Titel = tb_EBook_Titel.Text;
                            tempEBook.Autor = tb_EBook_Autor.Text;
                            tempEBook.Genre = tb_EBook_Genre.Text;
                            tempEBook.Seitenanzahl = Int32.Parse(num_EBook_Pages.Text);
                            tempEBook.Release = dtp_EBook_Release.Value;
                            btn_Edit_EBook.Enabled = false;
                            break;
                        case 3: //CD
                            CD tempCD = (CD)code.MedienListe[iMedienIndex];
                            tempCD.Titel = tb_CD_Titel.Text;
                            tempCD.Genre = tb_CD_Genre.Text;
                            tempCD.Interpret = tb_CD_Interpret.Text;
                            tempCD.Length = Int32.Parse(num_CD_Length.Text);
                            tempCD.Release = dtp_CD_Release.Value;
                            btn_Edit_CD.Enabled = false;
                            break;
                        case 4: //DVD
                            DVD tempDVD = (DVD)code.MedienListe[iMedienIndex];
                            tempDVD.Titel = tb_DVD_Titel.Text;
                            tempDVD.Director = tb_DVD_Director.Text;
                            tempDVD.Genre = tb_DVD_Genre.Text;
                            tempDVD.Age = Byte.Parse(cb_DVD_FSK.Text);
                            tempDVD.Length = Int32.Parse(num_DVD_Length.Text);
                            tempDVD.Release = dtp_DVD_Release.Value;
                            btn_Edit_DVD.Enabled = false;
                            break;
                        case 5: //BluRay
                            BluRay tempBluRay = (BluRay)code.MedienListe[iMedienIndex];
                            tempBluRay.Titel = tb_BluRay_Titel.Text;
                            tempBluRay.Director = tb_BluRay_Director.Text;
                            tempBluRay.Genre = tb_BluRay_Genre.Text;
                            tempBluRay.Age = Byte.Parse(cb_BluRay_FSK.Text);
                            tempBluRay.Length = Int32.Parse(num_BluRay_Length.Text);
                            tempBluRay.Release = dtp_BluRay_Release.Value;
                            btn_Edit_BluRay.Enabled = false;
                            break;
                    }
                    mainForm.printMedia(); //Hauptform DataGridView aktualisieren
                    fillComboBox(); //ComboBox-Vorschläge aktualisieren
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString(), "ERROR"); }
        }

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
            switch (type)
            {
                case "Buch":
                    foreach (Media temp in code.MedienListe)
                    {
                        if (temp.Klasse.Equals("Book") && (!temp.Ausgeliehen))
                        {
                            cb_LendSearch.Items.Add(temp.Titel);
                        }
                    }
                    break;
                case "EBook":
                    foreach (Media temp in code.MedienListe)
                    {
                        if (temp.Klasse.Equals("EBook") && (!temp.Ausgeliehen))
                        {
                            cb_LendSearch.Items.Add(temp.Titel);
                        }
                    }
                    break;
                case "CD":
                    foreach (Media temp in code.MedienListe)
                    {
                        if (temp.Klasse.Equals("CD") && (!temp.Ausgeliehen))
                        {
                            cb_LendSearch.Items.Add(temp.Titel);
                        }
                    }
                    break;
                case "DVD":
                    foreach (Media temp in code.MedienListe)
                    {
                        if (temp.Klasse.Equals("DVD") && (!temp.Ausgeliehen))
                        {
                            cb_LendSearch.Items.Add(temp.Titel);
                        }
                    }
                    break;
                case "BluRay":
                    foreach (Media temp in code.MedienListe)
                    {
                        if (temp.Klasse.Equals("BluRay") && (!temp.Ausgeliehen))
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
            if (cb.Text.Equals(sSearchtext))
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
            for (int i = 0; i < code.CustomerListe.Count; i++)
            {
                Customer temp = code.CustomerListe[i];
                if ((temp.Nachname.Equals(s[0])) && (temp.Vorname.Equals(s[1]))) //Problem wenn >1 Kunde mit dem gleichen Namen!!!!
                {
                    iCustomerIndex = i;
                    tb_Name.Text = temp.Nachname;
                    tb_Vorname.Text = temp.Vorname;
                    tb_Strasse.Text = temp.Strasse;
                    tb_PLZ.Text = temp.PLZ;
                    tb_Ort.Text = temp.Ort;
                    btn_EditCostumer.Enabled = true;
                    foreach (Media tempMedia in code.MedienListe)
                    {
                        if (tempMedia.IDCustomer == temp.ID)
                        {
                            dgv_Borrowed.Rows.Clear();
                            string[] sArray = { tempMedia.ID.ToString(), tempMedia.Titel, tempMedia.Klasse };
                            dgv_Borrowed.Rows.Add(sArray);
                        }
                    }
                }
            }
        }

        private void searchComboBoxen_SelectedValueChanged(object sender, EventArgs e) //Füllt Textboxen zum Bearbeiten von Objekten
        {
            try
            {
                ComboBox cb = (ComboBox)sender;
                for (int i = 0; i < code.MedienListe.Count; i++)
                {
                    if (code.MedienListe[i].Titel.Equals(cb.Text))
                    {
                        iMedienIndex = i;
                        switch (code.MedienListe[i].Klasse)
                        {
                            case "Book":
                                btn_Edit_Book.Enabled = true;
                                Book tempB = (Book)code.MedienListe[i];
                                tb_Book_Titel.Text = tempB.Titel;
                                tb_Book_Autor.Text = tempB.Autor;
                                tb_Book_Genre.Text = tempB.Genre;
                                num_Book_Pages.Value = tempB.Seitenanzahl;
                                dtp_Book_Release.Value = tempB.Release; //Datum zum Schluss, da bei Fehler vorherige Werte wenigstens passen!                               
                                break;
                            case "EBook":
                                btn_Edit_EBook.Enabled = true;
                                EBook tempE = (EBook)code.MedienListe[i];
                                tb_EBook_Titel.Text = tempE.Titel;
                                tb_EBook_Autor.Text = tempE.Autor;
                                tb_EBook_Genre.Text = tempE.Genre;
                                num_EBook_Pages.Value = tempE.Seitenanzahl;
                                dtp_EBook_Release.Value = tempE.Release; //Datum zum Schluss, da bei Fehler vorherige Werte wenigstens passen!                               
                                break;
                            case "CD":
                                btn_Edit_CD.Enabled = true;
                                CD tempC = (CD)code.MedienListe[i];
                                tb_CD_Titel.Text = tempC.Titel;
                                tb_CD_Interpret.Text = tempC.Interpret;
                                tb_CD_Genre.Text = tempC.Interpret;
                                num_CD_Length.Value = tempC.Length;
                                dtp_CD_Release.Value = tempC.Release; //Datum zum Schluss, da bei Fehler vorherige Werte wenigstens passen!

                                break;
                            case "DVD":
                                btn_Edit_DVD.Enabled = true;
                                DVD tempD = (DVD)code.MedienListe[i];
                                tb_DVD_Titel.Text = tempD.Titel;
                                tb_DVD_Director.Text = tempD.Director;
                                tb_DVD_Genre.Text = tempD.Genre;
                                num_DVD_Length.Value = tempD.Length;
                                cb_DVD_FSK.Text = tempD.Age.ToString();
                                dtp_DVD_Release.Value = tempD.Release;

                                break;
                            case "BluRay":
                                btn_Edit_BluRay.Enabled = true;
                                BluRay tempBlu = (BluRay)code.MedienListe[i];
                                tb_BluRay_Titel.Text = tempBlu.Titel;
                                tb_BluRay_Director.Text = tempBlu.Director;
                                tb_BluRay_Genre.Text = tempBlu.Genre;
                                num_BluRay_Length.Value = tempBlu.Length;
                                cb_BluRay_FSK.Text = tempBlu.Age.ToString();
                                dtp_BluRay_Release.Value = tempBlu.Release;

                                break;
                        }
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString(), "ERROR"); }
        }

        private void btn_Borrow_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < code.MedienListe.Count; i++)
            {
                if (code.MedienListe[i].Titel.Equals(cb_LendSearch.Text))
                {
                    code.MedienListe[i].IDCustomer = code.CustomerListe[iCustomerIndex].ID;
                    code.MedienListe[i].Ausgeliehen = true;
                    code.MedienListe[i].Ausleihdatum = DateTime.Today;
                    foreach (Media tempMedia in code.MedienListe)
                    {
                        if (tempMedia.IDCustomer == code.CustomerListe[iCustomerIndex].ID)
                        {
                            dgv_Borrowed.Rows.Clear();
                            string[] sArray = { tempMedia.ID.ToString(), tempMedia.Titel, tempMedia.Klasse };
                            dgv_Borrowed.Rows.Add(sArray);
                        }
                    }
                }
            }
        }
    }
}
