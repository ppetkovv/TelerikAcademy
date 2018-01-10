using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FifthTask
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> someNums = new List<int>() { 1, -1, 2, -2, 3, -3, 4, -4, 5, -5, 6, -6, 7, -7, 8, -8, 9, -9, 10, -10 };
            someNums = someNums.Where(x => x >= 0).ToList();
            Console.WriteLine(string.Join(", ", someNums));
        }
    }
}
