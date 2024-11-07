using System;

namespace Student_Marks_by_Array_of_Class
{
    internal class Student_Total_Mark_by_Array_of_Class
    {
        static void Main(string[] args)
        {
            Student s1 = new Student
            {
                Name = "Student1",
                Mark1 = 10,
                Mark2 = 20
            };
            Student s2 = new Student
            {
                Name = "Student2",
                Mark1 = 10,
                Mark2 = 20
            };
            Student s3 = new Student
            {
                Name = "Student3",
                Mark1 = 10,
                Mark2 = 20
            };

            Student[] students = new Student[5];
            students[0] = s1;
            students[1] = s2;
            students[2] = s3;

            foreach (Student student in students)
            {
                if (student != null)
                    Console.WriteLine(student.Name);
            }
        }
    }
}
