using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEntranceExamMyGroup
{
    class Program
    {
        static void Main(string[] args)
        {
            //First Task

            //int year = Int32.Parse(Console.ReadLine());
            //int month = Int32.Parse(Console.ReadLine());
            //int day = Int32.Parse(Console.ReadLine());

            //DateTime currentDate = new DateTime(year, month, day);
            //currentDate = currentDate.AddDays(-1);
            //string format = "d-MMM-yyyy";
            //Console.WriteLine(currentDate.ToString(format));

            //Second Task

            //int N = Int32.Parse(Console.ReadLine());
            //List<int> allPrimeNums = new List<int>();
            //for (int i = 1; i <= N; i++)
            //{
            //    if (FindPrime(i))
            //    {
            //        allPrimeNums.Add(i);
            //    }
            //}

            //for (int i = 1; i <= allPrimeNums.Count; i++)
            //{
            //    for (int j = 1; j <= allPrimeNums[i - 1]; j++)
            //    {
            //        if (FindPrime(j))
            //        {
            //            Console.Write(1);
            //        }
            //        else
            //        {
            //            Console.Write(0);
            //        }
            //    }
            //    Console.WriteLine();
            //}

            //Third Task

            //    int[] fieldWithCarrots = Console.ReadLine().Split(new char[] { ',', ' ' },StringSplitOptions.RemoveEmptyEntries).Select(item => Int32.Parse(item.ToString())).ToArray();
            //    if (fieldWithCarrots.Length < 1 || fieldWithCarrots.Length > 10000)
            //    {
            //        return;
            //    }
            //    int M = Int32.Parse(Console.ReadLine());
            //    if(M < 1 || M > 500)
            //    {
            //        return;
            //    }

            //    int[] currentDirections = null;
            //    int bestSum = Int32.MinValue;
            //    for (int i = 0; i < M; i++)
            //    {
            //        currentDirections = Console.ReadLine().Split(new char[] { ' ', ',' },StringSplitOptions.RemoveEmptyEntries).Select(item => Int32.Parse(item.ToString())).ToArray();
            //        if ((currentDirections.Length > 100) || !currentDirections.All(num => (num >= -1000 && num <= 1000)))
            //        {
            //            return;
            //        }
            //        int currentDirectionsSum = 0;
            //        int currentIndex = 0;
            //        List<int> currentlyUsedIndexes = new List<int>();
            //        bool mustContinue = true;
            //        for (;mustContinue;)
            //        {
            //            for (int j = 0; j < currentDirections.Length; j++)
            //            {
            //                currentDirectionsSum += fieldWithCarrots[currentIndex];
            //                currentlyUsedIndexes.Add(currentIndex);
            //                currentIndex += currentDirections[j];
            //                if((currentIndex < 0 || currentIndex >= fieldWithCarrots.Length)||(currentlyUsedIndexes.Contains(currentIndex)))
            //                {
            //                    mustContinue = false;
            //                    break;
            //                }
            //            }
            //        }
            //        if(currentDirectionsSum > bestSum)
            //        {
            //            bestSum = currentDirectionsSum;
            //        }
            //        currentDirectionsSum = 0;
            //    }

            //    Console.WriteLine(bestSum);
        }

        //private static bool FindPrime(int i)
        //{
        //    int currentPrimeCandidate = i;
        //    int currentPrimeCandidateSqrt = (int)Math.Sqrt(currentPrimeCandidate);
        //    bool isPrime = true;
        //    int divider = 2;

        //    while ((isPrime) && (divider <= currentPrimeCandidateSqrt))
        //    {
        //        if (currentPrimeCandidate % divider == 0)
        //        {
        //            isPrime = false;
        //        }
        //        divider++;
        //    }
        //    if (isPrime)
        //    {
        //        return true;
        //    }
        //    return false;
        //}
    }
}