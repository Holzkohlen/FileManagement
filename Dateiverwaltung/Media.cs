using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dateiverwaltung
{
    public abstract class Media
    {
        protected int iID;
        protected string sTitel;
        protected string sGenre;
        protected DateTime dtRelease;
        protected bool bLent;
        protected int iIDCustomer;
        protected DateTime dtLent;
        protected string sKlasse;

        public virtual IDictionary<string, string> read()
        {
            IDictionary<string, string> Dictionary = new Dictionary<string, string>();
            return Dictionary;
        }

        #region Getter/Setter
        public int ID { get { return iID; } set { iID = value; } }
        public string Titel { get { return sTitel; } set { sTitel = value; } }
        public string Genre { get { return sGenre; } set { sGenre = value; } }
        public DateTime Release { get { return dtRelease; } set { dtRelease = value; } }
        public bool Ausgeliehen { get { return bLent; } set { bLent = value; } }
        public int IDCustomer { get { return iIDCustomer; } set { iIDCustomer = value; } }
        public DateTime Ausleihdatum { get { return dtLent; } set { dtLent = value; } }
        public string Klasse { get { return sKlasse; } }

        #endregion
    }
}
