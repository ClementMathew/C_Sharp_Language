﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checking_Starts_With
{
    internal class Checking_Starts_With
    {
        static void Main(string[] args)
        {
            Predicate<string> startsWithA = s => s.StartsWith("A");

            Console.WriteLine(startsWithA("Apple"));
            Console.WriteLine(startsWithA("Banana"));
        }
    }
}
