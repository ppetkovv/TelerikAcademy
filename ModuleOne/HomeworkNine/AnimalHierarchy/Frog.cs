using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AnimalHierarchy.Enums;

namespace AnimalHierarchy
{
    class Frog : Animal
    {
        public Frog(string name, int age) : base(name, age)
        {
        }

        public Frog(string name, int age, Sex sex) : base(name, age, sex)
        {
        }

        public override void ProduceSound()
        {
            Console.WriteLine("Quak quak!!!");
        }
    }
}
