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
            args = Console.ReadLine().Split(" ");
            if (args.Length == 0)
            {
                Console.WriteLine("\n");
            }


            Parser.Default.ParseArguments<UploadCommand, DownloadCommand>(args)
                .WithParsed<ICommand>(t => t.Execute());


        }
    }
}