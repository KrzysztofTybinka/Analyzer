using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json.Nodes;
using System.Threading.Tasks;

namespace Analyzer.FileParserAbstractFactory.FileParser
{
    public class JsonFileDeserializer : FileDeserializer
    {
        public JsonFileDeserializer(string content) : base (content) { }

        public override List<JObject> ParseFile(string attribute)
        {
            JObject json = JObject.Parse(_content);

            List<JObject> list = json.Properties()
                .Descendants()
                .OfType<JProperty>()
                .Where(x => x.Name == attribute)
                .Values<T>()
                .ToList();

            if (list.Count == 0)
            {
                throw new KeyNotFoundException();
            }
            return list;
        }
    }
}
