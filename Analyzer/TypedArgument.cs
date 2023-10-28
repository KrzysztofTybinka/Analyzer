using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Analyzer
{
    public class TypedArgument<T> where T : struct
    {
        public T Value { get; init; }

        public TypedArgument(T value)
        {
            Value = value;
        }
    }
}
