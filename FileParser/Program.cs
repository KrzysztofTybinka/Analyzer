using CommandLine;
using FileParser.Commands;
using Memory;

namespace FileParser
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isRunning = true;

            Console.CancelKeyPress += (sender, e) =>
            {
                e.Cancel = true; 
                isRunning = false; 
            };

            while (isRunning)
            {
                Messages();

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

        static void Messages()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n" + ModelCache.StateName);
            Console.ResetColor();
        }
    }
}