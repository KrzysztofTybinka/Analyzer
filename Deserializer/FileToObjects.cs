
using Analyzer.FileParserAbstractFactory.FileParser;
using Analyzer.FileParserAbstractFactory.Reader;

namespace Analyzer.FileParserAbstractFactory
{
    public class FileToObjects
    {
        FileToObjects() { }

        public static List<T> Deserialize<T>(string path) where T : class 
        {
            var reader = ReaderProducer.GetReader(path);
            return reader.GetFileDeserializer().Deserialize<T>(); 
        }
    }
}
