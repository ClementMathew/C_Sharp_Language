﻿using System;

namespace Area_of_Circle_Rectangle
{
    abstract class Shape
    {
        public abstract double Area();
    }

    class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public override double Area()
        {
            return Math.PI * Radius * Radius;
        }
    }

    class Rectangle : Shape
    {
        public double Length { get; set; }
        public double Width { get; set; }

        public Rectangle(double length, double width)
        {
            Length = length;
            Width = width;
        }

        public override double Area()
        {
            return Length * Width;
        }
    }

    internal class Area_of_Circle_Rectangle
    {
        static void Main(string[] args)
        {
            // Circle

            Shape circle = new Circle(5);

            Console.WriteLine($"Area of Circle: {circle.Area()}");

            // Rectangle

            Shape rectangle = new Rectangle(10, 5);

            Console.WriteLine($"Area of Rectangle: {rectangle.Area()}");
        }
    }
}
