using Analyzer.FileParserAbstractFactory.FileParser;
using Analyzer.FileParserAbstractFactory.Reader;

namespace Analyzer.FileParserAbstractFactory
{
    public class FileParserProducer
    {
        FileParserProducer() { }

        public static FileParser.FileParser GetFileParser(string path)
        {
            var reader = ReaderProducer.GetReader(path);
            return reader.GetFileParser(); 
        }
    }
}
