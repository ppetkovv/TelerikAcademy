using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SchoolClasses.Contracts;

namespace SchoolClasses
{
    class Discipline : IComments
    {
        private string comments;
        private string name;
        private int numberOfLectures;
        private int numberOfExercises;

        public Discipline(string name, int numberOfLectures, int numberOfExercises)
        {
            this.Name = name;
            this.NumberOfLectures = numberOfLectures;
            this.NumberOfExercises = numberOfExercises;
        }

        public string Comments { get { return this.comments; } set { this.comments = value; } }
        public string Name { get { return this.name; } set { if (value == null) { throw new ArgumentNullException(); } this.name = value; } }
        public int NumberOfLectures { get { return this.numberOfLectures; } set { if (value < 0) { throw new ArgumentOutOfRangeException(); } this.numberOfLectures = value; } }
        public int NumberOfExercises { get { return this.numberOfExercises; } set { if (value < 0) { throw new ArgumentOutOfRangeException(); } this.numberOfExercises = value; } }
    }
}