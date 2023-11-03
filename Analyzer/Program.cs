using Analyzer.FileParserAbstractFactory;
using Analyzer.FileParserAbstractFactory.FileParser;
using System.Xml.Linq;
using System.Xml.Serialization;
using System;
using CommandLine;

namespace Analyzer
{
    public class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("\n");
            }


            Parser.Default.ParseArguments<UploadCommand, DownloadCommand>(args)
                .WithParsed<ICommand>(t => t.Execute());


        }
    }
}