using System;

namespace Interface_Segregation_Principle
{
    // Separate, specific interfaces

    public interface IPrinter
    {
        void Print(string content);
    }

    public interface IScanner
    {
        void Scan(string content);
    }

    // Multi-function printer implements both printing and scanning

    public class MultiFunctionPrinter : IPrinter, IScanner
    {
        public void Print(string content) => Console.WriteLine("Printing: " + content);
        public void Scan(string content) => Console.WriteLine("Scanning: " + content);
    }

    // Simple printer implements only printing

    public class SimplePrinter : IPrinter
    {
        public void Print(string content) => Console.WriteLine("Printing: " + content);
    }

    // Client code

    internal class Interface_Segregation_Principle
    {
        static void Main(string[] args)
        {
            IPrinter simplePrinter = new SimplePrinter();
            simplePrinter.Print("Simple document");

            IPrinter multiPrinter = new MultiFunctionPrinter();
            IScanner scanner = (IScanner)multiPrinter;
            multiPrinter.Print("Multi-function document");
            scanner.Scan("Multi-function document");
        }
    }
}


