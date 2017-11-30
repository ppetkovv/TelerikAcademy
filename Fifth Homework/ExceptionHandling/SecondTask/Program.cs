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
            try
            {
                Program.ReadNumber();
            }
            catch (Exception)
            {
                Console.WriteLine("Exception");
            }
        }

        private static void ReadNumber()
        {
            int[] arrayOfNums = { 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 100 };
            for (int i = 1; i < arrayOfNums.Length - 1; i++)
            {
                try
                {
                    arrayOfNums[i] = Int32.Parse(Console.ReadLine());
                    if (arrayOfNums[i] <= arrayOfNums[i - 1])
                    {
                        throw new ArgumentException();
                    }
                }
                catch (Exception)
                {
                    throw new Exception();
                }
            }

            Console.WriteLine(string.Join(" < ", arrayOfNums.Select(elem => elem.ToString()).ToArray()));
        }
    }
}