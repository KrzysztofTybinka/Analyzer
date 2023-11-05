using Analyzer.FileParserAbstractFactory.Reader;

namespace Analyzer.FileParserAbstractFactory
{
    /// <summary>
    /// Deserializes file into collection of objects.
    /// </summary>
    public class FileToObjects
    {
        FileToObjects() { }

        /// <summary>
        /// Reads file and deserializes its content 
        /// into list of objects.
        /// </summary>
        /// <typeparam name="T">Model class</typeparam>
        /// <param name="path">Path or url to a file</param>
        /// <returns>List of objects</returns>
        public static List<T> Deserialize<T>(string path) where T : class 
        {
            var reader = ReaderProducer.GetReader(path);
            return reader.GetFileDeserializer().Deserialize<T>(); 
        }
    }
}
