using System;

namespace Rectangle_Printing
{
    internal class Rectangle_Printing
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the height of the rectangle : ");
            int height = int.Parse(Console.ReadLine());

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < 3 * height; j++)
                {
                    if (i != 0 && j != 0 && i != height - 1 && j != 3 * height - 1)
                    {
                        Console.Write(" ");
                    }
                    else
                    {
                        Console.Write("*");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
