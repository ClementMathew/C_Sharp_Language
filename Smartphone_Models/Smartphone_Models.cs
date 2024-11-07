using System;
using System.Collections.Generic;

namespace Smartphone_Models
{
    class Smartphone
    {
        public string Name;
        public string Manufacturer;
        public List<string> RamSizes;

        public void ShowModels()
        {
            Console.WriteLine($"\nName : {Name}");
            Console.WriteLine($"Manufacturer : {Manufacturer}");
            Console.Write($"Ram Sizes : ");

            foreach (string item in RamSizes)
            {
                Console.Write(item + " GB ");
            }
            Console.WriteLine();
        }
    }

    internal class Smartphone_Models
    {
        static void Main(string[] args)
        {
            Smartphone p = new Smartphone();
            p.Name = "iPhone 16";
            p.Manufacturer = "Apple";
            p.RamSizes = new List<string>() { "8", "16" };

            p.ShowModels();

            Smartphone p2 = new Smartphone();
            p.Name = "iPhone 15";
            p.Manufacturer = "Apple";
            p.RamSizes = new List<string>() { "16", "32" };

            p.ShowModels();
        }
    }
}
