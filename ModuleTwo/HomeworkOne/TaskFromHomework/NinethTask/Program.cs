using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NinethTask
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = Int32.Parse(Console.ReadLine());
            List<int> sequence = new List<int>();
            sequence.Add(N);
            int currentIndex = 0;

            while (sequence.Count <= 50)
            {
                sequence.Add(sequence[currentIndex] + 1);
                sequence.Add(2 * sequence[currentIndex] + 1);
                sequence.Add(sequence[currentIndex] + 2);
                currentIndex++;
            }

            Console.WriteLine(string.Join(", ", sequence));
        }
    }
}