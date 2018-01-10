using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstTask
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> sequence = new List<int>();
            string currentLine = Console.ReadLine();
            while (!currentLine.Equals(string.Empty))
            {
                sequence.Add(Int32.Parse(currentLine));
                currentLine = Console.ReadLine();
            }
            Console.WriteLine($"Sum: {sequence.Sum()}");
            Console.WriteLine($"Average: {sequence.Average()}");
        }
    }
}
