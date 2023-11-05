using Newtonsoft.Json;
using System.Collections;

namespace Deserializer.Serializer
{
    internal class JsonFileSerializer : FileSerializer
    {
        public JsonFileSerializer(string path) : base(path) { }

        public override void Serialize(IEnumerable objects)
        {
            using (StreamWriter file = File.CreateText(_path))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(file, objects);
            }
        }
    }
}
