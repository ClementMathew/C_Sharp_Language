﻿using System;

namespace _2_Dimensional_Array
{
    internal class _2_Dimensional_Array
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

            Console.WriteLine("Displaying the elements of the matrix : ");

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
