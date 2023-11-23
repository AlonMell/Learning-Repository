using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace XML
{
    static class DataSet
    {
        public static void PrintDocument()
        {
            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.Load("Dataset.xml");
            Console.WriteLine("Документ Dataset.xml: ");
            Console.WriteLine(new string('-', 40));
            XmlElement? xRoot = xmlDocument.DocumentElement;
            if(xRoot != null )
            {
                foreach(XmlElement node in xRoot)
                {
                    string? firstname = null, lastname = null, email = null, gender = null, ip = null;
                    foreach (XmlNode childnode in node.ChildNodes)
                    {
                        if (childnode.Name == "first_name")
                        {
                            firstname = childnode.InnerText;
                        }
                        else if (childnode.Name == "last_name")
                        {
                            lastname = childnode.InnerText;
                        }
                        else if (childnode.Name == "email")
                        {
                            email = childnode.InnerText;
                        }
                        else if (childnode.Name == "gender")
                        {
                            gender = childnode.InnerText;
                        }
                        else if (childnode.Name == "ip_address")
                        {
                            ip = childnode.InnerText;
                        }
                    }
                    Console.WriteLine($"Full Name: {firstname} {lastname}");
                    Console.WriteLine($"Email: {email}");
                    Console.WriteLine($"Gender: {gender}");
                    Console.WriteLine($"Ip address: {ip}");
                    Console.WriteLine();
                }
            }
            Console.WriteLine(new string('-', 40));
        }
    }
}
