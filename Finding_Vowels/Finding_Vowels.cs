using System;

namespace Finding_Vowels
{
    internal class Finding_Vowels
    {
        static void Main(string[] args)
        {
            // Printing Vowels

            string textInput = "Clement";
            string vowels = "aeiou";

            foreach (char item in textInput)
            {
                if (vowels.Contains(item.ToString().ToLower()))
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}
