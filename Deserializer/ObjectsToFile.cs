using Analyzer.FileParserAbstractFactory.FileParser;
using Analyzer.FileParserAbstractFactory.Reader;
using Deserializer.Serializer;
using System;
using System.Collections;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deserializer
{
    public class ObjectsToFile
    {
        ObjectsToFile() { }

        public static string Serialize(string path, IEnumerable objects) 
        {
            try
            {
                var file = SerializerProducer.GetFileSerializer(path);
                file.Serialize(objects);
                return "File saved to a directory.";
            }
            catch (DirectoryNotFoundException ex)
            {
                return ex.Message;
            }
            catch (UnauthorizedAccessException ex)
            {
                return ex.Message;
            }
        }
    }
}
