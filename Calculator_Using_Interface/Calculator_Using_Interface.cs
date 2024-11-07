using System;

namespace Calculator_Using_Interface
{
    interface ICalculator
    {
        int Add(int a, int b);
        int Subtract(int a, int b);
    }

    class SimpleCalculator : ICalculator
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public int Subtract(int a, int b)
        {
            return a - b;
        }
    }

    internal class Calculator_Using_Interface
    {
        static void Main(string[] args)
        {
            ICalculator calculator = new SimpleCalculator();

            int resultAdd = calculator.Add(5, 3);
            int resultSubtract = calculator.Subtract(10, 4);

            Console.WriteLine($"Addition: {resultAdd}");
            Console.WriteLine($"Subtraction: {resultSubtract}");
        }
    }
}
