using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SixthTask
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> someNums = new List<int>() { 4, 2, 2, 5, 2, 3, 2, 3, 1, 5, 2 };

            List<int> distinctElements = someNums.Distinct().ToList();
            for (int i = 0; i < distinctElements.Count; i++)
            {
                int currentSequenceOfEqualElementsCount = someNums.Where(x => x == distinctElements[i]).Count();
                if (currentSequenceOfEqualElementsCount % 2 != 0)
                {
                    someNums = someNums.Where(x => x != distinctElements[i]).ToList();
                }
            }

            Console.WriteLine(string.Join(", ", someNums));
        }
    }
}
