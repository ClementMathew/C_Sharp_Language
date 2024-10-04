using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functions
{
    internal class Functions
    {
        
        // User functions.

        static void Greet()
        {
            Console.WriteLine("Hello !");
        }

        // Passing parameters to function.

        static void GreetByName(string name)
        {
            Console.WriteLine($"Hello {name}!");
        }

        // Function overloading.

        static void GreetByName(string firstName, string lastName)
        {
            Console.WriteLine($"Hello {firstName} {lastName}!");
        }

        // Main function.

        static void Main(string[] args)
        {
            Greet();
            GreetByName("Clement");
            GreetByName("Clement", "Mathew");
        }
    }
}
