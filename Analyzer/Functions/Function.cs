using Analyzer.FileParserAbstractFactory.FileParser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Analyzer
{
    public abstract class Function<T> where T : struct
    {
        protected FileParser _fileParser;
        protected string _node;

        public Function(FileParser fileParser, string node)
        {
            _fileParser = fileParser;
            _node = node;
        }

        public abstract void Execute();
    }
}
