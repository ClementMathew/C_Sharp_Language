﻿using System;

namespace Capitalize_And_Replace_Space
{
    internal class Capitalize_And_Replace_Space
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the name : ");
            string name = Console.ReadLine();

            Console.WriteLine("The converted name : ");

            for (int i = 0; i < name.Length; i++)
            {
                if ((int)name[i] > 90)
                {
                    Console.Write((char)((int)name[i] - 32));
                }
                if ((int)name[i] == 32)
                {
                    Console.Write("_");
                }
                if ((int)name[i] <= 90 && (int)name[i] > 64)
                {
                    Console.Write(name[i]);
                }
            }
            Console.ReadKey();
        }
    }
}
