using System;

namespace Palindrome_Check
{
    internal class Palindrome_Check
    {
        static void Main(string[] args)
        {
            // Palindrome

            Console.WriteLine("Enter a string : ");
            string input = Console.ReadLine();

            char[] charArray = input.ToCharArray();
            Array.Reverse(charArray);
            string reversedInput = new string(charArray);

            if (input == reversedInput)
            {
                Console.WriteLine("The string is a palindrome.");
            }
            else
            {
                Console.WriteLine("The string is not a palindrome.");
            }
        }
    }
}
