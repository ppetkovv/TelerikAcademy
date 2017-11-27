using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeventhTask
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal decimalNumber = Decimal.Parse(Console.ReadLine());
            Console.WriteLine(new string(decimalNumber.ToString().Reverse().ToArray()));
        }
    }
}
