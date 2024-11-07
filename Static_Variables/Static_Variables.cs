using System;

namespace Static_Variables
{
    class Employee
    {
        // Property for employee name
        public string Name { get; set; }

        // Static property for company name
        public static string CompanyName { get; set; }

        // Override ToString method to display employee information

        public override string ToString()
        {
            return $"Name: {Name}, Company: {CompanyName}";
        }
    }

    internal class Static_Variables
    {
        static void Main(string[] args)
        {
            // Setting the static CompanyName property

            Employee.CompanyName = "Old Name";

            // Creating employee instances

            Employee e1 = new Employee { Name = "E1" };
            Employee e2 = new Employee { Name = "E2" };

            // Displaying employee details before changing the company name

            Console.WriteLine(e1);
            Console.WriteLine(e2);

            // Changing the static CompanyName property

            Employee.CompanyName = "New Name";

            // Displaying employee details after changing the company name

            Console.WriteLine(e1);
            Console.WriteLine(e2);
        }
    }
}
