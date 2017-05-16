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
        #region FilePaths
        const string CUSTOMERS = "customers.xml";
        const string BOOKS = "books.xml";
        const string EBOOKS = "ebooks.xml";
        const string DVDS = "dvds.xml";
        const string CDS = "cds.xml";
        const string BLURAYS = "blurays.xml";
        const string MEDIA = "media.xml";
        #endregion

        public void saveAll(Customer[] customers, Book[] books, BluRay[] blurays, CD[] cds, DVD[] dvds, EBook[] ebooks) //Wird beim Programmende aufgerufen, um alles abzuspeichern!
        {
            saveCustomers(customers);
            saveBooks(books);
            saveBluRays(blurays);
            saveCDs(cds);
            saveDVDs(dvds);
            saveEBooks(ebooks);
        }

        public void readAll(ref Customer[] customers, ref Book[] books, ref BluRay[] blurays, ref CD[] cds, ref DVD[] dvds, ref EBook[] ebooks) //Wird beim Programmstart aufgerufen, um alles auszulesen!
        {
            readCustomers(out customers);
            //readBooks(out books);
        }

        private int countElement(string sPath, string sSearchterm) //Durchsucht eine XML-Datei nach einem bestimmten Elementnamen
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

        public void saveMedia(Media[] media)
        {
            using (XmlWriter writer = XmlWriter.Create(MEDIA))
            {
                writer.WriteStartDocument();
                writer.WriteStartElement("Media");
                foreach (Media med in media)
                {
                    IDictionary<string, string> dict = med.read();
                    writer.WriteStartElement(dict["Klasse"]);
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

        public void readMedia(ref List<Book> books, ref List<BluRay> blurays, ref List<CD> cds, ref List<DVD> dvds, ref List<EBook> ebooks)
        {
            //books = new Book[countElement(MEDIA, "Book")];
            //blurays = new BluRay[countElement(MEDIA, "BluRay")];
            //cds = new CD[countElement(MEDIA, "CD")];
            //dvds = new DVD[countElement(MEDIA, "DVD")];
            //ebooks = new EBook[countElement(MEDIA, "EBook")];
            Book book = new Book();
            EBook ebook = new EBook();
            BluRay bluray = new BluRay();
            CD cd = new CD();
            DVD dvd = new DVD();
            IDictionary<string, string> dict = new Dictionary<string, string>();

            try
            {
                using (XmlReader reader = XmlReader.Create(MEDIA))
                {
                    while (!reader.EOF)
                    {
                        switch (reader.Name)
                        {
                            case "Book":
                                if (reader.IsStartElement())
                                {
                                    book = new Book();
                                    reader.Read();
                                    //typeof(KLASSE).GetMethod("METHODENNAME").Invoke(OBJEKTNAME, new object[] { "VORNAME" });
                                    while (!reader.Name.Equals("Book"))
                                    {
                                        dict[reader.Name] = reader.ReadElementContentAsString();
                                    }
                                    //typeof(Book).GetMethod("setParameters").Invoke(book, new object[] { dict["Titel"], dict })
                                    books.Add(book);
                                }
                                break;
                            case "EBook":
                                break;
                            case "BluRay":
                                break;
                            case "DVD":
                                break;
                            case "CD":
                                break;
                            default:
                                reader.Read();
                                break;
                        }
                    }
                }
            }
            catch (SystemException e) { System.Windows.Forms.MessageBox.Show(e.ToString(), "ERROR"); }
        }

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
                    IDictionary<string, string> dict = cust.auslesen();
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

        private void readCustomers(out Customer[] customers) //Kundendaten auslesen!
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

        #region Read/Save Books
        private void saveBooks(Book[] books) //Bücherdaten abspeichern!
        {
            using (XmlWriter writer = XmlWriter.Create(BOOKS))
            {
                writer.WriteStartDocument();
                writer.WriteStartElement("Books");
                foreach (Book book in books)
                {
                    //writer.WriteStartElement("Customer");
                    //writer.WriteElementString("ID", cust.ID.ToString());
                    //writer.WriteElementString("Vorname", cust.Vorname);
                    //writer.WriteElementString("Nachname", cust.Nachname);
                    //writer.WriteElementString("Strasse", cust.Strasse);
                    //writer.WriteElementString("PLZ", cust.PLZ);
                    //writer.WriteElementString("Ort", cust.Ort);
                    writer.WriteEndElement();
                }
                writer.WriteEndElement();
                writer.WriteEndDocument();
            }
        }

        private void readBooks(out Book[] books) //Bücherdaten auslesen!
        {
            books = new Book[countElement(BOOKS, "Book")];
            for (int j = 0; j < books.Length; j++)
            {
                books[j] = new Book();
            }
            int i = -1;

            // Create an XML reader for this file.
            using (XmlReader reader = XmlReader.Create(CUSTOMERS))
            {
                while (!reader.EOF)
                {
                    if (reader.IsStartElement())
                    {
                        if (reader.Name == "Book")
                        {
                            i++;
                            reader.Read();
                        }
                        else
                        {
                            switch (reader.Name)
                            {
                                //case "ID":
                                //    customers[i].ID = Convert.ToInt32(reader.ReadElementContentAsString());
                                //    break;
                                //case "Nachname":
                                //    customers[i].Nachname = reader.ReadElementContentAsString();
                                //    break;
                                //case "Vorname":
                                //    customers[i].Vorname = reader.ReadElementContentAsString();
                                //    break;
                                //case "Strasse":
                                //    customers[i].Strasse = reader.ReadElementContentAsString();
                                //    break;
                                //case "PLZ":
                                //    customers[i].PLZ = reader.ReadElementContentAsString();
                                //    break;
                                //case "Ort":
                                //    customers[i].Ort = reader.ReadElementContentAsString();
                                //    break;
                                //default:
                                //    reader.Read();
                                //    break;
                            }
                        }
                    }
                    else { reader.Read(); }
                }
            }
        }
        #endregion

        #region Read/Save EBooks
        private void saveEBooks(EBook[] ebooks) //EBookdaten abspeichern!
        {
            using (XmlWriter writer = XmlWriter.Create(EBOOKS))
            {
                writer.WriteStartDocument();
                writer.WriteStartElement("EBooks");
                foreach (EBook ebook in ebooks)
                {
                    //writer.WriteStartElement("Customer");
                    //writer.WriteElementString("ID", cust.ID.ToString());
                    //writer.WriteElementString("Vorname", cust.Vorname);
                    //writer.WriteElementString("Nachname", cust.Nachname);
                    //writer.WriteElementString("Strasse", cust.Strasse);
                    //writer.WriteElementString("PLZ", cust.PLZ);
                    //writer.WriteElementString("Ort", cust.Ort);
                    writer.WriteEndElement();
                }
                writer.WriteEndElement();
                writer.WriteEndDocument();
            }
        }
        #endregion

        #region Read/Save CDs
        private void saveCDs(CD[] cds) //CD-Daten abspeichern!
        {
            using (XmlWriter writer = XmlWriter.Create(CDS))
            {
                writer.WriteStartDocument();
                writer.WriteStartElement("CDs");
                foreach (CD cd in cds)
                {
                    //writer.WriteStartElement("Customer");
                    //writer.WriteElementString("ID", cust.ID.ToString());
                    //writer.WriteElementString("Vorname", cust.Vorname);
                    //writer.WriteElementString("Nachname", cust.Nachname);
                    //writer.WriteElementString("Strasse", cust.Strasse);
                    //writer.WriteElementString("PLZ", cust.PLZ);
                    //writer.WriteElementString("Ort", cust.Ort);
                    writer.WriteEndElement();
                }
                writer.WriteEndElement();
                writer.WriteEndDocument();
            }
        }
        #endregion

        #region Read/Save DVDs
        private void saveDVDs(DVD[] dvds) //DVD-Daten abspeichern!
        {
            using (XmlWriter writer = XmlWriter.Create(DVDS))
            {
                writer.WriteStartDocument();
                writer.WriteStartElement("DVDs");
                foreach (DVD dvd in dvds)
                {
                    //writer.WriteStartElement("Customer");
                    //writer.WriteElementString("ID", cust.ID.ToString());
                    //writer.WriteElementString("Vorname", cust.Vorname);
                    //writer.WriteElementString("Nachname", cust.Nachname);
                    //writer.WriteElementString("Strasse", cust.Strasse);
                    //writer.WriteElementString("PLZ", cust.PLZ);
                    //writer.WriteElementString("Ort", cust.Ort);
                    writer.WriteEndElement();
                }
                writer.WriteEndElement();
                writer.WriteEndDocument();
            }
        }
        #endregion

        #region Read/Save BluRays
        private void saveBluRays(BluRay[] blurays) //BluRay-Daten abspeichern!
        {
            using (XmlWriter writer = XmlWriter.Create(BLURAYS))
            {
                writer.WriteStartDocument();
                writer.WriteStartElement("BluRays");
                foreach (BluRay bluray in blurays)
                {
                    //writer.WriteStartElement("Customer");
                    //writer.WriteElementString("ID", cust.ID.ToString());
                    //writer.WriteElementString("Vorname", cust.Vorname);
                    //writer.WriteElementString("Nachname", cust.Nachname);
                    //writer.WriteElementString("Strasse", cust.Strasse);
                    //writer.WriteElementString("PLZ", cust.PLZ);
                    //writer.WriteElementString("Ort", cust.Ort);
                    writer.WriteEndElement();
                }
                writer.WriteEndElement();
                writer.WriteEndDocument();
            }
        }
        #endregion
    }
}
