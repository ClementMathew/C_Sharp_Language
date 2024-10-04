using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning
{
    internal class Learning
    {
        static void Main(string[] args)
        {

            // Reading names of persons.

            Console.WriteLine("Enter the number of persons : ");
            int n = int.Parse(Console.ReadLine());

            string[] names = new string[n];

            Console.WriteLine("Enter the names : ");

            for (int i = 0; i < n; i++)
            {
                names[i] = Console.ReadLine();
            }

            // Converting every names to uppercase

            Console.WriteLine("Converted to uppercase : ");

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(names[i].ToUpper());
            }

            // Searching for a name in the array.

            Console.WriteLine("Enter the name you want to search : ");
            string search = Console.ReadLine();

            // Case sensitive search.

            bool present = false;

            Console.WriteLine($"The string is there or not by considering case : ");

            for (int i = 0; i < n; i++)
            {
                if (names[i] == search)
                {
                    present = true;
                }
            }
            if (present)
            {
                Console.WriteLine("Yes present");
            }
            else
            {
                Console.WriteLine("No");
            }

            // Case insensitive search.

            present = false;

            Console.WriteLine($"The string is there or not w/o considering case : ");

            for (int i = 0; i < n; i++)
            {
                if (names[i].ToLower() == search.ToLower())
                {
                    present = true;
                }
            }
            if (present)
            {
                Console.WriteLine("Yes present");
            }
            else
            {
                Console.WriteLine("No");
            }

            // Substring search in names of array.

            Console.WriteLine("Enter the substring you want to search : ");
            string subsearch = Console.ReadLine();

            for (int i = 0; i < n; i++)
            {
                if (names[i].ToLower().Contains(subsearch.ToLower()))
                {
                    Console.WriteLine(names[i]);
                }
            }

            // Trim *
        }
    }
}
