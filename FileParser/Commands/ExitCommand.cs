using CommandLine;

namespace FileParser.Commands
{
    [Verb("exit", HelpText = "Exit")]
    internal class ExitCommand : ICommand
    {
        public void Execute()
        {
            Environment.Exit(0);
        }
    }
}
