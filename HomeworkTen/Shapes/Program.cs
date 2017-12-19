using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shapes.Contracts;

namespace Shapes
{
    class Program
    {
        static void Main(string[] args)
        {
            IShape[] someShapes = { new Square(4), new Rectangle(3, 4), new Triangle(4, 5) };

            foreach (IShape shape in someShapes)
            {
                Console.WriteLine($"Surface of {shape.GetType().Name} is: {shape.CalculateSurface()}");
            }
        }
    }
}