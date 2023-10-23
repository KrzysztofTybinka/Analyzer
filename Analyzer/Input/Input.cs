using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Analyzer.Input
{
    public class Input //node -fc val source        gowno -gt 4 C//..........
    {
        public string Node { get; set; }
        public string Function { get; set; }
        public string Value { get; set; }
        public string Path { get; set; }

        public Input(string command)
        {
            string[] elements = command.Split(" ");  
            

        }
    }
}
