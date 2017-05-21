using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dateiverwaltung
{
    class Book : Media
    {
        protected int iPages;
        protected string sAutor;

        public string Autor { get { return sAutor; } set { sAutor = value; } }
        public int Seitenanzahl { get { return iPages; } set { iPages = value; } }

        //Konstrukor beim Erstellen
        public Book(int iID, string sTitel, string sAutor, string sGenre, int iPages, DateTime dtRelease)
        {
            this.iID = iID;
            this.iPages = iPages;
            this.sAutor = sAutor;
            this.sTitel = sTitel;
            this.sGenre = sGenre;
            this.dtRelease = dtRelease;
            this.sKlasse = "Book";
        }
        public Book() { }

        //Konstruktor für Aulesen XMLDatei
        public Book(int iID, string sTitel, string sGenre, DateTime dtRelease, bool bLent, int iIDCustomer, DateTime dtLent, int iPages, string sAutor)
        {
            this.iID = iID;
            this.iPages = iPages;
            this.sAutor = sAutor;
            this.sTitel = sTitel;
            this.sGenre = sGenre;
            this.dtRelease = dtRelease;
            this.bLent = bLent;
            this.iIDCustomer = iIDCustomer;
            this.dtLent = dtLent;
            this.sKlasse = "Book";
        }

        //ExtraKonstruktor fürs überschaulichere auslesen des DataSets wird Umwandlung der Strings im Konstruktor vorgenommen!
        public Book(string sID, string sTitel, string sGenre, string sRelease, string sBoolLent, string sIDCustomer, string sDTLent, string sPages, string sAutor)
        {
            this.iID = Int32.Parse(sID);
            this.sTitel = sTitel;
            this.sGenre = sGenre;
            this.dtRelease = DateTime.Parse(sRelease);
            this.bLent = (sBoolLent == "False") ? false : true;
            this.iIDCustomer = Int32.Parse(sIDCustomer);
            this.dtLent = DateTime.Parse(sDTLent);
            this.iPages = Int32.Parse(sPages);
            this.sAutor = sAutor;
            this.sKlasse = "Book";
        }

        public override IDictionary<string, string> read()
        {
            IDictionary<string, string> Dictionary = new Dictionary<string, string>();
            Dictionary["Klasse"] = sKlasse;
            Dictionary["ID"] = Convert.ToString(iID);
            Dictionary["Titel"] = sTitel;
            Dictionary["Genre"] = sGenre;
            Dictionary["Release"] = Convert.ToString(dtRelease);
            Dictionary["Ausgeliehen"] = Convert.ToString(bLent);
            Dictionary["Kunden-ID"] = Convert.ToString(iIDCustomer);
            Dictionary["Ausleidatum"] = Convert.ToString(dtLent);
            Dictionary["Seitenzahl"] = Convert.ToString(iPages);
            Dictionary["Autor"] = sAutor;
            return Dictionary;
        }
    }
}
