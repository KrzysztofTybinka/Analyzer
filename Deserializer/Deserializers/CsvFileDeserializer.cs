using CsvHelper;
using CsvHelper.Configuration;
using System;
using System.Globalization;
using System.Xml.Serialization;

namespace Analyzer.FileParserAbstractFactory.FileParser
{
    internal class CsvFileDeserializer : FileDeserializer
    {
        public CsvFileDeserializer(string content) : base(content) { }

        public override List<T> Deserialize<T>() where T : class 
        {
            List<T>? objects;

            using (var reader = new StringReader(_content))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                objects = csv.GetRecords<T>().ToList();
            }
            return objects;
        }
    }
}
