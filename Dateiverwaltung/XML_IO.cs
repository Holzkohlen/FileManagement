using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Dateiverwaltung
{
    class XML_IO
    {
        public void saveAll(Customer[] customers, Book[] books, BluRay[] blurays, CD[] cds, DVD[] dvds, EBook[] ebooks) //Wird beim Programmende aufgerufen, um alles abzuspeichern!
        {
            saveCustomers(customers);
        }

        public void readAll(Customer[] customers, Book[] books, BluRay[] blurays, CD[] cds, DVD[] dvds, EBook[] ebooks) //Wird beim Programmstart aufgerufen, um alles auszulesen!
        {

        }

        public void saveCustomers(Customer[] customers) //Kundendaten abspeichern!
        {
            using (XmlWriter writer = XmlWriter.Create("customers.xml"))
            {
                writer.WriteStartDocument();
                writer.WriteStartElement("Customers");

                foreach (Customer cust in customers)
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

        public Customer[] readCustomers() //Kundendaten auslesen!
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
                while (!reader.EOF)
                {
                    if (reader.IsStartElement())
                    {
                        if (reader.Name == "Customer")
                        {
                            i++;
                            reader.Read();
                        }
                        else
                        {
                            switch (reader.Name)
                            {
                                case "ID":
                                    cs[i].ID = Convert.ToByte(reader.ReadElementContentAsString());
                                    break;
                                case "Nachname":
                                    cs[i].Nachname = reader.ReadElementContentAsString();
                                    break;
                                case "Vorname":
                                    cs[i].Vorname = reader.ReadElementContentAsString();
                                    break;
                                case "Strasse":
                                    cs[i].Strasse = reader.ReadElementContentAsString();
                                    break;
                                case "PLZ":
                                    cs[i].PLZ = reader.ReadElementContentAsString();
                                    break;
                                case "Ort":
                                    cs[i].Ort = reader.ReadElementContentAsString();
                                    break;
                                default:
                                    reader.Read();
                                    break;
                            }
                        }
                    }
                    else { reader.Read(); }
                }
            }
            return cs;
        }
    }
}
