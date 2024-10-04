using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    internal class Program
    {
        static void Main(string[] args)
        {


            // Printing Vowels

            string text = "Clement";

            foreach (var item in text)
            {
                if (item == 'a' || item == 'e' || item == 'i' || item == 'o' || item == 'u')
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}

