using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Program.ReadNumber();
        }

        private static void ReadNumber()
        {
            int[] arrayOfNums = new int[10];
            for (int i = 0; i < arrayOfNums.Length; i++)
            {
                arrayOfNums[i] = Int32.Parse(Console.ReadLine());
            }

            if (!arrayOfNums.OrderBy(x => x).SequenceEqual(arrayOfNums))
            {
                throw new FormatException();
            }

            StringBuilder result = new StringBuilder();
            result.Append("1 < ");
            for (int i = 0; i < arrayOfNums.Length; i++)
            {
                result.Append(arrayOfNums[i]).Append(" < ");
            }
            result.Append("100");
            Console.WriteLine(result.ToString());
        }
    }
}