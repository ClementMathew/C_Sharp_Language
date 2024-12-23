﻿using System;

namespace College_and_School_Student
{
    class Student
    {
        public string Name { get; set; }
        public string Email { get; set; }
    }

    class College : Student
    {
        public string CollegeName { get; set; }

        public override string ToString()
        {
            return $"The student {Name} with id {Email} studying in {CollegeName}";
        }
    }

    class School : Student
    {
        public string SchoolName { get; set; }

        public override string ToString()
        {
            return $"The student {Name} with id {Email} studying in {SchoolName}";
        }
    }

    internal class College_and_School_Student
    {
        static void Main(string[] args)
        {
            College stud = new College();

            stud.Name = "Clement";
            stud.Email = "clement@mail.com";
            stud.CollegeName = "Gec Wayanad";

            School stud1 = new School();

            stud1.Name = "John";
            stud1.Email = "john@mail.com";
            stud1.SchoolName = "GHS Ayoor";

            Console.WriteLine(stud);
            Console.WriteLine(stud1);
        }
    }
}
