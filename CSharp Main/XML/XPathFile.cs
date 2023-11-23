using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace XML
{
    static class XPathFile
    {
        public static void XPathExample()
        {
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load("Dataset.xml");
            XmlElement? xRoot = xDoc.DocumentElement;

            XmlNodeList? nodes = xRoot?.SelectNodes("//record/email");
            Console.WriteLine("All email's in dataset.xml: ");
            Console.WriteLine(new string('-', 40));
            if (nodes is not null)
            {
                foreach (XmlNode node in nodes)
                    Console.WriteLine(node.InnerText);
            }
            Console.WriteLine(new string('-', 40));
        }
    }
}
