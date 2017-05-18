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

        public EBook(int iID, string sTitel, string sGenre, DateTime dtRelease, bool bLent, int iIDCustomer, DateTime dtLent, int iPages, string sAutor)
        : base(iID, sTitel, sGenre, dtRelease, bLent, iIDCustomer, dtLent, iPages, sAutor) { }

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
            Dictionary["Ausleidatum"] = Convert.ToString(dtLent);
            Dictionary["Seitenzahl"] = Convert.ToString(iPages);
            Dictionary["Autor"] = sAutor;
            return Dictionary;
        }
    }

}

