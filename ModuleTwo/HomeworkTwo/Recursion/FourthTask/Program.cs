using System;
using System.Linq;

namespace FourthTask
{
    class Program
    {
        private static int N;
        private static int[] arr;

        static void Main(string[] args)
        {
            N = Int32.Parse(Console.ReadLine());
            arr = new int[N];
            CombinationWithDuplicates(0);
        }

        private static void CombinationWithDuplicates(int currentIndex)
        {
            if (currentIndex == arr.Length)
            {
                if (arr.Length == arr.ToList().Distinct().Count())
                    Console.WriteLine(string.Join(" ", arr));
                return;
            }

            for (int i = 1; i <= N; i++)
            {
                arr[currentIndex] = i;
                CombinationWithDuplicates(currentIndex + 1);
            }
        }
    }
}