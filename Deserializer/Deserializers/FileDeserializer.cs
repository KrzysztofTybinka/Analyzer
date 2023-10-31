using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Analyzer.FileParserAbstractFactory.FileParser
{
    internal abstract class FileDeserializer<T> where T : class
    {
        protected readonly string _content;

        public FileDeserializer(string content)
        {
            _content = content;
        }

        public abstract List<T> Deserialize();
    }
}
