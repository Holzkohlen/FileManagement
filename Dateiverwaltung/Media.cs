using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dateiverwaltung
{
    abstract class Media
    {
        public string sTitel;
        public byte byID; //automatisch zugewiesen
        public byte byLeihdauer; //in Tagen
    }
}
