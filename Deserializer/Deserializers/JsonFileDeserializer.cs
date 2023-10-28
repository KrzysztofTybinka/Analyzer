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
    internal class JsonFileDeserializer<T> : FileDeserializer<T>
    {
        public JsonFileDeserializer(string content) : base (content) { }

        public override List<T> Deserialize(string attribute)
        {
            throw new NotImplementedException();
        }
    }
}
