//using System;

//namespace Abstract
//{
//    abstract class CalculatorBase
//    {
//        public void Add(int a, int b) => Console.WriteLine(a + b);

//        public void Subtract(int a, int b) => Console.WriteLine(a - b);

//        public void Multiply(int a, int b) => Console.WriteLine(a * b);

//        // Virtual method for Divide, can be overridden

//        public virtual void Divide(int a, int b) => Console.WriteLine(a / b);

//        // Abstract method to be implemented in derived class

//        public abstract void Power(int a, int b);
//    }

//    class Calculator : CalculatorBase
//    {
//        // Override the Divide method to handle division by zero

//        public override void Divide(int a, int b)
//        {
//            if (b == 0)
//            {
//                Console.WriteLine("Division by zero is not possible.");
//                return;
//            }
//            base.Divide(a, b);
//        }

//        // Implement the abstract Power method

//        public override void Power(int a, int b)
//        {
//            Console.WriteLine(Math.Pow(a, b));
//        }
//    }

//    internal class Abstract
//    {
//        static void Main(string[] args)
//        {
//            var calculator = new Calculator();

//            // Performing operations

//            calculator.Add(10, 5);
//            calculator.Subtract(10, 5);
//            calculator.Multiply(10, 5);

//            // Demonstrate division by a non-zero number

//            calculator.Divide(10, 2);

//            // Demonstrate division by zero

//            calculator.Divide(10, 0);

//            // Demonstrate power calculation

//            calculator.Power(2, 3);
//        }
//    }
//}
