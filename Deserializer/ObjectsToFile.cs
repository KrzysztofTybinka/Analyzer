using Deserializer.Serializer;
using System.Collections;


namespace Deserializer
{
    /// <summary>
    /// Serializes collection of objects into file.
    /// </summary>
    public class ObjectsToFile
    {
        ObjectsToFile() { }

        /// <summary>
        /// Serializes collection of objects into file and saves it
        /// </summary>
        /// <param name="path">Location for a file to be saved</param>
        /// <param name="objects">Collection of objects</param>
        /// <returns></returns>
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
