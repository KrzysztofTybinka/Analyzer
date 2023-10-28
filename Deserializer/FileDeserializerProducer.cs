
using Analyzer.FileParserAbstractFactory.FileParser;
using Analyzer.FileParserAbstractFactory.Reader;

namespace Analyzer.FileParserAbstractFactory
{
    public class FileDeserializerProducer
    {
        FileDeserializerProducer() { }

        public static FileDeserializer<T> GetFileParser<T>(string path)
        {
            var reader = ReaderProducer.GetReader(path);
            return reader.GetFileDeserializer<T>(); 
        }
    }
}
