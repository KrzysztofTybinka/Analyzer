using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Analyzer
{
    internal class Options 
    {
        public string? Name { get; set; }
        public string? Function { get; set; }
        public string? Value { get; set; }
        public string? Path { get; set; }

        public Options(params string[] input)
        {
            if (input.Length == 1)
            {
                Function = input[0];
            }
            else if (input.Length == 3)
            {
                
            }
        }
    }
}
