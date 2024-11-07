using System;

namespace Function_Delegate
{
    internal class Function_Delegate
    {
        // Static method that returns an integer

        static int GetNumber()
        {
            return 10;
        }

        // Static method that adds two integers and returns the result as a string

        static string Add(int a, int b)
        {
            return (a + b).ToString();
        }

        static void Main(string[] args)
        {
            // Func delegate that takes no parameters and returns an integer

            Func<int> getNum = GetNumber;

            // Func delegate that takes two integers and returns a string

            Func<int, int, string> addNums = Add;

            // Invoke the Func delegate

            int res1 = getNum();
            string res2 = addNums(1, 2);

            // Output the results

            Console.WriteLine("Number : " + res1);
            Console.WriteLine("Sum : " + res2);

        }
    }
}

