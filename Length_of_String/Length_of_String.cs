using System;

namespace Length_of_String
{
    internal class Length_of_String
    {
        static void Main(string[] args)
        {
            Func<string, int> lengthFunc = s => s.Length;

            Console.WriteLine(lengthFunc("Hello World!"));
        }
    }
}
