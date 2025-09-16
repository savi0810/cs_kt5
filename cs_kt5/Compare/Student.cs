using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_kt5.Compare
{
    internal class Student : Entity
    {
        public string Name { get; }
        public int Age { get; }
        public double Grade { get; }

        public Student(string name, int age, double grade)
        {
            Name = name;
            Age = age;
            Grade = grade;
        }

        protected override IEnumerable<object> GetComparisonComponents()
        {
            yield return Name;
            yield return Age;
            yield return Grade;
        }
    }
}
