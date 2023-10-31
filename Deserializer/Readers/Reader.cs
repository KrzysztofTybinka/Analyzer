using Analyzer.FileParserAbstractFactory.FileParser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Analyzer.FileParserAbstractFactory.Reader
{
    internal abstract class Reader
    {
        protected string _path;

        public Reader(string path)
        {
            _path = path;       
        }

        public abstract Task<string> ReadFile();

        public FileDeserializer<T> GetFileDeserializer<T>() where T : class 
        {
            string fileType = _path.Split('.').Last();

            if (fileType == "json")
            {
                return new JsonFileDeserializer<T>(ReadFile().Result);
            }
            if (fileType == "xml")
            {
                return new XmlFileDeserializer<T>(ReadFile().Result);
            }
            throw new InvalidOperationException();
        }
    }
}
