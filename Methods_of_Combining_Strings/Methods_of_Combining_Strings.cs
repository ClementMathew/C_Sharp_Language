using System;
using System.Text;

namespace Methods_of_Combining_Strings
{
    internal class Methods_of_Combining_Strings
    {
        static void Main(string[] args)
        {
            // Methods of Combining Strings.

            // Method 1

            string res = "";

            Console.WriteLine("--- Method 1 ---\n");

            res = string.Join(", ", "Hello", "World");
            Console.WriteLine(res);

            string[] arr = new string[] { "Hi", "World" };

            res = string.Join(", ", arr);
            Console.WriteLine(res + "\n");

            // Method 2

            Console.WriteLine("--- Method 2 ---\n");

            res = string.Concat("1", "2", 3, 10.5, true);
            Console.WriteLine(res);

            string[] concatArray = new string[] { "Hello", "From", "C#" };
            res = string.Concat(concatArray);
            Console.WriteLine(res + "\n");

            // Method 3

            Console.WriteLine("--- Method 3 ---\n");

            res = string.Format("{0} {1} {2}", "Hello", "From", "C#");
            Console.WriteLine(res);

            res = string.Format("{0} {1} {2} and {2}", "Hello", "From", "C#", "C++");
            Console.WriteLine(res);

            string[] formatArr = new string[] { "Hello", "From", "C#" };
            res = string.Format("{0} {1} {2}", formatArr);
            Console.WriteLine(res + "\n");

            // Method 4

            Console.WriteLine("--- Method 4 ---\n");

            res = "Hello " + "From " + "C#";
            Console.WriteLine(res + "\n");

            // Method 5

            Console.WriteLine("--- Method 5 ---\n");

            string language = "C#";
            res = $"Hello from {language}";
            Console.WriteLine(res + "\n");

            // Method 6

            Console.WriteLine("--- Method 6 ---\n");

            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Line 1");
            sb.AppendLine("Line 2");

            sb.Append("No New Line");
            sb.Append(" No New Line\n");

            sb.AppendFormat("My name is {0} {1}", "Mishel", "Shaji");
            sb.AppendLine();

            res = sb.ToString();

            Console.WriteLine(res);
        }
    }
}
