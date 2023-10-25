using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Analyzer.FileParserAbstractFactory.FileParser
{
    public abstract class FileParser
    {
        protected readonly string _content;

        public FileParser(string content)
        {
            _content = content;
        }

        public abstract List<string?> ParseFile(string attribute);
    }
}
