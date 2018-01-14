using System;
using System.Linq;

namespace FourthTask
{
    class Program
    {
        private static int K;
        private static string[] elements;
        private static int[] elementsIndexes;
        private static int startIndex = 0;

        static void Main(string[] args)
        {
            elements = Console.ReadLine().Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            K = Int32.Parse(Console.ReadLine());
            elementsIndexes = new int[K];
            AllSubsetsOfStrings(0,ref startIndex);
        }

        private static void AllSubsetsOfStrings(int currentIndex, ref int startIndex)
        {
            if (currentIndex == elementsIndexes.Length)
            {
                if (elementsIndexes.Length == elementsIndexes.ToList().Distinct().Count())
                    Console.WriteLine(string.Join(" ", elementsIndexes.ToArray().Select(x => elements[x])));
                return;
            }

            for (int i = startIndex; i < elementsIndexes.Length; i++)
            {
                elementsIndexes[currentIndex] = i;
                AllSubsetsOfStrings(currentIndex + 1,ref startIndex);
            }
            startIndex++;
        }
    }
}
