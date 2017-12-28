using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtractMarks
{
    class Student : IStudent
    {
        private string firstName;
        private string lastName;
        private int age;
        private IList<decimal> marks;
        private string facultyNumber;

        public Student(string firstName, string lastName, int age, IList<decimal> marks, string facultyNumber)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
            this.Marks = marks;
            this.FacultyNumber = facultyNumber;
        }

        public string FirstName { get => this.firstName; set { if (value == null) { throw new ArgumentNullException(); } this.firstName = value; } }
        public string LastName { get => this.lastName; set { if (value == null) { throw new ArgumentNullException(); } this.lastName = value; } }
        public int Age { get => this.age; set { if (value < 0 || value > 100) { throw new ArgumentOutOfRangeException(); } this.age = value; } }
        public IList<decimal> Marks { get => this.marks; private set { this.marks = value; } }
        public string FacultyNumber { get => this.facultyNumber; private set { this.facultyNumber = value; } }
        public string GetMarksAsString => string.Join(", ", this.marks.Select(currentMark => Convert.ToString(currentMark)));

        public override string ToString()
        {
            return $"{FirstName} {LastName} {Age}";
        }
    }
}