﻿using System;
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
        public int ID { get { return iID; } }
        public string Titel { get { return sTitel; } }
        public string Genre { get { return sGenre; } }
        public DateTime Release { get { return dtRelease; } }
        public bool Ausgeliehen { get { return bLent; } }
        public int IDCustomer { get { return iIDCustomer; } }
        public DateTime Ausleihdatum { get { return dtLent; } }
        public string Klasse { get { return sKlasse; } }

        #endregion
    }
}
