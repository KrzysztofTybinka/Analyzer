using Analyzer.FileParserAbstractFactory.FileParser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Analyzer.FileParserAbstractFactory.Reader
{
    public class DirReader : Reader
    {
        public override string ReadFile()
        {
            return File.ReadAllText(filePath);
        }
    }
}
