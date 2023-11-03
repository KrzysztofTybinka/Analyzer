using Analyzer.FileParserAbstractFactory.FileParser;
using Deserializer;

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

        public FileDeserializer GetFileDeserializer(List<ISerializable> objects) 
        {
            string fileType = _path.Split('.').Last();

            if (fileType == "json")
            {
                return new JsonFileDeserializer(ReadFile().Result);
            }
            if (fileType == "xml")
            {
                return new XmlFileDeserializer(ReadFile().Result);
            }
            throw new InvalidOperationException();
        }
    }
}
