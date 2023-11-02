using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Analyzer.Options
{
    internal class UploadOptions
    {
        public string Collection { get; set; }

        public string FilePath { get; set; }

        public UploadOptions(string collection, string filePath)
        {
            Collection = collection;
            FilePath = filePath;
        }
    }
}
