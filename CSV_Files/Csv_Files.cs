using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using CsvHelper;

namespace CSV_Files
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    internal class Csv_Files
    {
        static void Main(string[] args)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            string filePath = Path.Combine(path, "DotNet", "CSV Files", "data.csv");

            Directory.CreateDirectory(Path.GetDirectoryName(filePath));

            List<Person> records = new List<Person>
            {
                new Person { Id = 1, Name = "one" },
                new Person { Id = 2, Name = "two" },
            };

            // CSV Writing

            using (StreamWriter writer = new StreamWriter(filePath))
            {
                using (CsvWriter csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
                {
                    csv.WriteRecords(records);
                }
            }

            // CSV Reading

            using (StreamReader reader = new StreamReader(filePath))
            {
                using (CsvReader csv = new CsvReader(reader, CultureInfo.InvariantCulture))
                {
                    IEnumerable<Person> persons = csv.GetRecords<Person>();
                    foreach (Person item in persons)
                    {
                        Console.WriteLine(item.Id);
                        Console.WriteLine(item.Name);
                    }
                }
            }
        }
    }
}
