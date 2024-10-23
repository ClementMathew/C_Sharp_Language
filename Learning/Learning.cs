using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning
{
    internal class Learning
    {

        static void ChangeString(string name)
        {
            name = "Old";
        }
        static void Main(string[] args)
        {
            string text = "Clement";
            ChangeString(text);

            Console.WriteLine();
        }
    }
}
