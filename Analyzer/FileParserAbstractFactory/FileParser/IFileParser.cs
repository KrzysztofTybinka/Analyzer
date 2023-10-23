using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Analyzer.FileParserAbstractFactory.FileParser
{
    public interface IFileParser
    {
        public string Content { get; set; }
        public List<string?> ParseFile(string attribute);
    }
}
