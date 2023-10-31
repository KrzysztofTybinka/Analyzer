using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Analyzer
{
    public abstract class Function
    {
        protected string _nodeName;
        protected string _argument;

        public Function(string nodeName, string argument)
        {
            _nodeName = nodeName;
            _argument = argument;
        }

        public virtual void Execute<T>(List<T> objects)
        {
            Type type = typeof(T).GetProperty()
            var prop = type.GetProperty(nameof(T));
        }
    }
}
