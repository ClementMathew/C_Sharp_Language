using System;
using System.Collections.Generic;

namespace Remove_Even_Numbers
{
    internal class Remove_Even_Numbers
    {
        static void Main(string[] args)
        {
            // Display a list by removing all even numbers entered by user.

            List<int> list = new List<int>();

            Console.WriteLine("Enter 5 numbers : ");

            for (int i = 0; i < 5; i++)
            {
                list.Add(int.Parse(Console.ReadLine()));
            }

            // always recommend to use the copy of it in foreach

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] % 2 == 0)
                {
                    list.RemoveAt(i);
                }
            }

            // Printing the list

            Console.Write("The list after removing even numbers : ");

            foreach (int item in list)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine();
        }
    }
}
