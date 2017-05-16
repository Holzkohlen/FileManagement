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
        : base(iLength, sDirector, byAge, sTitel, sGenre, dtRelease) { }

        public BluRay(int iID, int iLength, string sDirector, byte byAge, string sTitel, string sGenre, DateTime dtRelease, DateTime dtLent, bool bLent, int iIDCostumer)
        : base(iID, iLength, sDirector, byAge, sTitel, sGenre, dtRelease, dtLent, bLent, iIDCostumer) { }

        public BluRay() { }

        public override IDictionary<string, string> read()
        {
            IDictionary<string, string> Dictionary = new Dictionary<string, string>();
            Dictionary["Klasse"] = "BluRay";
            Dictionary["ID"] = Convert.ToString(iID);
            Dictionary["Titel"] = sTitel;
            Dictionary["Genre"] = sGenre;
            Dictionary["Release"] = Convert.ToString(dtRelease);
            Dictionary["Ausgeliehen"] = Convert.ToString(bLent);
            Dictionary["Kunden-ID"] = Convert.ToString(iIDCustomer);
            Dictionary["Ausleidatum"] = Convert.ToString(dtLend);
            Dictionary["Länge"] = Convert.ToString(iLength);
            Dictionary["Regisseur"] = sDirector;
            Dictionary["Altersbegrenzung"] = Convert.ToString(byAge);

            return Dictionary;
        }
    }
}