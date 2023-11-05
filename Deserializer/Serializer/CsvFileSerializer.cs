using CsvHelper;
using System;
using System.Collections;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deserializer.Serializer
{
    internal class CsvFileSerializer : FileSerializer
    {
        public CsvFileSerializer(string path) : base(path) { }

        public override void Serialize(IEnumerable objects)
        {
            using (var writer = new StreamWriter(_path))
            using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
            {
                csv.WriteRecords(objects);
            }
        }
    }
}
