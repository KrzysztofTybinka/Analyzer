using Analyzer.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Analyzer.Models
{
    public class Student : IDateComparable
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime DateOfBirth { get; set; }
        public DateTime StartedAt { get; set; }
        public bool Graduated { get; set; }

        public bool Compare(Func<DateTime, bool> operation, string onProperty)
        {
            if (onProperty.ToLower() == "dateofbirth")
            {
                return operation(DateOfBirth);
            }
            else if (onProperty.ToLower() == "startedat")
            {
                return operation(StartedAt);
            }
            throw new InvalidOperationException();
        }
    }
}
