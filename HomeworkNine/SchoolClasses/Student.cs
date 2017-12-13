using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SchoolClasses.Contracts;

namespace SchoolClasses
{
    class Student : Person,IStudent
    {
        private static byte uniqueNumberCounter = 1;
        private byte uniqueNumber;

        public Student(string name, string comments, byte uniqueNumber) : base(name, comments)
        {
            this.uniqueNumber = Student.uniqueNumberCounter++;
        }

        public Student(string name, byte uniqueNumber) : base(name)
        {
            this.uniqueNumber = Student.uniqueNumberCounter++;
        }

        public byte UniqueNumber { get { return this.uniqueNumber; } }
    }
}