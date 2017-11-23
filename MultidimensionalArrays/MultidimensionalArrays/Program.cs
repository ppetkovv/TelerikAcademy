using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultidimensionalArrays
{
    class Program
    {
        private static int currentLength;
        static void Main(string[] args)
        {

            //First Task

            //int N = Int32.Parse(Console.ReadLine());
            //int[,] matrix = new int[N, N];

            //switch (Console.Read())
            //{
            //    case 'a':
            //        Program.FillMatrixUsingA(matrix);
            //        break;
            //    case 'b':
            //        Program.FillMatrixUsingB(matrix);
            //        break;
            //    case 'c':
            //        Program.FillMatrixUsingC(matrix);
            //        break;
            //    case 'd':
            //        Program.FillMatrixUsingD(matrix);
            //        break;
            //    default:
            //        break;
            //}

            //Program.PrintMatrix(matrix);

            //Second Task

            //int[] nAndM = Console.ReadLine().Split().Select(Int32.Parse).ToArray();
            //int[,] rectMatrix = new int[nAndM[0], nAndM[1]];

            //int[] currentRowValues; ;
            //for (int row = 0; row < rectMatrix.GetLength(0); row++)
            //{
            //    currentRowValues = Console.ReadLine().Split().Select(Int32.Parse).ToArray();
            //    for (int col = 0; col < rectMatrix.GetLength(1); col++)
            //    {
            //        rectMatrix[row, col] = currentRowValues[col];
            //    }
            //}

            //int bestSum = Int32.MinValue;
            //int currentSum = 0;


            //for (int row = 0; row < rectMatrix.GetLength(0) - 2; row++)
            //{
            //    for (int col = 0; col < rectMatrix.GetLength(1) - 2; col++)
            //    {
            //        currentSum = rectMatrix[row, col] + rectMatrix[row, col + 1] + rectMatrix[row, col + 2] +
            //            rectMatrix[row + 1, col] + rectMatrix[row + 1, col + 1] + rectMatrix[row + 1, col + 2] +
            //            rectMatrix[row + 2, col] + rectMatrix[row + 2, col + 1] + rectMatrix[row + 2, col + 2];
            //        if (currentSum > bestSum)
            //        {
            //            bestSum = currentSum;
            //        }
            //    }
            //}

            //Console.WriteLine(bestSum);

            //Third Task

            //int[] nAndM = Console.ReadLine().Split().Select(Int32.Parse).ToArray();
            //if(nAndM[0] < 3 || nAndM[1] > 128)
            //{
            //    return;
            //}
            //string[,] matrix = new string[nAndM[0], nAndM[1]];

            //string[] currentRow;
            //for (int row = 0; row < matrix.GetLength(0); row++)
            //{
            //    currentRow = Console.ReadLine().Split();
            //    for (int col = 0; col < matrix.GetLength(1); col++)
            //    {
            //        matrix[row, col] = currentRow[col];
            //    }
            //}

            //int bestLength = Int32.MinValue;
            //int bestHorizontalSearch = Program.BestHorizontalSearch(matrix);
            //if (bestHorizontalSearch > bestLength)
            //{
            //    bestLength = bestHorizontalSearch;
            //}
            //int bestVerticalSearch = Program.BestVerticalSearch(matrix);
            //if (bestVerticalSearch > bestLength)
            //{
            //    bestLength = bestVerticalSearch;
            //}
            //int bestLeftDiagonalsSearch = Program.BestLeftDiagonalsSearch(matrix);
            //if (bestLeftDiagonalsSearch > bestLength)
            //{
            //    bestLength = bestLeftDiagonalsSearch;
            //}
            //int bestRightDiagonalsSearch = Program.BestRightDiagonalsSearch(matrix);
            //if (bestRightDiagonalsSearch > bestLength)
            //{
            //    bestLength = bestRightDiagonalsSearch;
            //}

            //Console.WriteLine(bestLength);

            //Fourth Task

            //int[] someNums = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(Int32.Parse).ToArray();
            //int k = Int32.Parse(Console.ReadLine());
            //someNums = someNums.OrderBy(x => x).ToArray();
            //int index = -1;
            //for (int i = k; i >= 0; i--)
            //{
            //    index = Array.BinarySearch(someNums, i);
            //    if (index > -1)
            //    {
            //        break;
            //    }
            //}
            //if (index == -1)
            //{
            //    Console.WriteLine("There is no largest number equal or smaller than {0}!", k);
            //}
            //else
            //{
            //    Console.WriteLine("The largest number smaller or equal to {0} in the array is: {1}", k, someNums[index]);
            //}

            //Fifth Task

            //string[] arrayOfStrings = Console.ReadLine().Split().ToArray();
            //Console.WriteLine(string.Join(", ", arrayOfStrings.OrderBy(elem => elem.Length).ToArray()));

            //Sixth Task

            int[] nAndM = Console.ReadLine().Split().Select(Int32.Parse).ToArray();
            int[,] matrix = new int[nAndM[0], nAndM[1]];

            int[] currentRowNums;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                currentRowNums = Console.ReadLine().Split().Select(Int32.Parse).ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = currentRowNums[col];
                }
            }

            List<string> indexes = new List<string>();
            int bestLength = 0;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    currentLength++;
                    Program.RecursionSearching(matrix, row, col, indexes);
                    if (currentLength > bestLength)
                    {
                        bestLength = currentLength;
                    }
                    currentLength = 0;
                }
            }

            Console.WriteLine(bestLength);
        }

        private static void RecursionSearching(int[,] matrix, int row, int col, List<string> indexes)
        {
            if ((row - 1 < 0 || matrix[row - 1, col] != matrix[row, col]) && (row + 1 >= matrix.GetLength(0) || matrix[row + 1, col] != matrix[row, col]) && (col - 1 < 0 || matrix[row, col - 1] != matrix[row, col]) && (col + 1 >= matrix.GetLength(1) || matrix[row, col + 1] != matrix[row, col]))
            {
                return;
            }
            if (row - 1 >= 0 && matrix[row - 1, col] == matrix[row, col] && !indexes.Contains(row - 1 + "" + col))
            {
                indexes.Add(row + "" + col);
                currentLength++;
                Program.RecursionSearching(matrix, row - 1, col, indexes);
            }
            if (row + 1 < matrix.GetLength(0) && matrix[row + 1, col] == matrix[row, col] && !indexes.Contains(row + 1 + "" + col))
            {
                indexes.Add(row + "" + col);
                currentLength++;
                Program.RecursionSearching(matrix, row + 1, col, indexes);
            }
            if (col - 1 >= 0 && matrix[row, col - 1] == matrix[row, col] && !indexes.Contains(row + "" + (col - 1)))
            {
                indexes.Add(row + "" + col);
                currentLength++;
                Program.RecursionSearching(matrix, row, col - 1, indexes);
            }
            if (col + 1 < matrix.GetLength(1) && matrix[row, col + 1] == matrix[row, col] && !indexes.Contains(row + "" + (col + 1)))
            {
                indexes.Add(row + "" + col);
                currentLength++;
                Program.RecursionSearching(matrix, row, col + 1, indexes);
            }
        }

        private static int BestRightDiagonalsSearch(string[,] matrix)
        {
            int bestSum = Int32.MinValue;
            int currentSum = 1;

            for (int row = matrix.GetLength(0) - 2; row >= 0; row--)
            {
                for (int secRow = row, col = matrix.GetLength(1)-1; secRow < matrix.GetLength(0) - 1; secRow++, col--)
                {
                    if (matrix[secRow, col].Equals(matrix[secRow + 1, col - 1]))
                    {
                        currentSum++;
                    }
                    else
                    {
                        if (currentSum != 1 && currentSum > bestSum)
                        {
                            bestSum = currentSum;
                            currentSum = 1;
                        }
                        currentSum = 1;
                    }
                }
                if (currentSum != 1 && currentSum > bestSum)
                {
                    bestSum = currentSum;
                    currentSum = 1;
                }
                currentSum = 1;
            }

            for (int col = matrix.GetLength(1) - 2; col >= 1; col--)
            {
                for (int secCol = col, row = 0; secCol >= 1; secCol--,row++)
                {
                    if(matrix[row,secCol].Equals(matrix[row+1,secCol-1]))
                    {
                        currentSum++;
                    }
                    else
                    {
                        if (currentSum != 1 && currentSum > bestSum)
                        {
                            bestSum = currentSum;
                            currentSum = 1;
                        }
                        currentSum = 1;
                    }
                }
                if (currentSum != 1 && currentSum > bestSum)
                {
                    bestSum = currentSum;
                    currentSum = 1;
                }
                currentSum = 1;
            }

            return bestSum;
        }

        private static int BestLeftDiagonalsSearch(string[,] matrix)
        {
            int bestSum = Int32.MinValue;
            int currentSum = 1;

            for (int row = matrix.GetLength(0) - 2; row >= 0; row--)
            {
                for (int secRow = row, col = 0; secRow < matrix.GetLength(0) - 1; secRow++, col++)
                {
                    if (matrix[secRow, col].Equals(matrix[secRow + 1, col + 1]))
                    {
                        currentSum++;
                    }
                    else
                    {
                        if (currentSum != 1 && currentSum > bestSum)
                        {
                            bestSum = currentSum;
                            currentSum = 1;
                        }
                        currentSum = 1;
                    }
                }
                if (currentSum != 1 && currentSum > bestSum)
                {
                    bestSum = currentSum;
                    currentSum = 1;
                }
                currentSum = 1;
            }

            for (int col = 1; col < matrix.GetLength(1); col++)
            {
                for (int secCol = col, row = 0; secCol < matrix.GetLength(1) - 1; secCol++, row++)
                {
                    if(matrix[row,secCol].Equals(matrix[row+1,secCol+1]))
                    {
                        currentSum++;
                    }
                    else
                    {
                        if (currentSum != 1 && currentSum > bestSum)
                        {
                            bestSum = currentSum;
                            currentSum = 1;
                        }
                        currentSum = 1;
                    }
                }
                if (currentSum != 1 && currentSum > bestSum)
                {
                    bestSum = currentSum;
                    currentSum = 1;
                }
                currentSum = 1;
            }

            return bestSum;
        }

        private static int BestVerticalSearch(string[,] matrix)
        {
            int bestSum = Int32.MinValue;
            int currentSum = 1;

            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                for (int row = 1; row < matrix.GetLength(0); row++)
                {
                    if (matrix[row, col].Equals(matrix[row - 1, col]))
                    {
                        currentSum++;
                    }
                    else
                    {
                        if (currentSum != 1 && currentSum > bestSum)
                        {
                            bestSum = currentSum;
                            currentSum = 1;
                        }
                        currentSum = 1;
                    }
                }
                if (currentSum != 1 && currentSum > bestSum)
                {
                    bestSum = currentSum;
                    currentSum = 1;
                }
                currentSum = 1;
            }

            return bestSum;
        }

        private static int BestHorizontalSearch(string[,] matrix)
        {
            int bestSum = Int32.MinValue;
            int currentSum = 1;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 1; col < matrix.GetLength(1); col++)
                {
                    if (matrix[row, col].Equals(matrix[row, col - 1]))
                    {
                        currentSum++;
                    }
                    else
                    {
                        if (currentSum != 1 && currentSum > bestSum)
                        {
                            bestSum = currentSum;
                            currentSum = 1;
                        }
                        currentSum = 1;
                    }
                }
                if (currentSum != 1 && currentSum > bestSum)
                {
                    bestSum = currentSum;
                    currentSum = 1;
                }
                currentSum = 1;
            }
            return bestSum;
        }

        private static void FillMatrixUsingD(int[,] matrix)
        {
            int row = 0;
            int col = 0;

            bool isDown = true;
            bool isRight = false;
            bool isUp = false;
            bool isLeft = false;

            int counter = 1;

            while (counter <= matrix.GetLength(0) * matrix.GetLength(0))
            {
                matrix[row, col] = counter;

                if (isDown)
                {
                    if (row + 1 >= matrix.GetLength(0) || matrix[row + 1, col] != 0)
                    {
                        isDown = false;
                        isRight = true;
                        col++;
                    }
                    else
                    {
                        row++;
                    }
                }
                else if (isRight)
                {
                    if (col + 1 >= matrix.GetLength(1) || matrix[row, col + 1] != 0)
                    {
                        isRight = false;
                        isUp = true;
                        row--;
                    }
                    else
                    {
                        col++;
                    }
                }
                else if (isUp)
                {
                    if (row - 1 < 0 || matrix[row - 1, col] != 0)
                    {
                        isUp = false;
                        isLeft = true;
                        col--;
                    }
                    else
                    {
                        row--;
                    }
                }
                else if (isLeft)
                {
                    if (col - 1 < 0 || matrix[row, col - 1] != 0)
                    {
                        isLeft = false;
                        isDown = true;
                        row++;
                    }
                    else
                    {
                        col--;
                    }
                }
                counter++;
            }
        }

        private static void FillMatrixUsingC(int[,] matrix)
        {
            int counter = 1;
            for (int row = matrix.GetLength(0) - 1; row >= 0; row--)
            {
                for (int secRow = row, col = 0; secRow < matrix.GetLength(0); secRow++, col++, counter++)
                {
                    matrix[secRow, col] = counter;
                }
            }

            for (int col = 1; col < matrix.GetLength(1); col++)
            {
                for (int secCol = col, row = 0; secCol < matrix.GetLength(1); secCol++, row++, counter++)
                {
                    matrix[row, secCol] = counter;
                }
            }
        }

        private static void FillMatrixUsingB(int[,] matrix)
        {
            int counter = 1;
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                if (col % 2 == 0)
                {
                    for (int row = 0; row < matrix.GetLength(0); row++, counter++)
                    {
                        matrix[row, col] = counter;
                    }
                }
                else
                {
                    for (int row = matrix.GetLength(0) - 1; row >= 0; row--,counter++)
                    {
                        matrix[row, col] = counter;
                    }
                }
            }
        }

        private static void FillMatrixUsingA(int[,] matrix)
        {
            int counter = 1;
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                for (int row = 0; row < matrix.GetLength(0); row++,counter++)
                {
                    matrix[row, col] = counter;
                }
            }
        }

        private static void PrintMatrix(int[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                Console.Write(matrix[row, 0]);
                for (int col = 1; col < matrix.GetLength(1); col++)
                {
                    Console.Write(" " + matrix[row, col]);
                }
                Console.WriteLine();
            }
        }

    }
}