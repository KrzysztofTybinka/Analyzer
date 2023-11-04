using Analyzer.FileParserAbstractFactory;
using Analyzer.Models;
using CommandLine;
using CommandLine.Text;
using Memory;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Analyzer.Commands
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
            string message = "";
            if (CollectionName == "employees")
            {
                List<Employee> employees = FileToObjects.Deserialize<Employee>(Path);
                message = ModelCache.Add(GetFileName(), employees);
            }
            else if (CollectionName == "students")
            {
                List<Student> employees = FileToObjects.Deserialize<Student>(Path);
                message = ModelCache.Add(GetFileName(), employees);
            }
            else
            {
                message = "Collection doesn't exist.";
            }
            Console.WriteLine(message);
        }

        private string GetFileName()
        {
            return Path.Split('\\', '/').Last();
        }

    }
}
