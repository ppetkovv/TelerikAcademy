using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SixthTask
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = Int32.Parse(Console.ReadLine());
            int[] numbers = Console.ReadLine().Split().Select(Int32.Parse).ToArray();

            int indexOfFirstBiggerThanItsNeighboars = -1;
            for (int i = 1; i < numbers.Length - 1; i++)
            {
                if (numbers[i] > numbers[i - 1] && numbers[i] > numbers[i + 1])
                {
                    indexOfFirstBiggerThanItsNeighboars = i;
                    break;
                }
            }

            Console.WriteLine(indexOfFirstBiggerThanItsNeighboars);
        }
    }
}
