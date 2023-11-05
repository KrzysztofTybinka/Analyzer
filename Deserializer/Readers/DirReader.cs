
namespace Analyzer.FileParserAbstractFactory.Reader
{
    internal class DirReader : Reader
    {
        public DirReader(string path) : base(path) { }

        public override async Task<string> ReadFile()
        {
            return await File.ReadAllTextAsync(_path);
        }
    }
}
