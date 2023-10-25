using Analyzer.FileParserAbstractFactory.FileParser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Analyzer.FileParserAbstractFactory.Reader
{
    public abstract class Reader
    {
        protected string _path;

        public Reader(string path)
        {
            _path = path;       
        }

        public abstract Task<string> ReadFile();

        public FileParser.FileParser GetFileParser()
        {
            string fileType = _path.Split('.').Last();

            if (fileType == ".json")
            {
                return new JsonFileParser(ReadFile().Result);
            }
            if (fileType == ".xml")
            {
                return new XmlFileParser(ReadFile().Result);
            }
            throw new InvalidOperationException();
        }
    }
}
