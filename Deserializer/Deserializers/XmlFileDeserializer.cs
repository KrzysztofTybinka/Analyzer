using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Analyzer.FileParserAbstractFactory.FileParser
{
    internal class XmlFileDeserializer<T> : FileDeserializer<T>
    {
        public XmlFileDeserializer(string content) : base(content) { }

        public override List<T> Deserialize(string attribute)
        {
            throw new NotImplementedException();
        }
    }
}
