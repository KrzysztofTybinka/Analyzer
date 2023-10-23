using Analyzer.FileParserAbstractFactory.FileParser;
using Analyzer.FileParserAbstractFactory.Reader;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Analyzer.FileParserAbstractFactory
{
    public class FileParserProducer
    {
        FileParserProducer() { }

        public static IFileParser GetFileParser(string path)
        {
            ReaderProducer readerProdicer = new ReaderProducer();
            Reader.Reader? reader = readerProdicer.GetReader(path);

            return reader.GetFileParser(); 
        }
    }
}
