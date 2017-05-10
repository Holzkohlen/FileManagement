using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace Dateiverwaltung
{
    class Backend
    {
        public void save()//Daten in XML-Dateien abspeichern
        {
            Customer cs1 = new Customer("Daniel", "Kern", "Teststr. 7", "95043", "Frankfurt");
            Customer cs2 = new Customer("Lukas", "Hempel", "Mustergasse 4", "83022", "Bielefeld");
            Customer[] cs = { cs1, cs2 };

            using (XmlWriter writer = XmlWriter.Create("customers.xml"))
            {
                writer.WriteStartDocument();
                writer.WriteStartElement("Customers");

                foreach (Customer cust in cs)
                {
                    writer.WriteStartElement("Customer");

                    writer.WriteElementString("ID", cust.ID.ToString());
                    writer.WriteElementString("Vorname", cust.Vorname);
                    writer.WriteElementString("Nachname", cust.Nachname);
                    writer.WriteElementString("Strasse", cust.Strasse);
                    writer.WriteElementString("PLZ", cust.PLZ);
                    writer.WriteElementString("Ort", cust.Ort);

                    writer.WriteEndElement();
                }

                writer.WriteEndElement();
                writer.WriteEndDocument();
            }
        }

        public Customer[] read()//Daten aus XML-Dateien in Programm einlesen
        {
            Customer[] cs = new Customer[2];
            for (int j = 0; j < cs.Length; j++)
            {
                cs[j] = new Customer();
            }
            int i = -1;

            // Create an XML reader for this file.
            using (XmlReader reader = XmlReader.Create("customers.xml"))
            {
                while (reader.Read())
                {
                    if (reader.IsStartElement())
                    {
                        if (reader.Name == "Customer") { i++; }
                        //switch (reader.Name)
                        //{
                        //    case "ID":
                        //        cs[i].ID = Convert.ToByte(reader.ReadElementContentAsString());
                        //        break;
                        //    case "Vorname":
                        //        cs[i].Vorname = reader.ReadContentAsString();
                        //        break;
                        //    case "Nachname":
                        //        cs[i].Nachname = reader.ReadElementContentAsString();
                        //        break;
                        //    case "Strasse":
                        //        cs[i].Strasse = reader.ReadElementContentAsString();
                        //        break;
                        //    case "PLZ":
                        //        cs[i].PLZ = reader.ReadElementContentAsString();
                        //        break;
                        //    case "Ort":
                        //        cs[i].Ort = reader.ReadElementContentAsString();
                        //        break;
                        //}
                        if (reader.Name == "ID")
                        {
                            cs[i].ID = Convert.ToByte(reader.ReadElementContentAsString());
                            reader.Read();
                        }
                        if(reader.Name=="Vorname")
                        {
                            cs[i].Vorname = reader.ReadElementContentAsString();
                            reader.Read();
                        }
                        if(reader.Name=="Nachname")
                        {
                            cs[i].Nachname = reader.ReadElementContentAsString();
                            reader.Read();
                        }
                    }
                }
            }
            return cs;
        }
    }
}
