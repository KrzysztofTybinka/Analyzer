using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Analyzer.Models.Interfaces
{
    internal interface IDateComparable
    {
        public bool Compare(Func<DateTime, bool> operation, string onProperty);
    }
}
