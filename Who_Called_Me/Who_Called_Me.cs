using System;
using System.Runtime.CompilerServices;

namespace Who_Called_Me
{
    internal class Who_Called_Me
    {
        // Method using [CallerMemberName] attribute

        public static void CallMe([CallerMemberName] string caller = "")
        {
            Console.WriteLine($"{caller} called me");
        }

        public static void Main()
        {
            // Calling the CallMe method

            CallMe();
        }
    }
}
