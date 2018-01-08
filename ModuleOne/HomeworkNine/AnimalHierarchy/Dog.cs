using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AnimalHierarchy.Enums;

namespace AnimalHierarchy
{
    class Dog : Animal
    {
        public Dog(string name, int age) : base(name, age)
        {
        }

        public Dog(string name, int age, Sex sex) : base(name, age, sex)
        {
        }

        public override void ProduceSound()
        {
            Console.WriteLine("Bau bau!!!");
        }
    }
}
