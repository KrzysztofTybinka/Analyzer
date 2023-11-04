using Analyzer.FileParserAbstractFactory;
using Analyzer.FileParserAbstractFactory.FileParser;
using System.Xml.Linq;
using System.Xml.Serialization;
using System;
using CommandLine;
using Analyzer.Commands;

namespace Analyzer
{
    public class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                var input = Console.ReadLine();
                args = string.IsNullOrEmpty(input) ? new string[0] : input.Split(" ");

                if (args.Length == 0)
                {
                    Console.WriteLine();
                    continue;
                }


                Parser.Default.ParseArguments<UploadCommand, DownloadCommand>(args)
                    .WithParsed<ICommand>(t => t.Execute());
            }

        }
    }
}