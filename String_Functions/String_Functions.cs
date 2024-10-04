using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Functions
{
    internal class String_Functions
    {
        static void Main(string[] args)
        {

            // String functions.

            string text = "    Hello World    ";

            Console.WriteLine($"Converting to uppercase : {text.ToUpper()}");
            Console.WriteLine($"Converting to lowercase : {text.ToLower()} \n");

            Console.WriteLine($"Trimming extra spaces : {text.Trim()}");
            Console.WriteLine($"Trimming extra spaces from start : {text.TrimStart()}");
            Console.WriteLine($"Trimming extra spaces from end : {text.TrimEnd()} \n");

            Console.WriteLine($"Replacing space with dash : {text.Replace(" ", "-")}");
            Console.WriteLine($"Removing letters from 0 to 7th index : {text.Remove(0, 7)} \n");

            Console.WriteLine($"Length of the string : {text.Length}");
            Console.WriteLine($"Length of string after trimming : {text.Trim().Length} \n");

            Console.WriteLine($"Checking substring in the string : {text.Contains("Hello")} \n");

            Console.WriteLine($"Checking starts with a substring : {text.StartsWith("    Hello")}");
            Console.WriteLine($"Checking starts with a substring without considering case : {text.StartsWith("    hello", StringComparison.OrdinalIgnoreCase)}");
            Console.WriteLine($"Checking endswith a substring : {text.EndsWith("    ")} \n");

            char[] chars = text.ToCharArray();
            Console.WriteLine($"Converting to char array : {string.Join(", ", chars)} \n");

            string[] words = text.Split(' ');
            Console.WriteLine($"Splitting the string with space : {string.Join(", ", words)} \n");

            string[] splits = text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            Console.WriteLine($"Splitting the string with space and removing empty strings : {string.Join(", ", splits)} \n");


            // Methods of Combining Strings.


            // Method 1

            var res = "";

            Console.WriteLine("--- Method 1 ---\n");

            res = string.Join(", ", "Hello", "World");
            Console.WriteLine(res);

            var arr = new string[] { "Hi", "World" };

            res = string.Join(", ", arr);
            Console.WriteLine(res + "\n");

            // Method 2

            Console.WriteLine("--- Method 2 ---\n");

            res = string.Concat("1", "2", 3, 10.5, true);
            Console.WriteLine(res);

            var concatArray = new string[] { "Hello", "From", "C#" };
            res = string.Concat(concatArray);
            Console.WriteLine(res + "\n");

            // Method 3

            Console.WriteLine("--- Method 3 ---\n");

            res = string.Format("{0} {1} {2}", "Hello", "From", "C#");
            Console.WriteLine(res);

            res = string.Format("{0} {1} {2} and {2}", "Hello", "From", "C#", "C++");
            Console.WriteLine(res);

            var formatArr = new string[] { "Hello", "From", "C#" };
            res = string.Format("{0} {1} {2}", formatArr);
            Console.WriteLine(res + "\n");

            // Method 4

            Console.WriteLine("--- Method 4 ---\n");

            res = "Hello " + "From " + "C#";
            Console.WriteLine(res + "\n");

            // Method 5

            Console.WriteLine("--- Method 5 ---\n");

            var language = "C#";
            res = $"Hello from {language}";
            Console.WriteLine(res + "\n");

            // Method 6

            Console.WriteLine("--- Method 6 ---\n");

            var sb = new StringBuilder();

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
