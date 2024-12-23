﻿using System;

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

        // Single line function.

        static void SingleLineFunction() => Console.WriteLine("The single line function");

        // Single line function with return.

        static int SingleLineFunctionWithReturn(int a, int b) => a + b;

        // Main function.

        static void Main(string[] args)
        {
            Greet();
            GreetByName("Clement");
            GreetByName("Clement", "Mathew");

            Console.WriteLine();

            SingleLineFunction();
            Console.WriteLine(SingleLineFunctionWithReturn(1, 2));
        }
    }
}
