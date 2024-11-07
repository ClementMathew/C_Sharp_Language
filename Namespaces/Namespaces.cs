using System;

namespace MyApp
{
    namespace Utilities
    {
        public class MathUtilities
        {
            public static int Add(int a, int b)
            {
                return a + b;
            }
        }
    }
}

class Program
{
    static void Main()
    {
        int result = MyApp.Utilities.MathUtilities.Add(5, 3);
        Console.WriteLine($"The sum of 5 and 3 is : {result}");
    }
}

