using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourthTask
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> someNums = new List<int>() { 1, 1, 1, 2, 2, 3, 3, 3, 3, 4, 4,4,4, 4, 5, 6, 7, 7, 7 };

            IList<int> longestSubsequence = FindingLongestSubsequenceOfEqual(someNums);
            foreach (var item in longestSubsequence)
            {
                Console.Write(item+" ");
            }
            Console.WriteLine();
        }

        private static IList<int> FindingLongestSubsequenceOfEqual(List<int> someNums)
        {
            int longestSubsequenceCount = 1;
            int longestSubsequenceStartIndex = 0;
            int currentSubsequenceCount = 1;
            for (int i = 0; i < someNums.Count - 1; i++)
            {
                if(someNums[i] == someNums[i+1])
                {
                    currentSubsequenceCount++;
                }
                else if(someNums[i] !=someNums[i+1] && currentSubsequenceCount != 1)
                {
                    if (currentSubsequenceCount > longestSubsequenceCount)
                    {
                        longestSubsequenceCount = currentSubsequenceCount;
                        longestSubsequenceStartIndex = i - (longestSubsequenceCount - 1);
                    }
                    currentSubsequenceCount = 1;
                }
            }

            return someNums.GetRange(longestSubsequenceStartIndex, longestSubsequenceCount);
        }
    }
}
