

using Deserializer;

namespace Analyzer.FileParserAbstractFactory.FileParser
{
    internal abstract class FileDeserializer
    {
        protected readonly string _content;

        public FileDeserializer(string content)
        {
            _content = content;
        }

        public abstract List<ISerializable> Deserialize();
    }
}
