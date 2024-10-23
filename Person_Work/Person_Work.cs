using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person_Work
{
    abstract class Person
    {
        public abstract void Work();
    }

    class Doctor : Person
    {
        public override void Work()
        {
            Console.WriteLine("Doctor is treating patients.");
        }
    }

    class Engineer : Person
    {
        public override void Work()
        {
            Console.WriteLine("Engineer is designing a project.");
        }
    }
    internal class Person_Work
    {

        static void Main(string[] args)
        {
            Person doctor = new Doctor();

            doctor.Work();

            Person engineer = new Engineer();

            engineer.Work();
        }
    }
}
