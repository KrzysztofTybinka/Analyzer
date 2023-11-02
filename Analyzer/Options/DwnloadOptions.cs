using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Analyzer.Options
{
    internal class DwnloadOptions
    {
        public string Path { get; set; }

        public DwnloadOptions(string path)
        {
            Path = path;
        }
    }
}
