using System;

namespace Welcome_Message
{
    internal class Welcome_Message
    {
        static void Main(string[] args)
        {
            Action<string> printAction = message => Console.WriteLine(message);

            printAction("Welcome to C# World!");
        }
    }
}
