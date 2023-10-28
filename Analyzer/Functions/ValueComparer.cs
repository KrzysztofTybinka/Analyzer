using Analyzer.FileParserAbstractFactory.FileParser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Analyzer.Functions
{
    public class ValueComparer : Function<double>
    {
        public ValueComparer(Deserializer fileParser, string node) : base(fileParser, node) { }

        public override void Execute()
        {
            var attribs = _fileParser.ParseFile<double>(_node);
        }


        private List<int> Compare(Func<int, bool> func, List<int> values)
        {
            return values.Where(x => func(x)).ToList();
        }
    }
}
