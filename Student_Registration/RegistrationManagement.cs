using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Registration
{
    internal class RegistrationManagement
    {
        private List<Student> students = new List<Student>();

        public void RegisterStudent(string name, string regNum, string @class, List<Marks> marks)
        {
            Student student = new Student();

            student.Name = name;
            student.RegNumber = regNum;
            student.Class = @class;
            student.Marks = marks;

            students.Add(student);

            Console.WriteLine("\nAdded successfully !");
        }

        public void SearchStudent(string regNum)
        {
            foreach (var student in students)
            {
                if (student.RegNumber == regNum)
                {
                    student.DisplayStudent();
                    return;
                }
            }
            Console.WriteLine("\nNot found !");
        }

        public void UpdateStudent(string regNum, string newName, string newClass)
        {
            foreach (var student in students)
            {
                if (student.RegNumber == regNum)
                {
                    student.Name = newName;
                    student.Class = newClass;

                    Console.WriteLine("\nUpdated successfully !");
                    return;
                }
            }
            Console.WriteLine("\nNo such student to update s!");
        }

        public void DeleteStudent(string regNum)
        {
            foreach (var student in students)
            {
                if (student.RegNumber == regNum)
                {
                    students.Remove(student);
                    Console.WriteLine("\nDeleted successfully !");
                    return;
                }
            }
            Console.WriteLine("\nNo such student to delete !");
        }
    }
}
