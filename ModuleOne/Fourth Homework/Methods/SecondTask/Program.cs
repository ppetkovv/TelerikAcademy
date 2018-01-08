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
            int[] threeNumbers = Console.ReadLine().Split().Select(Int32.Parse).ToArray();
            int biggerNumber = Program.GetMax(threeNumbers[0], threeNumbers[1]);
            Console.WriteLine(Program.GetMax(biggerNumber, threeNumbers[2]));
        }
        private static int GetMax(int firstNum, int secondNum)
        {
            int biggerNumber = firstNum;
            if(secondNum > biggerNumber)
            {
                biggerNumber = secondNum;
            }
            return biggerNumber;
        }
    }
}
