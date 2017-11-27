using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace FourteenthTask
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(Int32.Parse).ToArray();
            Console.WriteLine(string.Format("{0}\n{1}\n{2:F2}\n{3}\n{4}", GetMin(numbers), GetMax(numbers), GetAverage(numbers), GetSum(numbers), GetProduct(numbers))); 
        }

        private static int GetMin(int[] numbers)
        {
            return numbers.Min();            
        }

        private static int GetMax(int[] numbers)
        {
            return numbers.Max();
        }

        private static double GetAverage(int[] numbers)
        {
            double average = numbers.Sum() / (double)numbers.Length;
            return average;
        }

        private static BigInteger GetSum(int[] numbers)
        {
            return (BigInteger)numbers.Sum();
        }

        private static BigInteger GetProduct(int[] numbers)
        {
            BigInteger product = 1;
            for (int i = 0; i < numbers.Length; i++)
            {
                product *= numbers[i];
            }
            return product;
        }

    }
}
