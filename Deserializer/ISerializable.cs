using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deserializer
{
    public interface ISerializable
    {
        public string CollectionName { get; set; }
    }
}
