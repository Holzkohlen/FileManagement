using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dateiverwaltung
{
    class DVD : Media
    {

        protected int iLength { get; set; }
        protected string sDirector { get; set; }
        protected byte byAge { get; set; }

        //Konstrukor beim Erstellen
        public DVD(int iLength, string sDirector, byte byAge, string sTitel, string sGenre, DateTime dtRelease)
        {
            this.iLength = iLength;
            this.sDirector = sDirector;
            this.byAge = byAge;
            this.sTitel = sTitel;
            this.sGenre = sGenre;
            this.dtRelease = dtRelease;
        }

        //Konstruktor für Aulesen XMLDatei
        public DVD(int iID, int iLength, string sDirector, byte byAge, string sTitel, string sGenre, DateTime dtRelease, DateTime dtLent, bool bLent, int iIDCostumer)
        {
            this.iLength = iLength;
            this.sDirector = sDirector;
            this.byAge = byAge;
            this.sTitel = sTitel;
            this.sGenre = sGenre;
            this.dtRelease = dtRelease;
            this.bLent = bLent;
        }

        public DVD(){ }

        public override IDictionary<string, string> read()
        {
            IDictionary<string, string> Dictionary = new Dictionary<string, string>();
            Dictionary["Klasse"] = "DVD";
            Dictionary["ID"] = Convert.ToString(iID);
            Dictionary["Titel"] = sTitel;
            Dictionary["Genre"] = sGenre;
            Dictionary["Release"] = Convert.ToString(dtRelease);
            Dictionary["Ausgeliehen"] = Convert.ToString(bLent);
            Dictionary["Kunden-ID"] = Convert.ToString(iIDCustomer);
            Dictionary["Ausleidatum"] = Convert.ToString(dtLent);

            Dictionary["Länge"] = Convert.ToString(iLength);
            Dictionary["Regisseur"] = sDirector;
            Dictionary["Altersbegrenzung"] = Convert.ToString(byAge);

            return Dictionary;
        }

    }
}
