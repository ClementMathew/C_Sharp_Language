﻿using System;

namespace Appliances_Turn_On
{
    abstract class Appliance
    {
        public abstract void TurnOn();
    }

    class Fan : Appliance
    {
        public override void TurnOn()
        {
            Console.WriteLine("Fan is now ON.");
        }
    }
    internal class Appliances_Turn_On
    {

        static void Main(string[] args)
        {
            Appliance myFan = new Fan();

            myFan.TurnOn();
        }
    }
}
