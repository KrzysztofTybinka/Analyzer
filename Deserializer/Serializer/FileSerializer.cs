using System.Collections;

namespace Deserializer.Serializer
{
    internal abstract class FileSerializer
    {
        protected readonly string _path;

        public FileSerializer(string path)
        {
            _path = path;
        }

        public abstract void Serialize(IEnumerable objects);
    }
}
