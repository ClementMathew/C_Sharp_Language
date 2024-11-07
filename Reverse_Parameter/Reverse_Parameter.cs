using System;

namespace Reverse_Parameter
{
    internal class Reverse_Parameter
    {
        // Function that accepts parameters in reverse order

        static void PrintInfo(string firstName, string lastName, int age)
        {
            Console.WriteLine($"First Name: {firstName}, Last Name: {lastName}, Age: {age}");
        }

        static void Main(string[] args)
        {
            // Calling the function with parameters in reverse order

            PrintInfo(lastName: "Doe", firstName: "John", age: 25);
        }
    }
}
