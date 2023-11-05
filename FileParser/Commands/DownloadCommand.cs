using CommandLine;
using Memory;
using Deserializer;

namespace FileParser.Commands
{
    [Verb("download", HelpText = "Download a file")]
    internal class DownloadCommand : ICommand
    {
        [Option('n', "name", Required = true, HelpText = "File name")]
        public string FileName { get; set; }

        [Value(0, MetaName = "path", Required = true, HelpText = "Download path location")]
        public string Path { get; set; }

        public void Execute()
        {
            var collection = ModelCache.Get(FileName);
            if (collection is null)
            {
                Console.WriteLine("File doesn't exist.");
            }
            else
            {
                string message = ObjectsToFile.Serialize(Path, collection);
                ModelCache.Remove(FileName);
                Console.WriteLine("File downloaded successfully");
                Console.WriteLine(message);
            }
        }
    }
}
