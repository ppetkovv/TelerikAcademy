using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourthTask
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = Int32.Parse(Console.ReadLine());
            int[] numbers = Console.ReadLine().Split().Select(Int32.Parse).ToArray();
            int X = Int32.Parse(Console.ReadLine());

            Program.FindNumberAppereances(numbers, X);
        }

        private static void FindNumberAppereances(int[] numbers, int checkedNumber)
        {
            Console.WriteLine(numbers.Where(currentNum => currentNum == checkedNumber).Count());
        }
    }
}
