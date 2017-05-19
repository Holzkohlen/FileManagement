using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dateiverwaltung
{
    class CD : Media
    {
        private int iLength;  //in Minuten
        private string sInterpret;

        public int Length { get { return iLength; } }
        public string Interpret { get { return sInterpret; } }

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
        public CD(int iID, int iLength, string sInterpret, string sTitel, string sGenre, DateTime dtRelease, DateTime dtLent, bool bLent, int iIDCustomer)
        {
            this.iLength = iLength;
            this.sInterpret = sInterpret;
            this.sTitel = sTitel;
            this.sGenre = sGenre;
            this.dtRelease = dtRelease;
            this.dtLent = dtLent;
            this.bLent = bLent;
            this.iIDCustomer = iIDCustomer;
        }

        public CD(string sID, string sLength, string sInterpret, string sTitel, string sGenre, string sdtRelease, string sdtLent,string sbLent, string sIDCustomer)
        {
            this.iLength = Int32.Parse(sID);
            this.sInterpret = sInterpret;
            this.sTitel = sTitel;
            this.sGenre = sGenre;
            this.dtRelease = DateTime.Parse(sdtRelease);
            this.dtLent = DateTime.Parse(sdtLent);
            this.bLent = (sbLent == "True") ? true : false;
            this.iIDCustomer = Int32.Parse(sIDCustomer);
        }

        public CD(){ }

        public override IDictionary<string, string> read()
        {
            IDictionary<string, string> Dictionary = new Dictionary<string, string>();
            Dictionary["Klasse"] = "CD";
            Dictionary["ID"] = Convert.ToString(iID);
            Dictionary["Titel"] = sTitel;
            Dictionary["Genre"] = sGenre;
            Dictionary["Release"] = Convert.ToString(dtRelease);
            Dictionary["Ausgeliehen"] = Convert.ToString(bLent);
            Dictionary["Kunden-ID"] = Convert.ToString(iIDCustomer);
            Dictionary["Ausleidatum"] = Convert.ToString(dtLent);

            Dictionary["Länge"] = Convert.ToString(iLength);
            Dictionary["Interpret"] = sInterpret;

            return Dictionary;
        }

    }
}
