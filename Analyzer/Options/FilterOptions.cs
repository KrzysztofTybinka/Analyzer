using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Analyzer.Options
{
    internal class FilterOptions
    {
        public string Node { get; set; }
        public string Function { get; set; }
        public string Value { get; set; }

        public FilterOptions(string node, string function, string value)
        {
            Node = node;
            Function = function;
            Value = value;
        }
    }
}
