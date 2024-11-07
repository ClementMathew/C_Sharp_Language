using System;
using System.Collections.Generic;

namespace Student_Registration
{
    internal class Student_Registration
    {
        static RegistrationManagement manage = new RegistrationManagement();

        static void Main(string[] args)
        {
            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("\n1. Register Student");
                Console.WriteLine("2. Search Student");
                Console.WriteLine("3. Update Student");
                Console.WriteLine("4. Remove Student");
                Console.WriteLine("5. Exit");

                Console.Write("\nSelect an option : ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        GetStudentData();
                        break;

                    case "2":
                        SearchStudentData();
                        break;

                    case "3":
                        UpdateStudentData();
                        break;

                    case "4":
                        DeleteStudentData();
                        break;

                    case "5":
                        exit = true;
                        Console.WriteLine("\nExiting...");
                        break;

                    default:
                        Console.WriteLine("\nInvalid option. Please try again.");
                        break;
                }
            }
        }

        private static void DeleteStudentData()
        {
            Console.WriteLine("\nEnter the registration number : ");
            string regNum = Console.ReadLine();

            manage.DeleteStudent(regNum);
        }

        private static void UpdateStudentData()
        {
            Console.WriteLine("\nEnter registration number : ");
            string regNum = Console.ReadLine();

            Console.WriteLine("Enter the new name : ");
            string newName = Console.ReadLine();

            Console.WriteLine("Enter the new class : ");
            string newClass = Console.ReadLine();

            manage.UpdateStudent(regNum, newName, newClass);
        }

        private static void SearchStudentData()
        {
            Console.WriteLine("\nEnter the registration number : ");
            string regNum = Console.ReadLine();

            manage.SearchStudent(regNum);
        }

        private static void GetStudentData()
        {
            Console.WriteLine("\nEnter name of student : ");
            string name = Console.ReadLine();

            Console.WriteLine("Enter registration number : ");
            string regNum = Console.ReadLine();

            Console.WriteLine("Enter class : ");
            string @class = Console.ReadLine();

            List<Marks> marks = new List<Marks>();

            while (true)
            {
                Marks mark = new Marks();

                Console.WriteLine("Do you want to add marks (Yes/No) : ");
                string status = Console.ReadLine();

                if (status == "Yes")
                {
                    Console.WriteLine("Enter the subject name : ");
                    string subName = Console.ReadLine();

                    Console.WriteLine("Enter the max marks ; ");
                    int maxMarks = int.Parse(Console.ReadLine());

                    Console.WriteLine("Enter the scored marks ; ");
                    int scoredMarks = int.Parse(Console.ReadLine());

                    mark.SubjectName = subName;
                    mark.MaxMark = maxMarks;
                    mark.MarkScored = scoredMarks;

                    marks.Add(mark);
                }
                else
                {
                    break;
                }
            }

            manage.RegisterStudent(name, regNum, @class, marks);
        }
    }
}
