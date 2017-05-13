using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dateiverwaltung
{
    class Book : Media
    {
        string sAutor;

        public Book(string sTitel, string sAutor)
        {
            this.sTitel = sTitel;
            this.sAutor = sAutor;
        }

        public Book()
        {

        }
    }
}
