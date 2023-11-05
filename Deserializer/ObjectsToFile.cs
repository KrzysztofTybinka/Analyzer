using Deserializer.Serializer;
using System.Collections;


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
