﻿using System;

namespace _2_Dimensional_Array
{
    internal class _2_Dimensional_Array
    {
        static void Main(string[] args)
        {
            int[,] matrix = new int[3, 3];
            int counter = 1;

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    matrix[i, j] = counter++;
                }
            }

            // Display the matrix

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }

        }
    }
}
