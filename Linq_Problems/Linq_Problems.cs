using System;
using System.Collections.Generic;
using System.Linq;

namespace Linq_Problems
{
    class Product
    {
        public string Name { get; set; }
        public int Price { get; set; }
    }

    class Employee
    {
        public string Name { get; set; }
        public int DeptId { get; set; }
    }

    class Department
    {
        public int DeptId { get; set; }
        public string DeptName { get; set; }
    }

    internal class Linq_Problems
    {
        static void Main(string[] args)
        {
            // Sample data

            List<int> numbers = new List<int> { 1, 2, 3, 4, 12, 13, 14, 15, 16, 17, 60, 18, 20, 22, 1, 2, 4 };
            List<string> names = new List<string> { "Anil", "Mohan", "Neelima", "Mridula", "Bill", "Bony" };

            // 1. Filter Even Numbers

            IEnumerable<int> evenNumbers = numbers.Where(x => x % 2 == 0);
            Console.WriteLine($"Even Numbers: {string.Join(", ", evenNumbers)}");

            // 2. Sort in Descending Order

            IOrderedEnumerable<int> sortedDesc = numbers.OrderByDescending(x => x);
            Console.WriteLine($"\nSorted in Descending Order: {string.Join(", ", sortedDesc)}");

            // 3. Square of Each Number

            IEnumerable<int> squares = numbers.Select(x => x * x);
            Console.WriteLine($"\nSquares: {string.Join(", ", squares)}");

            // 4. Square of Even Numbers

            IEnumerable<int> evenSquares = evenNumbers.Select(x => x * x);
            Console.WriteLine($"\nSquares of Even Numbers: {string.Join(", ", evenSquares)}");

            // 5. Strings Starting with 'A'

            IEnumerable<string> namesStartingWithA = names.Where(s => s.StartsWith("A"));
            Console.WriteLine($"\nNames Starting with 'A': {string.Join(", ", namesStartingWithA)}");

            // 6. First String Starting with 'B'

            string firstB = names.FirstOrDefault(s => s.StartsWith("B"));
            Console.WriteLine($"\nFirst Name Starting with 'B': {firstB}");

            // 7. Group Words by Length

            IEnumerable<IGrouping<int, string>> groupedByLength = names.GroupBy(x => x.Length);
            Console.WriteLine("\nGrouped Words by Length:");

            foreach (IGrouping<int, string> group in groupedByLength)
            {
                Console.WriteLine($"Length {group.Key}: {string.Join(", ", group)}");
            }

            // 8. Find Maximum Value

            int maxValue = numbers.Max();
            Console.WriteLine($"\nMaximum Value: {maxValue}");

            // 9. Find Minimum Value

            int minValue = numbers.Min();
            Console.WriteLine($"Minimum Value: {minValue}");

            // 10. Check for Numbers Greater Than 50

            bool anyAbove50 = numbers.Any(x => x > 50);
            Console.WriteLine($"\nAny Number Greater than 50: {anyAbove50}");

            // 11. Sum of All Elements

            int sum = numbers.Sum();
            Console.WriteLine($"Sum of All Elements: {sum}");

            // 12. Check if All Numbers Are Positive

            bool allPositive = numbers.All(x => x > 0);
            Console.WriteLine($"All Numbers Positive: {allPositive}");

            // 13. Calculate Average

            List<double> decimalNumbers = new List<double> { 12.0, 17.8, 13.67, 10.0, 2.4, 3.14 };

            double average = decimalNumbers.Average();
            Console.WriteLine($"\nAverage: {average}");

            // 14. Remove Duplicates and Return Distinct Elements

            IEnumerable<int> distinctNumbers = numbers.Distinct();
            Console.WriteLine($"Distinct Elements: {string.Join(", ", distinctNumbers)}");

            // 15. Count of Numbers Greater Than 10

            int countAbove10 = numbers.Count(x => x > 10);
            Console.WriteLine($"Count of Elements Greater Than 10: {countAbove10}");

            // 16. Skip First 5 and Take the Next 3

            IEnumerable<int> skipAndTake = numbers.Skip(5).Take(3);
            Console.WriteLine($"\nAfter Skipping 5 and Taking 3: {string.Join(", ", skipAndTake)}");

            // 17. Zip Two Lists Together (Names and Ages)

            List<string> listOfNames = new List<string> { "Gatha", "Geethu", "Manu" };
            List<int> listOfAges = new List<int> { 23, 25, 30 };

            var zippedList = listOfNames.Zip(listOfAges, (name, age) => new { Name = name, Age = age });
            Console.WriteLine("\nZipped List of Names and Ages:");

            foreach (var item in zippedList)
            {
                Console.WriteLine($"{item.Name} : {item.Age}");
            }

            // 18. Students Scoring Above 80

            List<string> studentNames = new List<string> { "S1", "S2", "S3", "S4", "S5" };
            List<int> studentScores = new List<int> { 80, 90, 85, 40, 50 };

            IEnumerable<string> highScorers = studentNames.Zip(studentScores, (name, score) => new { Name = name, Score = score })
                                          .Where(s => s.Score > 80)
                                          .Select(s => s.Name);

            Console.WriteLine("\nStudents Scoring Above 80:");

            foreach (string name in highScorers)
            {
                Console.WriteLine(name);
            }

            // 19. Join Employees with Departments

            List<Employee> employees = new List<Employee>
            {
                new Employee { Name = "Aleena", DeptId = 1 },
                new Employee { Name = "Amritha", DeptId = 2 },
                new Employee { Name = "Akshara", DeptId = 1 }
            };
            List<Department> departments = new List<Department>
            {
                new Department { DeptId = 1, DeptName = "CS" },
                new Department { DeptId = 2, DeptName = "IT" }
            };
            var empWithDept = employees.Join(departments,
                                             e => e.DeptId,
                                             d => d.DeptId,
                                             (e, d) => new { EmployeeName = e.Name, DepartmentName = d.DeptName });

            Console.WriteLine("\nEmployee and Department Details:");

            foreach (var item in empWithDept)
            {
                Console.WriteLine($"{item.EmployeeName} - {item.DepartmentName}");
            }

            // 20. Filter and Sort Products by Price

            List<Product> products = new List<Product>
            {
                new Product { Name = "Colgate", Price = 180 },
                new Product { Name = "Brush", Price = 40 },
                new Product { Name = "Bottle", Price = 130 },
                new Product { Name = "Calculator", Price = 1000 }
            };
            IOrderedEnumerable<Product> filteredProducts = products.Where(p => p.Price > 100)
                                           .OrderBy(p => p.Price);

            Console.WriteLine("\nProducts Priced Above $100:");

            foreach (Product product in filteredProducts)
            {
                Console.WriteLine($"{product.Name} : {product.Price}");
            }
        }
    }
}
