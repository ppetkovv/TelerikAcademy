using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEntranceExamAnotherGroup
{
    class Program
    {
        static void Main(string[] args)
        {
            //First Task

            //string inputValue = Console.ReadLine();
            //int currentSum = inputValue.Where(elem => elem >= 48 && elem <= 57).Select(elem => Int32.Parse(elem.ToString())).Sum();
            //while(currentSum > 9)
            //    currentSum = currentSum.ToString().Select(elem => Int32.Parse(elem.ToString())).Sum();
            //Console.WriteLine(currentSum);

            //Second Task

            //long firstBrick = Int64.Parse(Console.ReadLine());
            //long secondBrick = Int64.Parse(Console.ReadLine());
            //long thirdBrick = Int64.Parse(Console.ReadLine());
            //long[][] jaggedArray = new long[Int32.Parse(Console.ReadLine())][];
            //jaggedArray[0] = new long[] { firstBrick };
            //jaggedArray[1] = new long[] { secondBrick, thirdBrick };
            //List<long> allBricksOnASingleLine = new List<long>(new long[] { firstBrick, secondBrick, thirdBrick });
            //int currentBrick = 4;
            //for (int currentArray = 2; currentArray < jaggedArray.Length; currentArray++)
            //{
            //    jaggedArray[currentArray] = new long[jaggedArray[currentArray - 1].Length + 1];
            //    for (int i = 0; i < jaggedArray[currentArray].Length; i++)
            //    {
            //        jaggedArray[currentArray][i] = allBricksOnASingleLine[currentBrick - 2] + allBricksOnASingleLine[currentBrick - 3] + allBricksOnASingleLine[currentBrick - 4];
            //        allBricksOnASingleLine.Add(jaggedArray[currentArray][i]);
            //        currentBrick++;
            //    }
            //}
            //for (int i = 0; i < jaggedArray.Length; i++)
            //    Console.WriteLine(string.Join(" ", jaggedArray[i]));

            //Third Task

            //int[] allNumbers = Console.ReadLine().Split(new char[] { ' ' }).Select(elem => Int32.Parse(elem)).ToArray();
            //if ((allNumbers.Length < 2 || allNumbers.Length > 200))
            //{
            //    return;
            //}

            //int[] allNumbersDistanceDifferences = new int[allNumbers.Length - 1];
            //for (int i = 1; i < allNumbers.Length; i++)
            //{
            //    allNumbersDistanceDifferences[i - 1] = allNumbers[i] - allNumbers[i - 1] < 0 ? (allNumbers[i] - allNumbers[i - 1]) * (-1) : allNumbers[i] - allNumbers[i - 1];
            //    if (allNumbersDistanceDifferences[i - 1] % 2 == 0)
            //    {
            //        i++;
            //    }
            //}

            //Console.WriteLine(allNumbersDistanceDifferences.Where(elem => elem % 2 == 0).Sum());
        }
    }
}