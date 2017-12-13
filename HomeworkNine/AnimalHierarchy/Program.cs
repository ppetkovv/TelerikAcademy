using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AnimalHierarchy.Contracts;

namespace AnimalHierarchy
{
    class Program
    {
        static void Main(string[] args)
        {
            IAnimal[] dogs = new Dog[] { new Dog("Roki",13), new Dog("Lassie",5), new Dog("Kiro",10)
            ,new Dog("Miro",6), new Dog("Lucky",7)};
            Console.WriteLine("Average age (Dogs): {0}", dogs.Sum(dog => dog.Age) / (decimal)dogs.Length);

            IAnimal[] frogs = new Frog[] { new Frog("Franklin",13), new Frog("Lilly",5), new Frog("Smiley",10)
            ,new Frog("Johnny",6), new Frog("Daisy",7)};
            Console.WriteLine("Average age (Frogs): {0}", frogs.Sum(frog => frog.Age) / (decimal)frogs.Length);

            IAnimal[] kittens = new Kitten[] { new Kitten("Ema",13), new Kitten("Princes",5), new Kitten("Chera",10)
            ,new Kitten("Tweety",6), new Kitten("Puppy",7)};
            Console.WriteLine("Average age (Kittens): {0}", kittens.Sum(kitty => kitty.Age) / (decimal)kittens.Length);

            IAnimal[] tomcats = new Tomcat[] { new Tomcat("Serafim",13), new Tomcat("Garfield",5), new Tomcat("Johhny",10)
            ,new Tomcat("Steve",6), new Tomcat("Rijo",7)};
            Console.WriteLine("Average age (Tomcats): {0}", tomcats.Sum(tomcat => tomcat.Age) / (decimal)tomcats.Length);
        }
    }
}