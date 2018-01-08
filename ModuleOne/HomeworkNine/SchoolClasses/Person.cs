using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SchoolClasses.Contracts;

namespace SchoolClasses
{
    public abstract class Person : IPerson, IComments
    {
        private string comments;
        private string name;

        protected Person(string name)
        {
            this.Name = name;
        }

        protected Person(string name, string comments)
        {
            this.Name = name;
            this.Comments = comments;
        }

        public string Name { get { return this.name; } set { if (value == null) { throw new ArgumentNullException(); } this.name = value; } }

        public string Comments { get { return this.comments; } set { if (value == null) { throw new ArgumentNullException(); } this.comments = value; } }
    }
}