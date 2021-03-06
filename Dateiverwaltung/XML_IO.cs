﻿using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Dateiverwaltung
{
    class XML_IO
    {
        const string CUSTOMERS = "customers.xml";
        const string MEDIA = "media.xml";

        private int countElement(string sPath, string sSearchterm) //Durchsucht eine XML-Datei nach einem bestimmten Elementnamen und gibt Anzahl zurück
        {
            int iCounter = 0;
            try
            {
                using (XmlReader reader = XmlReader.Create(sPath))
                {
                    while (!reader.EOF)
                    {
                        if (reader.IsStartElement())
                        {
                            if (reader.Name.Equals(sSearchterm))
                            {
                                iCounter++;
                            }
                        }
                        reader.Read();
                    }
                }
            }
            catch (SystemException e) { System.Windows.Forms.MessageBox.Show(e.ToString(), "ERROR"); }
            return iCounter;
        }

        public void saveMedia(List<Media> media, int iCounter) //Speichert sämtliche Medien ab aus Media-Liste!
        {
            try
            {
                using (XmlWriter writer = XmlWriter.Create(MEDIA))
                {
                    writer.WriteStartDocument();
                    writer.WriteStartElement("Media");
                    writer.WriteElementString("Count", Convert.ToString(iCounter));
                    foreach (Media med in media)
                    {
                        IDictionary<string, string> dict = med.read();
                        writer.WriteStartElement(dict["Klasse"]);
                        foreach (KeyValuePair<string, string> entry in dict)
                        {
                            if (entry.Key != "Klasse")
                            {
                                writer.WriteElementString(entry.Key, entry.Value);
                            }
                        }
                        writer.WriteEndElement();
                    }
                    writer.WriteEndElement();
                    writer.WriteEndDocument();
                }
            }
            catch (Exception e) { System.Windows.Forms.MessageBox.Show(e.ToString(), "ERROR"); }
        }

        public DataSet readMedia() //Liest Media-XML-Datei in DataSet ein
        {
            DataSet ds_Media = new DataSet();
            if (File.Exists(MEDIA))
            {
                ds_Media.ReadXml(MEDIA, XmlReadMode.InferSchema);
            }
            return ds_Media;
        }

        public void saveCustomers(List<Customer> customers, int iCounter) //Kundendaten abspeichern in XML-Datei!
        {
            using (XmlWriter writer = XmlWriter.Create(CUSTOMERS))
            {
                writer.WriteStartDocument();
                writer.WriteStartElement("Customers");
                writer.WriteElementString("Count", Convert.ToString(iCounter));
                foreach (Customer cust in customers)
                {
                    writer.WriteStartElement("Customer");
                    IDictionary<string, string> dict = cust.read();
                    foreach (KeyValuePair<string, string> entry in dict)
                    {
                        writer.WriteElementString(entry.Key, entry.Value);
                    }
                    writer.WriteEndElement();
                }
                writer.WriteEndElement();
                writer.WriteEndDocument();
            }
        }

        public DataSet readCustomers() //Liest Customer-XML-Datei in DataSet ein
        {
            DataSet ds_Customer = new DataSet();
            if (File.Exists(CUSTOMERS))
            {
                ds_Customer.ReadXml(CUSTOMERS, XmlReadMode.InferSchema);
            }
            return ds_Customer;
        }

        public void readCustomers(ref Customer[] customers, ref int iCounter) //Kundendaten auslesen aus XML-Datei!
        {
            if (File.Exists(CUSTOMERS))
            {
                customers = new Customer[countElement(CUSTOMERS, "Customer")];
                for (int j = 0; j < customers.Length; j++)
                {
                    customers[j] = new Customer();
                }
                int i = -1;

                using (XmlReader reader = XmlReader.Create(CUSTOMERS))
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
                            else if (reader.Name == "Count")
                            {
                                iCounter = reader.ReadElementContentAsInt();
                            }
                            else
                            {
                                switch (reader.Name)
                                {
                                    case "ID":
                                        customers[i].ID = Convert.ToInt32(reader.ReadElementContentAsString());
                                        break;
                                    case "Nachname":
                                        customers[i].Nachname = reader.ReadElementContentAsString();
                                        break;
                                    case "Vorname":
                                        customers[i].Vorname = reader.ReadElementContentAsString();
                                        break;
                                    case "Strasse":
                                        customers[i].Strasse = reader.ReadElementContentAsString();
                                        break;
                                    case "PLZ":
                                        customers[i].PLZ = reader.ReadElementContentAsString();
                                        break;
                                    case "Ort":
                                        customers[i].Ort = reader.ReadElementContentAsString();
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
            }
        }
    }
}
