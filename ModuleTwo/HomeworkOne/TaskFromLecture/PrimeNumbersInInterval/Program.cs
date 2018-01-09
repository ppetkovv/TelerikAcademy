using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumbersInInterval
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> allPrimesInInterval = new List<int>();
            for (int i = 200; i <= 300; i++)
            {
                int divider = 2;
                int currentNumberSqrt = (int)Math.Sqrt(i);
                bool isPrime = true;

                while (isPrime && divider <= currentNumberSqrt)
                {
                    if (i % divider == 0)
                    {
                        isPrime = false;
                    }
                    divider++;
                }
                if (isPrime)
                {
                    allPrimesInInterval.Add(i);
                }
            }
            foreach (int num in allPrimesInInterval)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }
    }
}