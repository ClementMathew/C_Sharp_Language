using System;
using System.Collections.Generic;
using System.Linq;

namespace Person_Country
{
    class Person
    {
        public string Name { get; set; }
        public string Country { get; set; }
        public int Age { get; set; }

        public override string ToString()
        {
            return $"Name -> {Name}, Country -> {Country}, Age -> {Age}";
        }
    }

    internal class Person_Country
    {
        static void Main(string[] args)
        {

            // Persons Problem

            List<Person> data2 = new List<Person>()
            {
              new Person{Name="Person 1", Country="US", Age=20},
              new Person{Name="Person 2", Country="US", Age=30},
              new Person{Name="Person 3", Country="US", Age=40},
              new Person{Name="Person 4", Country="IN", Age=50}
            };


            // Persons where country is US.

            IEnumerable<Person> res2 = data2.Where(p => p.Country == "US");

            Console.Write($"US Country : ");

            foreach (Person person in res2)
            {
                Console.WriteLine(person.Name);
            }


            // Minimum Age of Person in US.

            int minAge = data2.Where(p => p.Country == "US").Min(p => p.Age);

            Console.WriteLine($"\nMinimum Age in US Country : {minAge}");


            // Person with Minimum Age.

            Person firstPerson = data2.Where(p => p.Country == "US" && p.Age == minAge).FirstOrDefault();

            Console.WriteLine($"\nPerson with Minimum Age in US Country : {firstPerson}");


            // Order Person by their Age.

            IOrderedEnumerable<Person> sorted2 = data2.OrderByDescending(p => p.Age);

            Console.WriteLine($"\nPersons in order of age : ");

            foreach (Person person in sorted2)
            {
                Console.WriteLine(person.Name);
            }


            // List of Distinct Countries.

            IEnumerable<string> distinctCountries = data2.Select(p => p.Country).Distinct();

            Console.WriteLine($"\nList of Countries : ");

            foreach (string person in distinctCountries)
            {
                Console.WriteLine(person);
            }


            // Select to Dictionary.

            IEnumerable<Dictionary<string, string>> countries = data2.Select(p => new Dictionary<string, string>()
            {
                { "Name", p.Name },
                { "Country", p.Country }
            });

            Console.WriteLine("\nThe names and country in Dictionary : \n");

            foreach (Dictionary<string, string> country in countries)
            {
                foreach (KeyValuePair<string, string> person in country)
                {
                    Console.Write($"{person.Key} -> {person.Value} | ");
                }
                Console.WriteLine();
            }


            // Group by country and count of persons in each country.

            IEnumerable<IGrouping<string, Person>> groups = data2.GroupBy(p => p.Country);

            Console.WriteLine($"\nCount of persons in each country : ");

            foreach (IGrouping<string, Person> group in groups)
            {
                Console.WriteLine($"{group.Key} - {group.Count()}");

                foreach (Person person in group)
                {
                    Console.WriteLine($"\t{person.Name}");
                }
            }
        }
    }
}

