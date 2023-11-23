using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace XML
{
    static class LinqXML
    {
        public static void CreateXml()
        {
            XDocument xdoc = new XDocument(new XElement("dataset",
                new XElement("record",
                    new XElement("first_name", "Tom"),
                    new XElement("last_name", "Johns"),
                    new XElement("company", "Microsoft"),
                    new XElement("age", 37)),
                new XElement("record",
                    new XElement("first_name", "Bob"),
                    new XElement("last_name", "Vil"),
                    new XElement("company", "Google"),
                    new XElement("age", 41))));
            xdoc.Save("DataSet2.xml");

            Console.WriteLine("Data saved");
        }
    }
}
