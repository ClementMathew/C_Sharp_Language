using System;
using System.Text;

namespace Iteration_Statements
{
    internal class Iteration_Statements
    {
        static void Main(string[] args)
        {
            // For loop statement.

            Console.Write("For loop : ");

            for (int i = 0; i < 3; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();


            // While loop statement.

            int n = 0;
            Console.Write("While loop : ");

            while (n < 5)
            {
                Console.Write(n + " ");
                n++;
            }
            Console.WriteLine("\n");


            // Foreach.

            StringBuilder sb = new StringBuilder();
            string[] names = { "Clement", "Mathew", "Sheba" };

            foreach (string name in names)
            {
                sb.AppendLine($"Name is : {name}");
            }
            Console.WriteLine(sb.ToString());
        }
    }
}
