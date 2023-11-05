using Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Analyzer.Models
{
    public class Student : IValueComparable
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime DateOfBirth { get; set; }
        public DateTime StartedAt { get; set; }
        public bool Graduated { get; set; }

        public int Compare(string value, string propertyName)
        {
            if (propertyName.ToLower() == "dateofbirth")
            {
                return DateOfBirth.CompareTo(DateTime.Parse(value));
            }
            if (propertyName.ToLower() == "startedat")
            {
                return StartedAt.CompareTo(DateTime.Parse(value));
            }
            throw new InvalidOperationException();
        }
    }
}
