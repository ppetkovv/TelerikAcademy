using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AnimalHierarchy.Enums;

namespace AnimalHierarchy
{
    public abstract class Cat : Animal
    {
        protected static readonly Sex tomcatsSex = Sex.Male;
        protected static readonly Sex kittensSex = Sex.Female;

        protected Cat(string name, int age) : base(name, age)
        {
            this.Name = name;
            this.Age = age;
        }

        public override void ProduceSound()
        {
            Console.WriteLine("Miau miau!!!");
        }
    }
}