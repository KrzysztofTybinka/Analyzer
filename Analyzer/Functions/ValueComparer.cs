using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Analyzer.Functions
{
    public class ValueComparer : Function
    {
        public override void Execute()
        {
            throw new NotImplementedException();
        }

        public void Test()
        {
            Compare(x => x > 5, new List<int>());
        }

        private List<int> Compare(Func<int, bool> func, List<int> values)
        {
            return values.Where(x => func(x)).ToList();
        }
    }
}
