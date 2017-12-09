using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClassesPartTwo
{
    class Matrix<T> where T : struct
    {
        private T[,] matrix;

        public Matrix(int rowsCount, int colsCount)
        {
            this.matrix = new T[rowsCount, colsCount];
        }

        public T this[int row, int col]
        {
            get { if (row < 0 || row >= this.matrix.GetLength(0) || col < 0 || col >= matrix.GetLength(1)) { throw new IndexOutOfRangeException(); } return this.matrix[row, col]; }
            set { if (row < 0 || row >= this.matrix.GetLength(0) || col < 0 || col >= matrix.GetLength(1)) { throw new IndexOutOfRangeException(); } this.matrix[row, col] = value; }
        }


        public int GetRows { get { return this.matrix.GetLength(0); } }

        public int GetCols { get { return this.matrix.GetLength(1); } }

        public static T[,] operator +(Matrix<T> firstMatrix, Matrix<T> secondMatrix)
        {
            if ((firstMatrix.GetRows != secondMatrix.GetRows) || (firstMatrix.GetCols != secondMatrix.GetCols))
            {
                throw new Exception();
            }

            T[,] resultedMatrix = new T[firstMatrix.GetRows, firstMatrix.GetCols];

            for (int row = 0; row < firstMatrix.GetRows; row++)
            {
                for (int col = 0; col < firstMatrix.GetCols; col++)
                {
                    resultedMatrix[row, col] = (dynamic)firstMatrix[row, col] + (dynamic)secondMatrix[row, col];
                }
            }

            return resultedMatrix;
        }

        public static T[,] operator -(Matrix<T> firstMatrix, Matrix<T> secondMatrix)
        {
            if ((firstMatrix.GetRows != secondMatrix.GetRows) || (firstMatrix.GetCols != secondMatrix.GetCols))
            {
                throw new Exception();
            }

            T[,] resultedMatrix = new T[firstMatrix.GetRows, firstMatrix.GetCols];

            for (int row = 0; row < firstMatrix.GetRows; row++)
            {
                for (int col = 0; col < firstMatrix.GetCols; col++)
                {
                    resultedMatrix[row, col] = (dynamic)firstMatrix[row, col] - (dynamic)secondMatrix[row, col];
                }
            }

            return resultedMatrix;
        }

        public static T[,] operator *(Matrix<T> firstMatrix, Matrix<T> secondMatrix)
        {
            if ((firstMatrix.GetRows != secondMatrix.GetRows) || (firstMatrix.GetCols != secondMatrix.GetCols))
            {
                throw new Exception();
            }

            T[,] resultedMatrix = new T[firstMatrix.GetRows, firstMatrix.GetCols];

            for (int row = 0; row < firstMatrix.GetRows; row++)
            {
                for (int col = 0; col < firstMatrix.GetCols; col++)
                {
                    resultedMatrix[row, col] = (dynamic)firstMatrix[row, col] * (dynamic)secondMatrix[row, col];
                }
            }

            return resultedMatrix;
        }

    }
}