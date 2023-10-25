using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Analyzer.FileParserAbstractFactory.FileParser
{
    public class JsonFileParser : FileParser
    {
        public JsonFileParser(string content) : base (content) { }

        public override List<string?> ParseFile(string attribute)
        {
            throw new NotImplementedException();
        }
    }
}
