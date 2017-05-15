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
            xml.readAll(ref customers, ref books, ref blurays, ref cds, ref dvds, ref ebooks);
        }

        public void zeug()
        {
            xml.saveObjectArray(customers);
        }
    }
}
