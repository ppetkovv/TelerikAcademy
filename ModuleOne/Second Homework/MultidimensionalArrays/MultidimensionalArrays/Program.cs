using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultidimensionalArrays
{
    class Program
    {
        //Sixth Task

        //private static int[,] originalMatrix;
        //private static bool[,] usedIndexes;
        //private static int currentLength;
        //private static int bestLength;

        //Sixth Task --- My Way

        //private static int[,] matrix;
        //private static bool[,] usedIndex;
        //private static int bestLength;
        //private static int currentLength;
        //private static int targetValue;

        //Seventh Task

        //private static int[] rows = { -1, -1, 1, 1 };
        //private static int[] cols = { -1, 1, 1, -1 };

        //private static int GetMoves(string dir)
        //{
        //    switch (dir)
        //    {
        //        case "LU":
        //            return 0;
        //        case "UL":
        //            return 0;
        //        case "UR":
        //            return 1;
        //        case "RU":
        //            return 1;
        //        case "DR":
        //            return 2;
        //        case "RD":
        //            return 2;
        //        case "DL":
        //            return 3;
        //        case "LD":
        //            return 3;
        //        default:
        //            throw new ArgumentException();
        //    }
        //}

        //Seventh Task --- My Way

        //private static int[] rows = { -1, -1, 1, 1};
        //private static int[] cols = { 1, -1, -1, 1 };

        //private static int GetMovesCount(string dir)
        //{
        //    switch (dir)
        //    {
        //        case "RU":
        //            return 0;
        //        case "UR":
        //            return 0;
        //        case "LU":
        //            return 1;
        //        case "UL":
        //            return 1;
        //        case "DL":
        //            return 2;
        //        case "LD":
        //            return 2;
        //        case "DR":
        //            return 3;
        //        case "RD":
        //            return 3;
        //        default:
        //            throw new ArgumentException();
        //    }
        //}

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
            //if (nAndM[0] < 3 || nAndM[1] > 128)
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

            //Read the matrix
            //int[] nAndM = Console.ReadLine().Split().Select(Int32.Parse).ToArray();
            //originalMatrix = new int[nAndM[0], nAndM[1]];
            //usedIndexes = new bool[nAndM[0], nAndM[1]];

            ////Fill the matrix
            //int[] currentRowNums;
            //for (int row = 0; row < originalMatrix.GetLength(0); row++)
            //{
            //    currentRowNums = Console.ReadLine().Split().Select(Int32.Parse).ToArray();
            //    for (int col = 0; col < originalMatrix.GetLength(1); col++)
            //    {
            //        originalMatrix[row, col] = currentRowNums[col];
            //    }
            //}

            ////Traverse the matrix
            //for (int row = 0; row < originalMatrix.GetLength(0); row++)
            //{
            //    for (int col = 0; col < originalMatrix.GetLength(1); col++)
            //    {
            //        currentLength = 0;
            //        Program.RecursionSearching(originalMatrix, row, col, originalMatrix[row, col]);
            //    }
            //}

            //Console.WriteLine(bestLength);

            //Seventh Task --- Marto's Way

            //int[] arrNum = Console.ReadLine().Split().Select(Int32.Parse).ToArray();
            //int row = arrNum[0];
            //int col = arrNum[1];

            //int[,] matrix = new int[row, col];

            //for (int i = row - 1; i >= 0; i--)
            //{
            //    for (int j = 0; j < col; j++)
            //    {
            //        matrix[i, j] = (row - 1 - i) * 3 + (j * 3);
            //    }
            //}

            //int movesCount = Int32.Parse(Console.ReadLine());
            //int currentRow = matrix.GetLength(0)-1;
            //int currentCol = 0;
            //int sum = 0;
            //for (int i = 0; i < movesCount; i++)
            //{
            //    var input = Console.ReadLine().Split();
            //    var dir = input[0];
            //    var repeat = Int32.Parse(input[1]);

            //    var moveDir = GetMoves(dir);

            //    for (int j = 0; j < repeat - 1; j++)
            //    {
            //        currentRow += rows[moveDir];
            //        currentCol += cols[moveDir];

            //        if(currentRow < 0 || currentRow >= matrix.GetLength(0) || currentCol < 0 || currentCol >= matrix.GetLength(1))
            //        {
            //            currentRow -= rows[moveDir];
            //            currentCol -= cols[moveDir];
            //            break;
            //        }
            //        sum += matrix[currentRow, currentCol];
            //        matrix[currentRow, currentCol] = 0;
            //    }
            //}
            //Console.WriteLine(sum);

            //Seventh Task --- My way

            //int[] matrixLength = Console.ReadLine().Split().Select(Int32.Parse).ToArray();
            //int matrixRows = matrixLength[0];
            //int matrixCols = matrixLength[1];

            //int[,] mainMatrix = new int[matrixRows, matrixCols];
            //int mainCounter = -3;
            //int counter = 0;

            //for (int row = mainMatrix.GetLength(0) - 1; row >= 0; row--)
            //{
            //    mainCounter += 3;
            //    counter = mainCounter;
            //    for (int col = 0; col < mainMatrix.GetLength(1); col++)
            //    {
            //        mainMatrix[row, col] = counter;
            //        counter += 3;
            //    }
            //}

            //int movesCount = Int32.Parse(Console.ReadLine());

            //string[] data;
            //string direction;
            //int moves;
            //int sum = 0;
            //int currentRow = mainMatrix.GetLength(0) - 1;
            //int currentCol = 0;
            //for (int i = 0; i < movesCount; i++)
            //{
            //    data = Console.ReadLine().Split().ToArray();
            //    direction = data[0];
            //    moves = Int32.Parse(data[1]);

            //    for (int j = 0; j < moves - 1; j++)
            //    {
            //        currentRow += rows[GetMovesCount(direction)];
            //        currentCol += cols[GetMovesCount(direction)];

            //        if (currentRow < 0 || currentRow >= mainMatrix.GetLength(0) || currentCol < 0 || currentCol >= mainMatrix.GetLength(1))
            //        {
            //            currentRow -= rows[GetMovesCount(direction)];
            //            currentCol -= cols[GetMovesCount(direction)];
            //            break;
            //        }
            //        sum += mainMatrix[currentRow, currentCol];
            //        mainMatrix[currentRow, currentCol] = 0;
            //    }
            //}
            //Console.WriteLine(sum);

            //for (int row = 0; row < mainMatrix.GetLength(0); row++)
            //{
            //    for (int col = 0; col < mainMatrix.GetLength(1); col++)
            //    {
            //        Console.Write(mainMatrix[row, col] + " ");
            //    }
            //    Console.WriteLine();
            //}


            //Sixth Task --- My Way

            //int[] matrixSizes = Console.ReadLine().Split().Select(Int32.Parse).ToArray();
            //matrix = new int[matrixSizes[0], matrixSizes[1]];
            //usedIndex = new bool[matrixSizes[0], matrixSizes[1]];

            //int[] currentRow;
            //for (int row = 0; row < matrix.GetLength(0); row++)
            //{
            //    currentRow = Console.ReadLine().Split().Select(Int32.Parse).ToArray();
            //    for (int col = 0; col < matrix.GetLength(1); col++)
            //    {
            //        matrix[row, col] = currentRow[col];
            //    }
            //}

            //for (int row = 0; row < matrix.GetLength(0); row++)
            //{
            //    for (int col = 0; col < matrix.GetLength(1); col++)
            //    {
            //        currentLength = 0;
            //        Program.Recursion(matrix, row, col, matrix[row, col]);
            //    }
            //}

            //Console.WriteLine(Program.bestLength);

        }

        //private static void Recursion(int[,] matrix, int row, int col, int targetValue)
        //{
        //    if (row < 0 || row >= matrix.GetLength(0) || col < 0 || col >= matrix.GetLength(1))
        //    {
        //        return;
        //    }
        //    if (matrix[row, col] != targetValue)
        //    {
        //        return;
        //    }
        //    if (usedIndex[row, col])
        //    {
        //        return;
        //    }

        //    currentLength++;
        //    bestLength = bestLength < currentLength ? currentLength : bestLength;
        //    usedIndex[row, col] = true;

        //    Program.Recursion(matrix, row + 1, col, targetValue);
        //    Program.Recursion(matrix, row - 1, col, targetValue);
        //    Program.Recursion(matrix, row, col + 1, targetValue);
        //    Program.Recursion(matrix, row, col - 1, targetValue);
        //}

        //private static void PrintMatrix(int[,] matrix)
        //{
        //    for (int i = 0; i < matrix.GetLength(0); i++)
        //    {
        //        Console.Write(matrix[i,0]);
        //        for (int j = 1; j < matrix.GetLength(1); j++)
        //        {
        //            Console.Write(" " + matrix[i,j]);
        //        }
        //        Console.WriteLine();
        //    }
        //}

        //private static void RecursionSearching(int[,] matrix, int row, int col, int targetValue)
        //{
        //    if (row < 0 || col < 0 || row >= matrix.GetLength(0) || col >= matrix.GetLength(1))
        //    {
        //        return;
        //    }
        //    if(matrix[row,col] != targetValue)
        //    {
        //        return;
        //    }
        //    if(usedIndexes[row,col])
        //    {
        //        return;
        //    }
        //    currentLength++;
        //    bestLength = bestLength < currentLength ? currentLength : bestLength;
        //    usedIndexes[row, col] = true;

        //    Program.RecursionSearching(matrix, row + 1, col, targetValue);
        //    Program.RecursionSearching(matrix, row - 1, col, targetValue);
        //    Program.RecursionSearching(matrix, row, col + 1, targetValue);
        //    Program.RecursionSearching(matrix, row, col - 1, targetValue);
        //}

        //private static int BestRightDiagonalsSearch(string[,] matrix)
        //{
        //    int bestSum = 0;
        //    int currentSum = 1;

        //    for (int col = matrix.GetLength(1) - 2; col >= 0; col--)
        //    {
        //        for (int currentCol = col, row = 0; currentCol < matrix.GetLength(1) - 1 && row < matrix.GetLength(0) - 1; currentCol++, row++)
        //        {
        //            if (matrix[row, currentCol].Equals(matrix[row + 1, col + 1]))
        //            {
        //                currentSum++;
        //            }
        //            else
        //            {
        //                CheckForBestSum(ref bestSum, ref currentSum);
        //            }
        //        }
        //        CheckForBestSum(ref bestSum, ref currentSum);
        //    }

        //    for (int row = 1; row < matrix.GetLength(0) - 1; row++)
        //    {
        //        for (int currentRow = row, col = 0; currentRow < matrix.GetLength(0) - 1 && col < matrix.GetLength(1) - 1; currentRow++, col++)
        //        {
        //            if (matrix[currentRow, col].Equals(matrix[currentRow + 1, col + 1]))
        //            {
        //                currentSum++;
        //            }
        //            else
        //            {
        //                CheckForBestSum(ref bestSum, ref currentSum);
        //            }
        //        }
        //        CheckForBestSum(ref bestSum, ref currentSum);
        //    }

        //    return bestSum;
        //}

        //private static int BestLeftDiagonalsSearch(string[,] matrix)
        //{
        //    int bestSum = 0;
        //    int currentSum = 1;

        //    for (int col = 1; col < matrix.GetLength(1); col++)
        //    {
        //        for (int currentCol = col, row = 0; currentCol > 0 && row < matrix.GetLength(0) - 1; currentCol--, row++)
        //        {
        //            if (matrix[row, currentCol].Equals(matrix[row + 1, currentCol - 1]))
        //            {
        //                currentSum++;
        //            }
        //            else
        //            {
        //                CheckForBestSum(ref bestSum, ref currentSum);
        //            }
        //        }
        //        CheckForBestSum(ref bestSum, ref currentSum);
        //    }

        //    for (int row = 1; row < matrix.GetLength(0) - 1; row++)
        //    {
        //        for (int currentRow = row, col = matrix.GetLength(1)-1; currentRow < matrix.GetLength(0) - 1 && col > 0; currentRow++, col--)
        //        {
        //            if (matrix[currentRow, col].Equals(matrix[currentRow + 1, col - 1]))
        //            {
        //                currentSum++;
        //            }
        //            else
        //            {
        //                CheckForBestSum(ref bestSum, ref currentSum);
        //            }
        //        }
        //        CheckForBestSum(ref bestSum, ref currentSum);
        //    }

        //    return bestSum;
        //}

        //private static int BestVerticalSearch(string[,] matrix)
        //{
        //    int bestSum = Int32.MinValue;
        //    int currentSum = 1;

        //    for (int col = 0; col < matrix.GetLength(1); col++)
        //    {
        //        for (int row = 1; row < matrix.GetLength(0); row++)
        //        {
        //            if (matrix[row, col].Equals(matrix[row - 1, col]))
        //            {
        //                currentSum++;
        //            }
        //            else
        //            {
        //                CheckForBestSum(ref bestSum, ref currentSum);
        //            }
        //        }
        //        CheckForBestSum(ref bestSum, ref currentSum);
        //    }

        //    return bestSum;
        //}

        //private static int BestHorizontalSearch(string[,] matrix)
        //{
        //    int bestSum = Int32.MinValue;
        //    int currentSum = 1;

        //    for (int row = 0; row < matrix.GetLength(0); row++)
        //    {
        //        for (int col = 1; col < matrix.GetLength(1); col++)
        //        {
        //            if (matrix[row, col].Equals(matrix[row, col - 1]))
        //            {
        //                currentSum++;
        //            }
        //            else
        //            {
        //                CheckForBestSum(ref bestSum, ref currentSum);
        //            }
        //        }
        //        CheckForBestSum(ref bestSum, ref currentSum);
        //    }
        //    return bestSum;
        //}

        //private static void CheckForBestSum(ref int bestSum, ref int currentSum)
        //{
        //    if (currentSum != 1 && currentSum > bestSum)
        //    {
        //        bestSum = currentSum;
        //        currentSum = 1;
        //    }
        //    currentSum = 1;
        //}

        //private static void FillMatrixUsingD(int[,] matrix)
        //{
        //    int row = 0;
        //    int col = 0;

        //    bool isDown = true;
        //    bool isRight = false;
        //    bool isUp = false;
        //    bool isLeft = false;

        //    int counter = 1;

        //    while (counter <= matrix.GetLength(0) * matrix.GetLength(0))
        //    {
        //        matrix[row, col] = counter;

        //        if (isDown)
        //        {
        //            if (row + 1 >= matrix.GetLength(0) || matrix[row + 1, col] != 0)
        //            {
        //                isDown = false;
        //                isRight = true;
        //                col++;
        //            }
        //            else
        //            {
        //                row++;
        //            }
        //        }
        //        else if (isRight)
        //        {
        //            if (col + 1 >= matrix.GetLength(1) || matrix[row, col + 1] != 0)
        //            {
        //                isRight = false;
        //                isUp = true;
        //                row--;
        //            }
        //            else
        //            {
        //                col++;
        //            }
        //        }
        //        else if (isUp)
        //        {
        //            if (row - 1 < 0 || matrix[row - 1, col] != 0)
        //            {
        //                isUp = false;
        //                isLeft = true;
        //                col--;
        //            }
        //            else
        //            {
        //                row--;
        //            }
        //        }
        //        else if (isLeft)
        //        {
        //            if (col - 1 < 0 || matrix[row, col - 1] != 0)
        //            {
        //                isLeft = false;
        //                isDown = true;
        //                row++;
        //            }
        //            else
        //            {
        //                col--;
        //            }
        //        }
        //        counter++;
        //    }
        //}

        //private static void FillMatrixUsingC(int[,] matrix)
        //{
        //    int counter = 1;
        //    for (int row = matrix.GetLength(0) - 1; row >= 0; row--)
        //    {
        //        for (int secRow = row, col = 0; secRow < matrix.GetLength(0); secRow++, col++, counter++)
        //        {
        //            matrix[secRow, col] = counter;
        //        }
        //    }

        //    for (int col = 1; col < matrix.GetLength(1); col++)
        //    {
        //        for (int secCol = col, row = 0; secCol < matrix.GetLength(1); secCol++, row++, counter++)
        //        {
        //            matrix[row, secCol] = counter;
        //        }
        //    }
        //}

        //private static void FillMatrixUsingB(int[,] matrix)
        //{
        //    int counter = 1;
        //    for (int col = 0; col < matrix.GetLength(1); col++)
        //    {
        //        if (col % 2 == 0)
        //        {
        //            for (int row = 0; row < matrix.GetLength(0); row++, counter++)
        //            {
        //                matrix[row, col] = counter;
        //            }
        //        }
        //        else
        //        {
        //            for (int row = matrix.GetLength(0) - 1; row >= 0; row--,counter++)
        //            {
        //                matrix[row, col] = counter;
        //            }
        //        }
        //    }
        //}

        //private static void FillMatrixUsingA(int[,] matrix)
        //{
        //    int counter = 1;
        //    for (int col = 0; col < matrix.GetLength(1); col++)
        //    {
        //        for (int row = 0; row < matrix.GetLength(0); row++,counter++)
        //        {
        //            matrix[row, col] = counter;
        //        }
        //    }
        //}

        //private static void PrintMatrix(int[,] matrix)
        //{
        //    for (int row = 0; row < matrix.GetLength(0); row++)
        //    {
        //        Console.Write(matrix[row, 0]);
        //        for (int col = 1; col < matrix.GetLength(1); col++)
        //        {
        //            Console.Write(" " + matrix[row, col]);
        //        }
        //        Console.WriteLine();
        //    }
        //}

    }
}