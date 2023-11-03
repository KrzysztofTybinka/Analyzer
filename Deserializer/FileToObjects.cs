
using Analyzer.FileParserAbstractFactory.FileParser;
using Analyzer.FileParserAbstractFactory.Reader;
using Deserializer;

namespace Analyzer.FileParserAbstractFactory
{
    public class FileToObjects
    {
        private List<ISerializable> _objects;

        public FileToObjects(List<ISerializable> objects)
        {
            _objects = objects;
        }

        public List<ISerializable> Deserialize(string path)
        {
            var reader = ReaderProducer.GetReader(path);
            return reader.GetFileDeserializer(_objects).Deserialize(); 
        }
    }
}
