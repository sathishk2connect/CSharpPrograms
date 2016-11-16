using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Chapter2._7
{
    class XmlStringDemo
    {

        static void Main(string[] args)
        {
            StringWriter stringWriter = new StringWriter();
            using (XmlWriter writer = XmlWriter.Create(stringWriter))
            {
                writer.WriteStartElement("book");
                writer.WriteElementString("price", "19.95");
                writer.WriteElementString("author", "David Jones");
                writer.WriteEndElement();
                writer.Flush();
            }
            string xml = stringWriter.ToString();
            Console.WriteLine(xml);

            var stringReader = new StringReader(xml);
            using(XmlReader reader = XmlReader.Create(stringReader))
            {
                reader.ReadToFollowing("price");
                decimal price = decimal.Parse(reader.ReadInnerXml(), new CultureInfo("en-GB"));
                string priceStr = price.ToString("C", new CultureInfo("en-GB"));
                string author = reader.ReadInnerXml();
                Console.WriteLine(author + "  "  + priceStr);
            }

            Console.ReadKey();
        }
    }
}
