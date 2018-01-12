using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstTask
{
    class Program
    {
        private static int[] arr;
        private static int N;

        static void Main(string[] args)
        {
            N = Int32.Parse(Console.ReadLine());
            arr = new int[N];
            NestedLoopSimulator(0);
        }

        private static void NestedLoopSimulator(int currentIndex)
        {
            if(currentIndex == arr.Length)
            {
                Console.WriteLine(string.Join(" ", arr));
                return;
            }
            for (int i = 1; i <= N; i++)
            {
                arr[currentIndex] = i;
                NestedLoopSimulator(currentIndex+1);
            }
        }
    }
}
