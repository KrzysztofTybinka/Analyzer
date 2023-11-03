using Newtonsoft.Json;

namespace Analyzer.FileParserAbstractFactory.FileParser
{
    internal class JsonFileDeserializer : FileDeserializer
    {
        public JsonFileDeserializer(string content) : base (content) { }

        public override List<T> Deserialize<T>() where T : class
        {
            List<T>? objects = JsonConvert.DeserializeObject<List<T>>(_content);

            if (objects == null || objects.Count == 0)
            {
                throw new InvalidDataException("Invalid file data");
            }
            return objects;
        }
    }
}
