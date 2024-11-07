using System;
using System.Collections.Generic;

namespace List_Inside_List
{
    internal class List_Inside_List
    {
        static void Main(string[] args)
        {
            // Store the marks of 3 subjects of 2 students using list in list.

            List<List<int>> data = new List<List<int>>();

            for (int i = 0; i < 2; i++)
            {
                List<int> Marks = new List<int>();

                for (int j = 1; j <= 3; j++)
                {
                    Console.Write($"Enter the mark of student {i} in {j} subject : ");

                    int mark = int.Parse(Console.ReadLine());
                    Marks.Add(mark);
                }
                data.Add(Marks);
            }

            // Displaying the mark

            foreach (List<int> Marks in data)
            {
                Console.WriteLine($"The mark of students are : ");

                foreach (int Mark in Marks)
                {
                    Console.WriteLine(Mark);
                }
                Console.WriteLine();
            }
        }
    }
}
