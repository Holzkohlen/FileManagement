using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dateiverwaltung
{
    class BluRay : DVD
    {

        public BluRay(int iLength, string sDirector, bool bAge, string sTitel, string sGenre, DateTime dtRelease) :base(iLength, sDirector, bAge, sTitel, sGenre, dtRelease)
        {

        }

        public BluRay()
        {

        }
    }
}
