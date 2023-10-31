using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Analyzer.Functions
{
    public class ValueComparer : Function
    {
        public ValueComparer(string nodeName, string argument) : base(nodeName, argument) { }

        public override void Execute()
        {
        }


        private List<int> Compare<T>(Func<T, bool> func, List<int> values)
        {
            return values.Where(x => func(x)).ToList();
        }
    }
}
