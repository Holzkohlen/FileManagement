using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dateiverwaltung
{
    class Backend
    {
        XML_IO xml;
        Customer[] customers;
        Book[] books;
        EBook[] ebooks;
        CD[] cds;
        DVD[] dvds;
        BluRay[] blurays;

        #region GetterSetter
        public Customer[] Customers { get { return customers; } }
        public Book[] Books { get { return books; } }
        public EBook[] EBooks { get { return ebooks; } }
        public CD[] CDs { get { return cds; } }
        public DVD[] DVDs { get { return dvds; } }
        public BluRay[] BluRays { get { return blurays; } }
        #endregion

        public Backend()
        {
            xml = new XML_IO();
            xml.readCustomers(out customers);
            Media[] medArray;
            medArray = xml.readMedia();
            books = new Book[medArray.Length];
            for(int i = 0; i < medArray.Length; i++)
            {
                books[i] = (Book)medArray[i];
            }
        }

        public void test()
        {
            books = new Book[3];
            ebooks = new EBook[3];
            cds = new CD[3];
            dvds = new DVD[3];
            blurays = new BluRay[3];
            DateTime dt = new DateTime(1999, 05, 16);

            Media[] medArray = new Media[9];
            medArray[0] = new Book(15, "Stephen King", "Dark Tower", "Fantasy/Horror", dt);
            medArray[1] = new Book(32, "Douglas Adams", "Hitchhikers Guide to the Galaxy", "Fantasy", dt);
            medArray[2] = new Book(10238, "Gustapho Fring", "Los Pollos Hermanos", "Mexico", dt);
            medArray[3] = new EBook(482, "Jules Verne", "Reise zum Mittelpunkt der Erde", "SciFi", dt);
            medArray[4] = new EBook(47, "Edgar Allan Poe", "Der Rabe", "Horror", dt);
            medArray[5] = new EBook(794, "Jesus Christus", "Die Lutherbibel", "Fantasy", dt);
            medArray[6] = new CD(123, "Monstercat", "30 - Finale", "EDM", dt);
            medArray[7] = new CD(34, "JayZ", "It's a hard knock life", "HipHop", dt);
            medArray[8] = new CD(74, "Gustave Le Bon", "Psychologie der Massen", "Buch", dt);
            //medArray[9] = new DVD();
            //medArray[10] = new DVD();
            //medArray[11] = new DVD();
            //medArray[12] = new BluRay();
            //medArray[13] = new BluRay();
            //medArray[14] = new BluRay();

            xml.saveMedia(medArray);
        }
    }
}
