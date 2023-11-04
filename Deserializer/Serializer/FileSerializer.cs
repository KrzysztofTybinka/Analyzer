using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deserializer.Serializer
{
    internal abstract class FileSerializer
    {
        protected readonly string _path;

        public FileSerializer(string path)
        {
            _path = path;
        }

        public abstract void Serialize(IEnumerable<object> objects);
    }
}
