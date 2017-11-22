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
