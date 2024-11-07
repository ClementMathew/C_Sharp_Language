﻿using System;

namespace Employee_Annual_Salary
{
    class Employee
    {
        public string FirstName;
        public string LastName;
        public int Salary;

        public void TotalSalary()
        {
            Console.WriteLine($"Total Salary : {Salary * 12}");
        }
    }

    internal class Employee_Annual_Salary
    {
        static void Main(string[] args)
        {
            Employee e1 = new Employee();

            e1.FirstName = "Clement";
            e1.LastName = "Mathew";
            e1.Salary = 10_000;
            e1.TotalSalary();

            Employee e2 = new Employee();

            e2.FirstName = "Sheba";
            e2.LastName = "Mathew";
            e2.Salary = 12_000;
            e2.TotalSalary();
        }
    }
}
