using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SchoolClasses.Contracts;

namespace SchoolClasses
{
    class Teacher : Person, ITeacher
    {
        private Discipline[] disciplines;

        public Teacher(string name, string comments, Discipline[] disciplines) : base(name, comments)
        {
            this.Disciplines = disciplines;
        }

        public Teacher(string name, Discipline[] disciplines) : base(name)
        {
            this.Disciplines = disciplines;
        }

        public Discipline[] Disciplines { get { return this.disciplines; } set { this.disciplines = value; } }
    }
}