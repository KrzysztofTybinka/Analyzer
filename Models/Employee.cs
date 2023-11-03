using Deserializer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Analyzer.Models
{
    public class Employee : ISerializable
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime DateOfBirth { get; set; }
        public double Salary { get; set; }
        public string CollectionName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
