using Analyzer.FileParserAbstractFactory;
using Analyzer.Models;
using CommandLine;
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
            List<Employee> t = FileToObjects.Deserialize<Employee>(Path);

            throw new NotImplementedException();
        }
    }
}
