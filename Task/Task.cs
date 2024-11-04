using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    class ShoppingList
    {
        public List<string> items = new List<string>();

        public string this[int index]
        {
            get => items[index];
            set { items[index] = value; }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            var list = new ShoppingList();

            list[0] = "1";
            list[100] = "1";

            Console.WriteLine(list[100]);
        }
    }
}

