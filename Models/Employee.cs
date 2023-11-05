using Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Analyzer.Models
{
    public class Employee : IValueComparable
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime DateOfBirth { get; set; }
        public double Salary { get; set; }

        public int Compare(string value, string propertyName)
        {
            if (propertyName.ToLower() == "dateofbirth")
            {
                return DateOfBirth.CompareTo(DateTime.Parse(value));
            }
            if (propertyName.ToLower() == "salary")
            {
                return Salary.CompareTo(double.Parse(value, CultureInfo.InvariantCulture));
            }
            throw new InvalidOperationException();
        }
    }
}
