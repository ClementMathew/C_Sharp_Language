using System;

namespace Tryparse_Using_Out
{
    internal class Tryparse_Using_Out
    {
        static void Main(string[] args)
        {
            string s = "5";

            if (int.TryParse(s, out int res))
            {
                Console.WriteLine(res);
            }
            else
            {
                Console.WriteLine("Error");
            }
        }
    }
}
