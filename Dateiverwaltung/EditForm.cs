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

        public EditForm(Backend code, Form1 mainForm)
        {
            InitializeComponent();
            this.code = code;
            bEditMode = false;
            this.mainForm = mainForm;
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
                tabControl.TabPages[tabControl.SelectedIndex].Enabled = true;
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
                tabControl.TabPages[tabControl.SelectedIndex].Enabled = true;
                mainForm.addCustomer();
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
            foreach (TabPage tab in tabControl.TabPages)
            {
                tab.Enabled = bModus;
            }
            tabControl.TabPages[tabControl.SelectedIndex].Enabled = !bModus;
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if(tabControl.SelectedTab.Name != "tab_Customers")
            {
                this.Size = new System.Drawing.Size(this.Width, 174);
                tabControl.Height = 174;
            }
            else
            {
                this.Size = new System.Drawing.Size(this.Width, 248);
                tabControl.Height = 248;
            }
            
        }

        static void Rezise()
        {
            
        }


        #region Medien hinzufügen ButtonClick Handler
        private void btn_Add_Book_Click(object sender, EventArgs e)
        {
            string[] sArray = { tb_Book_Titel.Text, tb_Book_Autor.Text, tb_Book_Genre.Text, tb_Book_Seiten.Text, tb_Book_Release.Text};
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
            string[] sArray = { tb_EBook_Titel.Text, tb_EBook_Autor.Text, tb_EBook_Genre.Text, tb_EBook_Seiten.Text, tb_EBook_Release.Text };
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
            string[] sArray = { tb_DVD_Titel.Text, tb_DVD_Regisseur.Text, tb_DVD_Genre.Text, tb_DVD_Length.Text, tb_DVD_FSK.Text, tb_DVD_Release.Text };
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
            string[] sArray = { tb_CD_Titel.Text, tb_CD_Interpret.Text, tb_CD_Genre.Text, tb_CD_Length.Text, tb_CD_Release.Text };
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
            string[] sArray = { tb_BluRay_Titel.Text, tb_BluRay_Regisseur.Text, tb_BluRay_Genre.Text, tb_BluRay_Length.Text, tb_BluRay_FSK.Text, tb_BluRay_Release.Text };
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
    }
}
