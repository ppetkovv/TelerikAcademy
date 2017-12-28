using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtractStudentsByMarks
{
    class Student : IStudent
    {
        private string firstName;
        private string lastName;
        private int age;
        private IList<decimal> marks;

        public Student(string firstName, string lastName, int age, List<decimal> someMarks)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
            this.marks = someMarks;
        }

        public string FirstName { get => this.firstName; set { if (value == null) { throw new ArgumentNullException(); } this.firstName = value; } }
        public string LastName { get => this.lastName; set { if (value == null) { throw new ArgumentNullException(); } this.lastName = value; } }
        public int Age { get => this.age; set { if (value < 0 || value > 100) { throw new ArgumentOutOfRangeException(); } this.age = value; } }
        public IList<decimal> Marks { get => this.marks; }
        public string FullName { get => this.FirstName + " " + this.LastName; }
        public string GetMarksAsString { get => string.Join(", ", this.marks.Select(currentMark => Convert.ToString(currentMark)).ToArray()); }

        public override string ToString()
        {
            return $"{FirstName} {LastName} {Age}\n{string.Join(", ", this.marks.Select(currentStudent => Convert.ToString(currentStudent)))}";
        }
    }
}