using Analyzer.FileParserAbstractFactory.FileParser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Analyzer.FileParserAbstractFactory.Reader
{
    public class UrlReader : Reader
    {
        public UrlReader(string path) : base(path) { }

        public override async Task<string> ReadFile()
        {
            return await new HttpClient().GetStringAsync(_path);
        }
    }
}
