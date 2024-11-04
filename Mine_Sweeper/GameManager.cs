using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mine_Sweeper
{
    internal class GameManager
    {
        private void InitGrid(int size, CellState[,] gameArray)
        {
            Random rand = new Random();

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    var state = (CellState)rand.Next(0, 3);
                    gameArray[i, j] = state;
                }
            }
        }

        private void RenderGrid(int size, CellState gameArray, bool opened)
        {
            Console.Clear();

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
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


        public void Play()
        {
            Console.WriteLine("Enter the size : ");
            int size = int.Parse(Console.ReadLine());

            CellState[,] gameArray = new CellState[size, size];
            bool[,] opened = new bool[size, size];

            InitGrid(size, gameArray);

            while (true)
            {
                RenderGrid(size, gameArray, opened);
                Console.WriteLine("\nEnter any index from (0,0) to (size,size) : ");
                var index = (Console.ReadLine()).Split(',');

                int indexRow = int.Parse(index[0]);
                int indexColumn = int.Parse(index[1]);

                for (int i = 0; i < size; i++)
                {
                    for (int j = 0; j < size; j++)
                    {
                        if (indexRow == i && indexColumn == j)
                        {
                            Console.Write($"({gameArray[i, j]})");
                        }
                    }
                }

            }
        }
    }
}
