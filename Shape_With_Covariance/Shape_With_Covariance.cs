using System;
using System.Collections.Generic;

namespace Shape_With_Covariance
{
    internal class Shape_With_Covariance
    {
        abstract class Shape
        {
            public abstract double GetArea();
            public abstract double GetPerimeter();
        }

        // Circle class inheriting Shape

        class Circle : Shape
        {
            public double Radius { get; set; }

            public override double GetArea()
            {
                return Math.PI * Radius * Radius;
            }

            public override double GetPerimeter()
            {
                return 2 * Math.PI * Radius;
            }
        }

        // Rectangle class inheriting Shape

        class Rectangle : Shape
        {
            public double Width { get; set; }
            public double Height { get; set; }

            public override double GetArea()
            {
                return Width * Height;
            }

            public override double GetPerimeter()
            {
                return 2 * (Width + Height);
            }
        }

        static void Main(string[] args)
        {
            // Create a list of shapes and add instances of Circle and Rectangle

            List<Shape> shapes = new List<Shape>
            {
                new Circle { Radius = 10.0 },
                new Rectangle { Width = 10.0, Height = 10.0 }
            };

            // Display area and perimeter for each shape

            foreach (Shape shape in shapes)
            {
                Console.WriteLine($"Area: {shape.GetArea()}");
                Console.WriteLine($"Perimeter: {shape.GetPerimeter()}");
                Console.WriteLine();
            }
        }
    }
}
