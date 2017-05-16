using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dateiverwaltung
{
    class EBook : Book
    {

        public EBook(int iPages, string sAutor, string sTitel, string sGenre, DateTime dtRelease) : base(iPages, sAutor, sTitel, sGenre, dtRelease)
        {

        }

        public EBook()
        {

        }
    }
}
