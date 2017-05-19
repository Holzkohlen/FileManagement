using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dateiverwaltung
{
    class BluRay : DVD
    {

        public BluRay(int iLength, string sDirector, byte byAge, string sTitel, string sGenre, DateTime dtRelease)
        : base(iLength, sDirector, byAge, sTitel, sGenre, dtRelease) { this.sKlasse = "BluRay"; }

        public BluRay(int iID, int iLength, string sDirector, byte byAge, string sTitel, string sGenre, DateTime dtRelease, DateTime dtLent, bool bLent, int iIDCostumer)
        : base(iID, iLength, sDirector, byAge, sTitel, sGenre, dtRelease, dtLent, bLent, iIDCostumer) { this.sKlasse = "BluRay"; }

        public BluRay(string iID, string sTitel, string sGenre, string dtRelease, string bLent, string iIDCustomer, string dtLent, string iLength, string sDirector, string byAge)
        {
            this.iID = Int32.Parse(iID);
            this.iLength = Int32.Parse(iLength);
            this.sDirector = sDirector;
            this.byAge = Byte.Parse(byAge);
            this.sTitel = sTitel;
            this.sGenre = sGenre;
            this.dtRelease = DateTime.Parse(dtRelease);
            this.dtLent = DateTime.Parse(dtLent);
            this.bLent = (bLent == "True") ? true : false;
            this.iIDCustomer = Int32.Parse(iIDCustomer);
        }

        public BluRay() { }

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
            Dictionary["Länge"] = Convert.ToString(iLength);
            Dictionary["Regisseur"] = sDirector;
            Dictionary["Altersbegrenzung"] = Convert.ToString(byAge);

            return Dictionary;
        }
    }
}