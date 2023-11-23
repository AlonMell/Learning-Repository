using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace XML
{
    static class XML_File
    {
        public static void PrintDocument()
        {
            XmlDocument xDoc = new XmlDocument();
            Console.WriteLine("Документ XML_File: ");
            Console.WriteLine(new string('-', 40));
            xDoc.Load("XML_File.xml");
            XmlElement? xRoot = xDoc.DocumentElement;
            if (xRoot != null)
            {
                foreach (XmlElement xnode in xRoot)
                {
                    XmlNode? attr = xnode.Attributes.GetNamedItem("name");
                    Console.WriteLine(attr?.Value);
                    // обходим все дочерние узлы элемента user
                    foreach (XmlNode childnode in xnode.ChildNodes)
                    {
                        // если узел - company
                        if (childnode.Name == "company")
                        {
                            Console.WriteLine($"Company: {childnode.InnerText}");
                        }
                        // если узел age
                        if (childnode.Name == "age")
                        {
                            Console.WriteLine($"Age: {childnode.InnerText}");
                        }
                    }
                    Console.WriteLine();
                }
            }
            Console.WriteLine(new string('-', 40));
        }
        public static void EditDocument()
        {
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load("XML_File.xml");
            XmlElement? xRoot = xDoc.DocumentElement;

            XmlElement personElem = xDoc.CreateElement("person");
            XmlAttribute nameAttr = xDoc.CreateAttribute("name");
            XmlElement companyElem = xDoc.CreateElement("company");
            XmlElement ageElem = xDoc.CreateElement("age");

            XmlText nameText = xDoc.CreateTextNode("Daniel");
            XmlText companyText = xDoc.CreateTextNode("Yandex");
            XmlText ageText = xDoc.CreateTextNode("21");

            nameAttr.AppendChild(nameText);
            companyElem.AppendChild(companyText);
            ageElem.AppendChild(ageText);

            personElem.Attributes.Append(nameAttr);
            personElem.AppendChild(companyElem);
            personElem.AppendChild(ageElem);
            xRoot?.AppendChild(personElem);

            xDoc.Save("XML_File.xml");
        }
        public static void DeleteLastNode()
        {
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load("XML_File.xml");
            XmlElement? xRoot = xDoc.DocumentElement;
            XmlNode? lastnode = xRoot?.LastChild;
            if (lastnode is not null) xRoot?.RemoveChild(lastnode);
            xDoc.Save("XML_File.xml");
        }
    }
}
