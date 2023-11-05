using CommandLine;
using FileParser.Commands;
using Memory;

namespace FileParser
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Upload a file to start working");
            while (true)
            {
                Console.WriteLine(ModelCache.StateName);

                if (args.Length == 0)
                {
                    continue;
                }

                Parser.Default.ParseArguments<UploadCommand,
                    DownloadCommand,
                    SmallerThanCommand,
                    GreaterThanCommand,
                    ExitCommand>(args)
                    .WithParsed<ICommand>(t => t.Execute());
            }
        }
    }
}