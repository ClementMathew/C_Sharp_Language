using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Registration
{
    internal class Student
    {
        public string Name;
        public string RegNumber;
        public string Class;
        public List<Marks> Marks;

        public void DisplayStudent()
        {
            Console.WriteLine($"\nThe student {Name} is registered with {RegNumber} to the class {Class}.\n\nMarks\n---------------\n");
            ShowMarks();
        }

        public void ShowMarks()
        {
            foreach (Marks mark in Marks)
            {
                Console.WriteLine(mark);
            }
        }
    }
}
