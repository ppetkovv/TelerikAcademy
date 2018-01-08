using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsAndWorkers
{
    class Student : Human,IStudent
    {
        private double grade;

        public Student(string firstName, string lastName) : base(firstName, lastName)
        {
        }

        public Student(string firstName, string lastName, double grade) : base(firstName, lastName)
        {
            this.Grade = grade;
        }

        public double Grade { get { return this.grade; } set { if (value < 2 || value > 6) { throw new ArgumentOutOfRangeException(); } this.grade = value; } }

        public override string ToString() => base.ToString() + $" Grade: {Grade}";
    }
}