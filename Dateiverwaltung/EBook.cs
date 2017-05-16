using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dateiverwaltung
{
    class EBook : Book
    {

        public EBook(int iPages, string sAutor, string sTitel, string sGenre, DateTime dtRelease)
        : base(iPages, sAutor, sTitel, sGenre, dtRelease) { }

        public EBook(int iID, int iPages, string sAutor, string sTitel, string sGenre, DateTime dtRelease, DateTime dtLent, bool bLent, int iIDCostumer)
        : base(iID, iPages, sAutor, sTitel, sGenre, dtRelease, dtLent, bLent, iIDCostumer) { }

        public EBook() { }

        public override IDictionary<string, string> read()
        {
            IDictionary<string, string> Dictionary = new Dictionary<string, string>();
            Dictionary["Klasse"] = "EBook";
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

