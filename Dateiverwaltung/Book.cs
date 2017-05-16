using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dateiverwaltung
{
    class Book : Media
    {

        int iPages{ get; set; }
        string sAutor { get; set; }

        //Konstrukor beim Erstellen
        public Book(int iPages, string sAutor, string sTitel, string sGenre, DateTime dtRelease)
        {
            this.iPages= iPages;
            this.sAutor = sAutor;
            this.sTitel = sTitel;
            this.sGenre = sGenre;
            this.dtRelease = dtRelease;
        }

        //Konstruktor für Aulesen XMLDatei
        public Book(int iID, int iPages, string sAutor, string sTitel, string sGenre, DateTime dtRelease, DateTime dtLent, bool bLent, int iIDCostumer)
        {
            this.iPages = iPages;
            this.sAutor = sAutor;
            this.sTitel = sTitel;
            this.sGenre = sGenre;
            this.dtRelease = dtRelease;
        }

        public Book()
        {

        }

        public override IDictionary<string, string> read()
        {
            IDictionary<string, string> Dictionary = new Dictionary<string, string>();
            Dictionary["ID"] = Convert.ToString(iID);
            Dictionary["Titel"] = sTitel;
            Dictionary["Genre"] = sGenre;
            Dictionary["Release"] = Convert.ToString(dtRelease);
            Dictionary["Ausgeliehen"] = Convert.ToString(bLent);
            Dictionary["Kunden-ID"] = Convert.ToString(iIDCustomer);
            Dictionary["Ausleidatum"] = Convert.ToString(dtLend);

            Dictionary["Seitenzahl"] = Convert.ToString(iPages);
            Dictionary["Autor"] = sAutor;

            return Dictionary;
        }

    }
}
