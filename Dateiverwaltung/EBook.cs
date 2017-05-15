using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dateiverwaltung
{
    class EBook : Media
    {
        string sAutor;

        public EBook(string sTitel, string sAutor)
        {
            this.sTitel = sTitel;
            this.sAutor = sAutor;
        }

        public EBook()
        {

        }
    }
}
