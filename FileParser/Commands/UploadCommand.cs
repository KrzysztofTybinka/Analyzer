using Analyzer.FileParserAbstractFactory;
using Analyzer.Models;
using CommandLine;
using Memory;
using System;
using System.ComponentModel;

namespace FileParser.Commands
{
    [Verb("upload", HelpText = "Upload a file into memory")]
    internal class UploadCommand : ICommand
    {
        [Option('c', "collection", Required = true, HelpText = "Name of the collection")]
        public string CollectionName { get; set; }

        [Value(0, MetaName = "path", Required = true, HelpText = "Directory path or URL to the file to upload")]
        public string Path { get; set; }

        public void Execute()
        {
            string coll = CollectionName.ToLower();
            string message;
            if (coll == "employees" || coll == "employee")
            {
                List<Employee> employees = FileToObjects.Deserialize<Employee>(Path);
                message = ModelCache.Add(GetFileName(), employees);
            }
            else if (coll == "students" || coll == "student")
            {
                List<Student> students = FileToObjects.Deserialize<Student>(Path);
                message = ModelCache.Add(GetFileName(), students);
            }
            else
            {
                message = "Collection not supported.";
            }
            Console.WriteLine(message);
        }

        private string GetFileName()
        {
            return Path.Split('\\', '/').Last();
        }

    }
}
