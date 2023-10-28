
using Analyzer.FileParserAbstractFactory.FileParser;
using Analyzer.FileParserAbstractFactory.Reader;

namespace Analyzer.FileParserAbstractFactory
{
    public class FileToObjects
    {
        FileToObjects() { }

        public static List<T> Deserialize<T>(string path)
        {
            var reader = ReaderProducer.GetReader(path);
            return reader.GetFileDeserializer<T>().Deserialize(); 
        }
    }
}
