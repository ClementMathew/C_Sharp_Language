using System;

namespace Vehicle_Drive_Speed
{
    abstract class Vehicle
    {
        public int Speed { get; set; }

        public abstract void Drive();
    }

    class Car : Vehicle
    {
        public override void Drive()
        {
            Console.WriteLine($"Car is driving at {Speed} km/h.");
        }
    }

    class Bicycle : Vehicle
    {
        public override void Drive()
        {
            Console.WriteLine($"Bicycle is riding at {Speed} km/h.");
        }
    }

    internal class Vehicle_Drive_Speed
    {
        static void Main(string[] args)
        {
            // Car Speed

            Vehicle car = new Car { Speed = 100 };

            car.Drive();

            // Bicycle Speed

            Vehicle bicycle = new Bicycle { Speed = 15 };

            bicycle.Drive();
        }
    }
}