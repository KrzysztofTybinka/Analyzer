using Deserializer;
using Newtonsoft.Json;

namespace Analyzer.FileParserAbstractFactory.FileParser
{
    internal class JsonFileDeserializer : FileDeserializer
    {
        public JsonFileDeserializer(string content) : base (content) { }

        public override List<ISerializable> Deserialize()
        {
            List<ISerializable>? objects = JsonConvert.DeserializeObject<List<ISerializable>>(_content);

            if (objects == null || objects.Count == 0)
            {
                throw new InvalidDataException("Invalid file data");
            }
            return objects;
        }
    }
}
