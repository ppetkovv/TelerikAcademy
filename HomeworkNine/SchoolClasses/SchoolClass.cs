using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SchoolClasses.Contracts;

namespace SchoolClasses
{
    class SchoolClass : ISchoolClass, IComments
    {
        private static byte classAsLetterCode = 64;
        private static byte classAsNumber = 1;
        private string comments;
        private string classIdentifier;
        private Teacher[] teachers;

        public SchoolClass()
        {
            SchoolClassUpdate();
            this.ClassIdentifier = string.Format("{0}{1}", classAsNumber, (char)classAsLetterCode);
        }

        public SchoolClass(params Teacher[] teachers) : this()
        {
            this.Teachers = teachers;
        }

        public SchoolClass(string comments) : this()
        {
            this.Comments = comments;
        }

        public SchoolClass(string comments, params Teacher[] teachers) : this()
        {
            this.Teachers = teachers;
            this.Comments = comments;
        }

        public string ClassIdentifier { get { return this.classIdentifier; } private set { this.classIdentifier = value; } }

        public Teacher[] Teachers { get { return this.teachers; } set { this.teachers = value; } }

        public string Comments { get { return this.comments; } set { if (value == null) throw new ArgumentNullException(); this.comments = value; } }

        private static void SchoolClassUpdate()
        {
            if (classAsLetterCode == 75)
            {
                classAsLetterCode = 65;
                classAsNumber++;
            }
            else
            {
                classAsLetterCode++;
            }
        }
    }
}