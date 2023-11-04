using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deserializer.Serializer
{
    internal class JsonFileSerializer : FileSerializer
    {
        public JsonFileSerializer(string path) : base(path) { }

        public override void Serialize(IEnumerable<object> objects)
        {
            using (StreamWriter file = File.CreateText(_path))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(file, objects);
            }
        }
    }
}
