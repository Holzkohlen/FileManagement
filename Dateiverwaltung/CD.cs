using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dateiverwaltung
{
    class CD : Media
    {
        private int iLength { get; set; }  //in Minuten
        private string sInterpret { get; set; }

        //Konstrukor beim Erstellen
        public CD( int iLength, string sInterpret, string sTitel , string sGenre, DateTime dtRelease)
        {
            this.iLength = iLength;
            this.sInterpret = sInterpret;
            this.sTitel = sTitel;
            this.sGenre = sGenre;
            this.dtRelease = dtRelease;
        }

        //Konstruktor für Aulesen XMLDatei
        public CD(int iID, int iLength, string sInterpret, string sTitel, string sGenre, DateTime dtRelease, DateTime dtLent, bool bLent, int iIDCostumer)
        {
            this.iLength = iLength;
            this.sInterpret = sInterpret;
            this.sTitel = sTitel;
            this.sGenre = sGenre;
            this.dtRelease = dtRelease;
        }

        public CD()
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

            Dictionary["Länge"] = Convert.ToString(iLength);
            Dictionary["Interpret"] = sInterpret;

            return Dictionary;
        }

    }
}
