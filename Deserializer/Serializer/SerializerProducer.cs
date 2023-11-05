
namespace Deserializer.Serializer
{
    internal class SerializerProducer
    {
        public static FileSerializer GetFileSerializer(string path)
        {
            string fileType = path.Split('.').Last();

            if (fileType == "json")
            {
                return new JsonFileSerializer(path);
            }
            if (fileType == "csv")
            {
                return new CsvFileSerializer(path);
            }
            throw new InvalidOperationException();
        }
    }
}
