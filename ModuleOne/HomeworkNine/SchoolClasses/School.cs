using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolClasses
{
    class School
    {
        private SchoolClass[] classes;
        private static int classesCount = 0;

        public School()
        {
            this.classes = new SchoolClass[4];
        }

        public School(params SchoolClass[] classes)
        {
            this.Classes = classes;
            classesCount = this.classes.Length;
        }

        public SchoolClass[] Classes { get { return this.classes; } set { if (value == null) { throw new ArgumentNullException(); } else { this.classes = value; School.classesCount = 0; } } }
        public SchoolClass this[int index] { get { if (index < 0 || index > classesCount) { throw new ArgumentOutOfRangeException(); } return this.classes[index]; } set { if (index < 0 || index > classesCount) { throw new ArgumentOutOfRangeException(); } this.classes[index] = value; } }

        public void AddClass(SchoolClass newClass)
        {
            if (classesCount == this.classes.Length)
            {
                SchoolClass[] newClasses = new SchoolClass[this.classes.Length * 2];
                for (int i = 0; i < this.classes.Length; i++)
                {
                    newClasses[i] = this.classes[i];
                }
                this.classes = newClasses;
            }
            this.classes[classesCount++] = newClass;
        }

        public bool RemoveClass(string classIdentifier)
        {
            bool isContaining = this.classes.ToList().Any(clas => clas.ClassIdentifier.Equals(classIdentifier));
            if (isContaining)
            {
                SchoolClass classForRemoving = this.classes.ToList().Where(clas => clas.ClassIdentifier.Equals(classIdentifier)).First();
                this.classes = this.classes.ToList().Where(clas => !clas.ClassIdentifier.Equals(classIdentifier)).ToArray();
                classesCount--;
            }
            return isContaining;
        }
    }
}