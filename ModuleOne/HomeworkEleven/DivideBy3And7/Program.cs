using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DivideBy3And7
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayOfNums = { 1, 2, 4, 6, 7, 9, 12, 43, 56, 87, 90, 35, 21, 73 };
            Console.WriteLine(string.Join(", ", arrayOfNums.Where(currentNum => (currentNum % 3 == 0) && (currentNum % 7 == 0)).Select(currentNumber => Convert.ToString(currentNumber)).ToArray()));
        }
    }
}