using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FifthTask
{
    class Program
    {
        private static int N;
        private static int K;
        private static string[] set;
        private static int[] setIndexes;

        static void Main(string[] args)
        {
            N = Int32.Parse(Console.ReadLine());
            K = Int32.Parse(Console.ReadLine());
            set = Console.ReadLine().Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            setIndexes = new int[K];

            SetVariations(0);
        }

        private static void SetVariations(int currentIndex)
        {
            if (currentIndex == setIndexes.Length)
            {
                Console.WriteLine(string.Join(" ", setIndexes.ToArray().Select(x => set[x])));
                return;
            }

            for (int i = 0; i < N; i++)
            {
                setIndexes[currentIndex] = i;
                SetVariations(currentIndex + 1);
            }
        }
    }
}