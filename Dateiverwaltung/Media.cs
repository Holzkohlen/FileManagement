using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dateiverwaltung
{
    abstract class Media
    {
        protected int iID;
        protected string sTitel;
        protected string sGenre;
        protected DateTime dtRelease;
        protected bool bLent;
        protected int iIDCustomer;
        protected DateTime dtLend;

        public virtual IDictionary<string, string> read()
        {
            IDictionary<string, string> Dictionary = new Dictionary<string, string>();
            return Dictionary;
        }

        #region Getter/Setter
        public int ID { get { return iID; } }
        public string Titel { get { return sTitel; } }
        public string Genre { get { return sGenre; } }
        public DateTime Release { get { return dtRelease; } }
        public bool Ausgeliehen { get { return bLent; } }
        public int IDCustomer { get { return iIDCustomer; } }
        public DateTime Ausleihdatum { get { return dtLend; } }

        #endregion
    }
}
