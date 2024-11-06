using System;

namespace Learning
{
    internal class Learning
    {
        delegate void Calculate(int x, int y);
        static void Main(string[] args)
        {
            void Add(int x, int y)
            {
                Console.WriteLine($"Addition: {x + y}");
            }

            void Subtract(int x, int y)
            {
                Console.WriteLine($"Subtraction: {x - y}");
            }

            Calculate calc = Add; // Adding first method to the delegate.
            calc += Subtract; // Adding second method to the delegate.
            calc(3, 4); // Calling the delegate. This will call both methods.


        }
    }
}