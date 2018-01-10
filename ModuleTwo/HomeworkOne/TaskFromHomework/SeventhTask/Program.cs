using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeventhTask
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] someNums = { 3, 4, 4, 2, 3, 3, 4, 3, 2 };
            List<int> distinctElements = someNums.ToList().Distinct().ToList();
            SortedDictionary<int, int> dictionary = new SortedDictionary<int, int>();

            for (int i = 0; i < distinctElements.Count; i++)
            {
                int currentElementCount = someNums.Where(x => x == distinctElements[i]).Count();
                if (currentElementCount > 0 && currentElementCount < 1000)
                {
                    dictionary.Add(distinctElements[i], currentElementCount);
                }
            }

            foreach (var item in dictionary)
            {
                Console.WriteLine($"{item.Key} -> {item.Value} times");
            }

        }
    }
}
