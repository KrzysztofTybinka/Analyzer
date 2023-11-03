using Deserializer;
using System.Xml.Serialization;

namespace Analyzer.FileParserAbstractFactory.FileParser
{
    internal class XmlFileDeserializer : FileDeserializer
    {
        public XmlFileDeserializer(string content) : base(content) { }

        public override List<ISerializable> Deserialize()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<ISerializable>));
            List<ISerializable>? objects;

            using (TextReader reader = new StringReader(_content))
            {
                objects = (List<ISerializable>?)serializer.Deserialize(reader);
            }

            if (objects == null || objects.Count == 0)
            {
                throw new InvalidDataException("Invalid file data");
            }
            return objects;
        }
    }
}
