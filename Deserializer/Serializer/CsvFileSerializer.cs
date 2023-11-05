using CsvHelper;
using System.Collections;
using System.Globalization;

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
