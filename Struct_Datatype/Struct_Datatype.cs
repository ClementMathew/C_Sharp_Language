using System;

namespace Struct_Datatype
{
    interface IStruct
    {
        string Name { get; }
    }

    // Can implement interface

    struct Point : IStruct
    {
        public int X { get; set; }
        public int Y { get; set; }

        public string Name => throw new NotImplementedException();
    }

    internal class Struct_Datatype
    {
        static void Main(string[] args)
        {
            // Declaring struct array

            Point[] points = new Point[5];

            //points[0] = null; -- Not Possible

            Console.WriteLine(points[0].X);

            // Initializing struct

            Point p1 = new Point() { X = 1, Y = 10 };

            Console.WriteLine(p1.X + " " + p1.Y);
        }
    }
}
