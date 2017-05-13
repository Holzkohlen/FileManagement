using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dateiverwaltung
{
    abstract class Media
    {
        protected string sTitel;
        protected int iID; //automatisch zugewiesen
        protected int iIDCustomer;
        protected bool bAusgeliehen;
        protected string sGenre;

        virtual protected void auslesen() { }
    }
}
