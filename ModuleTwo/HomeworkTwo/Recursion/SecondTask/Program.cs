using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondTask
{
    class Program
    {
        private static int N;
        private static int K;
        private static int[] arr;
        private static int currentStartIndex = 1;

        static void Main(string[] args)
        {
            N = Int32.Parse(Console.ReadLine());
            K = Int32.Parse(Console.ReadLine());
            arr = new int[K];
            CombinationWithDuplicates(0, ref currentStartIndex);
        }

        private static void CombinationWithDuplicates(int currentIndex,ref int startIndex)
        {
            if (currentIndex == arr.Length)
            {
                Console.WriteLine(string.Join(" ", arr));
                return;
            }

            for (int i = startIndex; i <= N; i++)
            {
                arr[currentIndex] = i;
                CombinationWithDuplicates(currentIndex + 1,ref startIndex);
            }
            startIndex = ++currentStartIndex;
        }
    }
}