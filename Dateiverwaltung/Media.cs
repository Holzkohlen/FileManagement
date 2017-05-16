using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dateiverwaltung
{
    abstract class Media
    {
        protected int iID { get; set; } //automatisch zugewiesen
        protected string sTitel { get; set; }
        protected string sGenre { get; set; }
        protected DateTime dtRelease { get; set; }

        protected bool bLent { get; set; }
        protected int iIDCustomer { get; set; }
        protected DateTime dtLend { get; set; }


        public virtual IDictionary<string, string> read()
        {
            IDictionary<string, string> Dictionary = new Dictionary<string, string>();
            return Dictionary;
        }
    }
}
