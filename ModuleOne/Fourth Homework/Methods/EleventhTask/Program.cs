using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EleventhTask
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = Int32.Parse(Console.ReadLine());
            int[] firstArray = Console.ReadLine().Split().Select(Int32.Parse).ToArray();
            int[] secondArray = Console.ReadLine().Split().Select(Int32.Parse).ToArray();

            int[] resultedArray = SumPolinomial(firstArray, secondArray);
            PrintSummedPolinomial(resultedArray);
        }

        private static int[] SumPolinomial(int[] firstArray, int[] secondArray)
        {
            int[] resultedArray = new int[firstArray.Length];
            for (int i = 0; i < resultedArray.Length; i++)
            {
                resultedArray[i] = firstArray[i] + secondArray[i];
            }
            return resultedArray;
        }

        private static void PrintSummedPolinomial(int[] resultedArray)
        {
            Console.Write(resultedArray[0]);
            for (int i = 1; i < resultedArray.Length; i++)
            {
                Console.Write(" " + resultedArray[i]);
            }
        }
    }
}