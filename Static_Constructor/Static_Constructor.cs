using System;

namespace Static_Constructor
{
    class Employee
    {
        public string Name { get; set; }
        public static string CompanyName { get; set; }

        static Employee()
        {
            CompanyName = "Microsoft";
        }

        public Employee(string name) => Name = name;

        public override string ToString() => Name + " " + CompanyName;

    }
    internal class Static_Constructor
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Company Name :" + Employee.CompanyName);

            Employee e1 = new Employee("Joe");

            Console.WriteLine(e1);
        }
    }
}
