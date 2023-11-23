using System.Xml;

namespace XML
{
    internal class Program
    {
        static void Main(string[] args)
        {
            XML_File.EditDocument();
            XML_File.PrintDocument();
            XML_File.DeleteLastNode();

            XPathFile.XPathExample();

            LinqXML.CreateXml();

            DataSet.PrintDocument();
        }
    }
}