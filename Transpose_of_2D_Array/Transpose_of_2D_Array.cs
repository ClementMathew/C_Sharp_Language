using System;

namespace Transpose_of_2D_Array
{
    internal class Transpose_of_2D_Array
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the size of the matrix separated by commas (row,column) : ");
            string size = Console.ReadLine();

            int row = int.Parse(size.Trim().Split(',')[0]);
            int column = int.Parse(size.Trim().Split(',')[1]);

            int[,] matrix = new int[row, column];

            Console.WriteLine("Enter the elements of the matrix : ");

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    Console.Write($"[{i},{j}] : ");
                    matrix[i, j] = int.Parse(Console.ReadLine());
                }
            }

            // Display the matrix

            Console.WriteLine("Displaying the transpose of the matrix : ");

            for (int i = 0; i < column; i++)
            {
                for (int j = 0; j < row; j++)
                {
                    Console.Write(matrix[j, i] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
