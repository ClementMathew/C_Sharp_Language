using System;

namespace Employee_Bonus
{
    class Employee
    {
        public virtual double CalculateBonus()
        {
            return 1000; // Default bonus
        }
    }

    class Manager : Employee
    {
        public override double CalculateBonus()
        {
            return 5000; // Manager bonus
        }
    }
    internal class Employee_Bonus
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            Manager mgr = new Manager();

            Console.WriteLine("Employee bonus: " + emp.CalculateBonus());
            Console.WriteLine("Manager bonus: " + mgr.CalculateBonus());
        }
    }
}
