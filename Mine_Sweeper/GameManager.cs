﻿using System;

namespace Mine_Sweeper
{
    internal class GameManager
    {
        private const int Size = 5;
        private const int Mines = 5;
        private CellState[,] board = new CellState[Size, Size];
        private bool[,] opened = new bool[Size, Size];
        private Random random = new Random();

        public GameManager()
        {
            InitializeBoard();
        }

        private void InitializeBoard()
        {
            for (int i = 0; i < Mines; i++)
            {
                int x, y;
                do
                {
                    x = random.Next(Size);
                    y = random.Next(Size);
                } while (board[x, y] == CellState.Mine);

                board[x, y] = CellState.Mine;
            }
        }

        public void Play()
        {
            while (true)
            {
                PrintBoard();

                Console.Write("Enter row and column (e.x., 1 2): ");

                string[] input = Console.ReadLine().Split();
                int row = int.Parse(input[0]) - 1;
                int col = int.Parse(input[1]) - 1;

                if (board[row, col] == CellState.Mine)
                {
                    Console.WriteLine("Game Over! You hit a mine, Better Luck next time.");
                    break;
                }
                opened[row, col] = true;
            }
        }

        private void PrintBoard()
        {
            Console.Clear();

            for (int i = 0; i < Size; i++)
            {
                for (int j = 0; j < Size; j++)
                {
                    if (opened[i, j])
                    {
                        if (board[i, j] == CellState.Mine)
                            Console.Write('*' + " ");
                        else
                            Console.Write(((int)board[i, j]) + " ");
                    }
                    else
                    {
                        Console.Write(". ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
