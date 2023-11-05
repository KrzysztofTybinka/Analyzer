using Analyzer.FileParserAbstractFactory;
using Analyzer.FileParserAbstractFactory.FileParser;
using System.Xml.Linq;
using System.Xml.Serialization;
using System;
using CommandLine;
using Analyzer.Commands;
using Memory;

namespace Analyzer
{
    public class Program
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