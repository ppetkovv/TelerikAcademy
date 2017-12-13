using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AnimalHierarchy.Enums;
using AnimalHierarchy.Contracts;

namespace AnimalHierarchy
{
    public abstract class Animal : IAnimal,ISound
    {
        private string name;
        private int age;
        private Sex sex;

        protected Animal(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        protected Animal(string name, int age, Sex sex) : this(name, age)
        {
            this.Sex = sex;
        }

        public string Name { get => this.name; set { if (value == null) { throw new ArgumentNullException(); } this.name = value; } }
        public int Age { get => this.age; set { if (value < 0 || value > 30) { throw new ArgumentOutOfRangeException(); } this.age = value; } }
        public Sex Sex { get => this.sex; set => this.sex = value; }

        public abstract void ProduceSound();
    }
}