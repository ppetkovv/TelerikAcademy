using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderStudents
{
    class Student : IStudent
    {
        private string firstName;
        private string lastName;
        private int age;

        public Student(string firstName, string lastName, int age)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
        }

        public string FirstName { get => this.firstName; set { if (value == null) { throw new ArgumentNullException(); } this.firstName = value; } }
        public string LastName { get => this.lastName; set { if (value == null) { throw new ArgumentNullException(); } this.lastName = value; } }
        public int Age { get => this.age; set { if (value < 0 || value > 100) { throw new ArgumentOutOfRangeException(); } this.age = value; } }

        public override string ToString()
        {
            return $"{FirstName} {LastName} {Age}";
        }
    }
}
