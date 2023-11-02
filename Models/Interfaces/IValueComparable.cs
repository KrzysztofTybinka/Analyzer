using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Analyzer.Models.Interfaces
{
    internal interface IValueComparable
    {
        public bool Compare<T>(Func<T, bool> operation, string onProperty)
    }
}
