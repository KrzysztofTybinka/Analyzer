using CommandLine;
using Memory;

namespace FileParser.Commands
{
    [Verb("switch", HelpText = "Switches working directory")]
    internal class SwitchCommand
    {
        [Option('n', "name", Required = true, HelpText = "File name")]
        public string Name { get; set; }

        public void Execute()
        {
            string message = ModelCache.Switch(Name);
            Console.WriteLine(message);
        }
    }
}
