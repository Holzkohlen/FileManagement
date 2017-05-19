using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dateiverwaltung
{
    public class Customer
    {
        int iID;
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
            iID = 10; //CHANGE THIS => automatische Zuweisung bei Neuerstellung
        }

        public Customer(string sID, string sVorname, string sNachname, string sStrasse, string sPLZ, string sOrt)//Mit ID für Auslesen aus XML-File
        {
            this.sVorname = sVorname;
            this.sNachname = sNachname;
            this.sStrasse = sStrasse;
            this.sPLZ = sPLZ;
            this.sOrt = sOrt;
            bool bCheck = Int32.TryParse(sID, out this.iID);
        }

        public Customer()
        {

        }

        public IDictionary<string,string> read()
        {
            IDictionary<string, string> dict = new Dictionary<string, string>();
            dict["ID"] = Convert.ToString(iID);
            dict["Vorname"] = sVorname;
            dict["Nachname"] = sNachname;
            dict["Strasse"] = sStrasse;
            dict["PLZ"] = sPLZ;
            dict["Ort"] = sOrt;
            return dict;
        }

        #region GetterSetter
        public int ID { get { return iID; } set { iID = value; } }
        public string Vorname { get { return sVorname; } set { sVorname = value; } }
        public string Nachname { get { return sNachname; } set { sNachname = value; } }
        public string Strasse { get { return sStrasse; } set { sStrasse = value; } }
        public string PLZ { get { return sPLZ; } set { sPLZ = value; } }
        public string Ort { get { return sOrt; } set { sOrt = value; } }
        #endregion
    }
}
