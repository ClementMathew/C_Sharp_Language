using System;
using System.Collections.Generic;

namespace Interfaces
{
    interface IStudent
    {
        string Name { get; set; }

        void Display();
    }

    class SchoolStudent : IStudent
    {
        public string Name { get; set; }
        public const string SchoolName = "School X";

        public void Display()
        {
            Console.WriteLine($"Student Name: {Name} | School Name: {SchoolName}");
        }
    }

    class CollegeStudent : IStudent
    {
        public string Name { get; set; }
        public const string CollegeName = "College X";

        public void Display()
        {
            Console.WriteLine($"Student Name: {Name} | College Name: {CollegeName}");
        }
    }

    internal class Interface
    {
        static void Main()
        {
            List<IStudent> students = new List<IStudent>
            {
                new SchoolStudent { Name = "John" },
                new SchoolStudent { Name = "Jane" },
                new CollegeStudent { Name = "Mark" },
                new CollegeStudent { Name = "Mary" }
            };

            foreach (IStudent student in students)
            {
                student.Display();
            }
        }
    }
}

