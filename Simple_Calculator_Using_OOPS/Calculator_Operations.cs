using System;

namespace Simple_Calculator_Using_OOPS
{
    internal class Calculator_Operations
    {
        public double Operator1;
        public double Operator2;

        public void Add() => Console.WriteLine($"The sum of {Operator1} and {Operator2} is {Operator1 + Operator2}");

        public void Subtract() => Console.WriteLine($"The difference of {Operator1} and {Operator2} is {Operator1 - Operator2}");

        public void Multiply() => Console.WriteLine($"The product of {Operator1} and {Operator2} is {Operator1 * Operator2}");

        public void Division() => Console.WriteLine($"The fraction of {Operator1} and {Operator2} is {Operator1 / Operator2}");
    }
}
