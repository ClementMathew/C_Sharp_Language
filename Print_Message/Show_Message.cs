using System;

namespace Print_Message
{
    delegate void PrintMessage(string message);

    class Show_Message
    {
        public static void DisplayMessage(string message)
        {
            Console.WriteLine(message);
        }

        static void Main()
        {
            PrintMessage print = DisplayMessage;

            print("Hello from the delegate!");
        }
    }
}
