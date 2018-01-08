using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstBeforeLast
{
    class Student : IStudent
    {
        private string firstName;
        private string lastName;

        public Student(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public string FirstName { get => this.firstName; set { if (value == null) { throw new ArgumentNullException(); } this.firstName = value; } }
        public string LastName { get => this.lastName; set { if (value == null) { throw new ArgumentNullException(); } this.lastName = value; } }

        public override string ToString()
        {
            return $"{FirstName} {LastName}";
        }
    }
}
