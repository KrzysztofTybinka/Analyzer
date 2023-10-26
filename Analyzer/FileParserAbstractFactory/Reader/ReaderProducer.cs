using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Analyzer.FileParserAbstractFactory.Reader
{
    public class ReaderProducer
    {
        ReaderProducer() { }

        public static Reader GetReader(string path)
        {
            if (IsUrl(path))
            {
                return new UrlReader(path);
            }
            if (IsDir(path))
            {
                return new DirReader(path);
            }
            throw new InvalidOperationException();
        }

        /// <summary>
        /// Checks if input value is url address.
        /// </summary>
        /// <param name="input"></param>
        /// <returns>True if input walue is url, otherwise false.</returns>
        /// <exception cref="NullReferenceException"></exception>
        private static bool IsUrl(string input)
        {
            return Uri.TryCreate(input, UriKind.Absolute, out Uri? uriResult)
                && (uriResult.Scheme == (Uri.UriSchemeHttp ?? throw new NullReferenceException())
                || uriResult.Scheme == (Uri.UriSchemeHttps ?? throw new NullReferenceException()));
        }

        /// <summary>
        /// Checks if input value is 
        /// valid directory path.
        /// </summary>
        /// <param name="input"></param>
        /// <returns>True if input is valid, otherwise false.</returns>
        private static bool IsDir(string input)
        {
            return File.Exists(input);
        }
    }
}
