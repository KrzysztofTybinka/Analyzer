using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Analyzer.Functions
{
    /// <summary>
    /// Determines which funciton class to return
    /// </summary>
    public class FunctionFactory
    {
        /// <summary>
        /// Dictionary of function names expressed by a string and
        /// corresponding classes representing a specific function
        /// </summary>
        private Dictionary<string, Function> _functions = new()
        {
            {"-cp", new ValueComparer() },
            {"-pt", new ValuePrinter() }
        };

        /// <summary>
        /// Returns function class based on function name
        /// </summary>
        /// <param name="functionName"></param>
        /// <returns>Function class</returns>
        /// <exception cref="InvalidOperationException"></exception>
        public Function GetFunction(string functionName)
        {
            if (_functions.ContainsKey(functionName))
            {
                return _functions[functionName];
            }
            throw new InvalidOperationException();
        }
    }
}
