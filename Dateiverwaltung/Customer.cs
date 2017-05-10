using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dateiverwaltung
{
    class Customer
    {
        byte byID;
        string sVorname;
        string sNachname;
        string sStrasse;
        string sPLZ;
        string sOrt;

        public Customer(string sVorname, string sNachname, string sStrasse, string sPLZ, string sOrt)//Ohne ID für Neuerstellung
        {
            this.sVorname = sVorname;
            this.sNachname = sNachname;
            this.sStrasse = sStrasse;
            this.sPLZ = sPLZ;
            this.sOrt = sOrt;
            byID = 10; //CHANGE THIS
        }

        public Customer(string sID, string sVorname, string sNachname, string sStrasse, string sPLZ, string sOrt)//Mit ID für Auslesen aus XML-File
        {
            this.sVorname = sVorname;
            this.sNachname = sNachname;
            this.sStrasse = sStrasse;
            this.sPLZ = sPLZ;
            this.sOrt = sOrt;
            bool bCheck = Byte.TryParse(sID, out this.byID);
        }

        public Customer()
        {

        }

        #region Getter
        public byte ID { get { return byID; } set { byID = value; } }
        public string Vorname { get { return sVorname; } set { sVorname = value; } }
        public string Nachname { get { return sNachname; } set { sNachname = value; } }
        public string Strasse { get { return sStrasse; } set { sStrasse = value; } }
        public string PLZ { get { return sPLZ; } set { sPLZ = value; } }
        public string Ort { get { return sOrt; } set { sOrt = value; } }
        #endregion
    }
}
