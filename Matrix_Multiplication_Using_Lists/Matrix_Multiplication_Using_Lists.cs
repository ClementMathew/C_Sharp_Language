using System;
using System.Collections.Generic;

namespace Matrix_Multiplication_Using_Lists
{
    class MatrixMultiplication
    {
        public static List<List<int>> Multiply(List<List<int>> matrixA, List<List<int>> matrixB)
        {
            if (matrixA[0].Count != matrixB.Count)
            {
                throw new InvalidOperationException("Number of columns in Matrix A must match the number of rows in Matrix B.");
            }

            int rowsA = matrixA.Count;
            int colsA = matrixA[0].Count;
            int colsB = matrixB[0].Count;

            List<List<int>> resultMatrix = new List<List<int>>();

            for (int i = 0; i < rowsA; i++)
            {
                resultMatrix.Add(new List<int>(new int[colsB]));
            }

            for (int i = 0; i < rowsA; i++)
            {
                for (int j = 0; j < colsB; j++)
                {
                    for (int k = 0; k < colsA; k++)
                    {
                        resultMatrix[i][j] += matrixA[i][k] * matrixB[k][j];
                    }
                }
            }

            return resultMatrix;
        }

        public static void PrintMatrix(List<List<int>> matrix)
        {
            foreach (List<int> row in matrix)
            {
                Console.WriteLine(string.Join(" ", row));
            }
        }

        static void Main(string[] args)
        {
            List<List<int>> matrixA = new List<List<int>>
            {
                new List<int> { 1, 2, 3 },
                new List<int> { 4, 5, 6 }
            };

            List<List<int>> matrixB = new List<List<int>>
            {
                new List<int> { 7, 8 },
                new List<int> { 9, 10 },
                new List<int> { 11, 12 }
            };

            try
            {
                List<List<int>> result = Multiply(matrixA, matrixB);

                Console.WriteLine("Result of Matrix Multiplication:");
                PrintMatrix(result);
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}
