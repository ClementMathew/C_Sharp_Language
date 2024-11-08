using System;

namespace Operator_Overloading
{
    public class Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        // Overloading the + operator to add two points

        public static Point operator +(Point p1, Point p2)
        {
            return new Point()
            {
                X = p1.X + p2.X,
                Y = p1.Y + p2.Y
            };
        }

        // Overloading the - operator to add two points

        public static Point operator -(Point p1, Point p2)
        {
            return new Point()
            {
                X = p1.X - p2.X,
                Y = p1.Y - p2.Y
            };
        }
    }
    internal class Operator_Overloading
    {
        static void Main(string[] args)
        {
            // Normal

            int a = 5;
            int b = 6;
            int c = a + b;

            // Adding using objects

            Point p1 = new Point() { X = 1, Y = 2 };
            Point p2 = new Point() { X = 3, Y = 4 };

            Point p3 = p1 + p2;

            Console.WriteLine($"Resulting Point: X = {p3.X}, Y = {p3.Y}");

            // Subtracting using objects

            Point p4 = p1 - p2;

            Console.WriteLine($"Resulting Point: X = {p4.X}, Y = {p4.Y}");

        }
    }
}

