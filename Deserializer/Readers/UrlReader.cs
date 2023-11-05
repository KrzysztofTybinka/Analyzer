
namespace Analyzer.FileParserAbstractFactory.Reader
{
    internal class UrlReader : Reader
    {
        public UrlReader(string path) : base(path) { }

        public override async Task<string> ReadFile()
        {
            return await new HttpClient().GetStringAsync(_path);
        }
    }
}
