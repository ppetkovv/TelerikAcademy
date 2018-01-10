using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdTask
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> sequenceOfNums = new List<int>();
            string currentLine = Console.ReadLine();
            while (!currentLine.Equals(string.Empty))
            {
                sequenceOfNums.Add(Int32.Parse(currentLine));
                currentLine = Console.ReadLine();
            }

            Console.WriteLine(string.Join(", ", sequenceOfNums.OrderBy(x => x)));
        }
    }
}