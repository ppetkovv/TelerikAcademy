using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsAndWorkers
{
    public abstract class Human
    {
        private string firstName;
        private string lastName;

        protected Human(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public string FirstName { get { return this.firstName; } set { if (value == null) { throw new ArgumentNullException(); } this.firstName = value; } }
        public string LastName { get { return this.lastName; } set { if (value == null) { throw new ArgumentNullException(); } this.lastName = value; } }

        public override string ToString() => $"First name: {FirstName} Last name: {LastName}";
    }
}