using Deserializer;
using System.Xml.Serialization;

namespace Analyzer.FileParserAbstractFactory.FileParser
{
    internal class XmlFileDeserializer : FileDeserializer
    {
        public XmlFileDeserializer(string content) : base(content) { }

        public override List<T> Deserialize<T>() where T : class 
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
