using Analyzer.FileParserAbstractFactory;
using Analyzer.FileParserAbstractFactory.FileParser;
using Analyzer.Models;
using System.Xml.Linq;
using System.Xml.Serialization;
using System;

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

            Options input = new Options(args);


            List<Employee> deserializer = FileToObjects.Deserialize<Employee>("C://xaxaxa//xaxaxa");




        }
    }
}