using System;
using System.Collections.Generic;
using System.Linq;

namespace Basics_of_Linq
{

    internal class Basics_of_Linq
    {
        static void Main(string[] args)
        {
            int[] data = new int[] { 1, 2, 3, 4, 5, 6, 12, 18, 20, 21 };

            // Skip, Take, Where and Sum

            int res = data.Skip(3)
                .Take(5)
                .Where(x => x % 2 == 0)
                .Sum();

            Console.WriteLine($"Skipping 3 and Taking 5 then Summing which is even : {res}");

            // First and FirstOrDefault

            int first = data.First();
            int firstOrDefault = data.FirstOrDefault();

            Console.WriteLine($"\nFirst : {first}");
            Console.WriteLine($"First or Default : {firstOrDefault}");

            // OrderBy

            IOrderedEnumerable<int> sorted = data.OrderBy(x => x);
            IOrderedEnumerable<int> sortedDescending = data.OrderByDescending(x => x);

            Console.WriteLine($"\nSorted : {string.Join(" ", sorted)}");
            Console.WriteLine($"Sorted in Reverse : {string.Join(" ", sortedDescending)}");

            // Min, Max and Count

            int min = data.Min();
            int max = data.Max();
            int count = data.Count();

            Console.WriteLine($"\nMinimum : {min}");
            Console.WriteLine($"Maximum : {max}");
            Console.WriteLine($"Count : {count}");

            int minGreaterThanfive = data.Where(x => x > 5).Min();

            Console.WriteLine($"\nMinimum and Greater than 5 : {minGreaterThanfive}");

            // TakeWhile and SkipWhile

            IEnumerable<int> takeWhile = data.TakeWhile(i => i < 5);
            IEnumerable<int> skipWhile = data.SkipWhile(i => i < 5);

            Console.WriteLine("\nTakeWhile : " + string.Join(" ", takeWhile));
            Console.WriteLine("SkipWhile : " + string.Join(" ", skipWhile));

        }
    }
}