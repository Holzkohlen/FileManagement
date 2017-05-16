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

        #region Read/Save Media
        public void saveMedia(Media[] media) //Speichert sämtliche Medien ab
        {
            try
            {
                using (XmlWriter writer = XmlWriter.Create(MEDIA))
                {
                    writer.WriteStartDocument();
                    writer.WriteStartElement("Media");
                    writer.WriteElementString("Count", Convert.ToString(media.Length));
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

        public Media[] readMedia()
        {
            string[] sArray;
            int iCount = 0;
            IDictionary<string, string>[] dict;
            Media[] medArray;
            try
            {
                using (XmlReader reader = XmlReader.Create(MEDIA))
                {
                    while (!reader.EOF)
                    {
                        if (reader.IsStartElement())
                        {
                            if (reader.Name.Equals("Count")) { iCount = reader.ReadElementContentAsInt(); }
                            else { reader.Read(); }
                        }
                        else { reader.Read(); }
                    }
                }
            }
            catch (SystemException e) { System.Windows.Forms.MessageBox.Show(e.ToString(), "ERROR"); }
            sArray = new string[iCount];
            medArray = new Media[iCount];
            int iCounter = 0;
            dict = new Dictionary<string, string>[iCount];

            try
            {
                using (XmlReader reader = XmlReader.Create(MEDIA))
                {
                    while (!reader.EOF)
                    {
                        switch (reader.Name)
                        {
                            case "Book":
                                dict[iCounter]["Klasse"] = reader.Name;
                                while (reader.Name != "Book")
                                {
                                    if (reader.IsStartElement())
                                    {
                                        dict[iCounter][reader.Name] = reader.ReadElementContentAsString();
                                    }
                                    else { reader.Read(); }
                                }
                                iCounter++;
                                break;
                            case "EBook":
                                dict[iCounter]["Klasse"] = reader.Name;
                                while (reader.Name != "EBook")
                                {
                                    if (reader.IsStartElement())
                                    {
                                        dict[iCounter][reader.Name] = reader.ReadElementContentAsString();
                                    }
                                    else { reader.Read(); }
                                }
                                iCounter++;
                                break;
                            case "CD":
                                dict[iCounter]["Klasse"] = reader.Name;
                                while (reader.Name != "CD")
                                {
                                    if (reader.IsStartElement())
                                    {
                                        dict[iCounter][reader.Name] = reader.ReadElementContentAsString();
                                    }
                                    else { reader.Read(); }
                                }
                                iCounter++;
                                break;
                            case "DVD":
                                dict[iCounter]["Klasse"] = reader.Name;
                                while (reader.Name != "DVD")
                                {
                                    if (reader.IsStartElement())
                                    {
                                        dict[iCounter][reader.Name] = reader.ReadElementContentAsString();
                                    }
                                    else { reader.Read(); }
                                }
                                iCounter++;
                                break;
                            case "BluRay":
                                dict[iCounter]["Klasse"] = reader.Name;
                                while (reader.Name != "BluRay")
                                {
                                    if (reader.IsStartElement())
                                    {
                                        dict[iCounter][reader.Name] = reader.ReadElementContentAsString();
                                    }
                                    else { reader.Read(); }
                                }
                                iCounter++;
                                break;
                            default:
                                reader.Read();
                                break;
                        }
                    }
                }
                iCounter = 0;
                for (int i = 0; i < dict.Length; i++)
                {
                    switch (dict[i]["Klasse"])
                    {
                        case "Book":
                            medArray[iCounter] = new Book(Convert.ToInt32(dict[i]["ID"]), Convert.ToInt32(dict[i]["Seitenanzahl"]), dict[i]["Autor"], dict[i]["Titel"], dict[i]["Genre"], DateTime.Parse(dict[i]["Release"]), DateTime.Parse(dict[i]["Ausleihdatum"]), Convert.ToBoolean(dict[i]["Ausgeliehen"]), Convert.ToInt32(dict[i]["Kunden-ID"]));
                            iCounter++;
                            break;
                        case "EBook":
                            break;
                        case "CD":
                            break;
                        case "DVD":
                            break;
                        case "BluRay":
                            break;
                    }
                }
            }
            catch (SystemException e) { System.Windows.Forms.MessageBox.Show(e.ToString(), "ERROR"); }
            return medArray;
        }
        #endregion

        #region Read/Save Customers
        private void saveCustomers(Customer[] customers) //Kundendaten abspeichern!
        {
            using (XmlWriter writer = XmlWriter.Create(CUSTOMERS))
            {
                writer.WriteStartDocument();
                writer.WriteStartElement("Customers");
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

        public void readCustomers(out Customer[] customers) //Kundendaten auslesen!
        {
            customers = new Customer[countElement(CUSTOMERS, "Customer")];
            for (int j = 0; j < customers.Length; j++)
            {
                customers[j] = new Customer();
            }
            int i = -1;

            // Create an XML reader for this file.
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
        #endregion
    }
}
