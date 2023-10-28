using Analyzer.FileParserAbstractFactory.FileParser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Analyzer.FileParserAbstractFactory.Reader
{
    internal class DirReader : Reader
    {
        public DirReader(string path) : base(path) { }

        public override async Task<string> ReadFile()
        {
            return await File.ReadAllTextAsync(_path);
        }
    }
}
