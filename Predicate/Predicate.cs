using System;
using System.Collections.Generic;

namespace Predicate
{
    internal class Predicate
    {
        // Method to check if a value is even

        static bool IsEven(int value)
        {
            return value % 2 == 0;
        }

        // Method to check if a value is negative

        static bool IsNegative(int value)
        {
            return value < 0;
        }

        // Method to filter data based on a condition (predicate)

        static void GetDataBasedOnTheCondition(int[] data, Predicate<int> predicate)
        {
            List<int> result = new List<int>();

            foreach (int item in data)
            {
                if (predicate(item))
                {
                    result.Add(item);
                }
            }

            // Output the filtered result

            Console.WriteLine(string.Join(", ", result));
        }

        static void Main(string[] args)
        {
            int[] data = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, -3, -5 };

            // Call the method with IsEven predicate

            Console.WriteLine("Even numbers:");

            GetDataBasedOnTheCondition(data, IsEven);

            // Call the method with IsNegative predicate

            Console.WriteLine("\nNumbers:");

            GetDataBasedOnTheCondition(data, IsNegative);
        }
    }
}

