using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace Analyzer.FileParserAbstractFactory.FileParser
{
    internal class XmlFileDeserializer<T> : FileDeserializer<T> where T : class
    {
        public XmlFileDeserializer(string content) : base(content) { }

        public override List<T> Deserialize()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<T>));
            List<T>? objects;

            using (TextReader reader = new StringReader(_content))
            {
                objects = (List<T>?)serializer.Deserialize(reader);
            }

            if (objects == null || objects.Count == 0)
            {
                throw new InvalidDataException("Invalid file data");
            }
            return objects;
        }
    }
}
