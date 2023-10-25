using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Analyzer.FileParserAbstractFactory.FileParser
{
    internal class XmlFileParser : FileParser
    {
        public XmlFileParser(string content) : base(content) { }

        public override List<string?> ParseFile(string attribute)
        {
            XDocument xmlDoc = XDocument.Parse(_content);

            List<string?> list = xmlDoc.Descendants(attribute)
                .Select(x => x.Value ?? null)
                .ToList();

            if (list.Count == 0)
            {
                throw new KeyNotFoundException();
            }
            return list;
        }
    }
}
