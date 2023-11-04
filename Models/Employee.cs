using Analyzer.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Analyzer.Models
{
    public class Employee : IDateComparable
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime DateOfBirth { get; set; }
        public double Salary { get; set; }

        public bool Compare(Func<DateTime, bool> operation, string onProperty)
        {
            if (onProperty.ToLower() == "dateofbirth")
            {
                return operation(DateOfBirth);
            }
            if (onProperty.ToLower() == "salary")
            {
                return Salary.CompareTo(Salary);
            }
            throw new InvalidOperationException();
        }
    }
}
