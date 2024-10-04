using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Arrays
    {
        static void Main(string[] args)
        {

            // Array datatype.

            int[] array = new int[10];
            Console.WriteLine($"Nonnullable array first element : {array[0]}");

            int?[] nullableArray = new int?[10];
            Console.WriteLine($"Nullable array first element : {nullableArray[0]}");

            int[] numbers = { 2, 5, 6, 7, 8 };
            Console.WriteLine($"Initialized array third element : {numbers[2]} \n");


            // Read to array and print the values.

            int[] myArray = new int[5];

            Console.WriteLine("Enter the values : ");

            for (int i = 0; i < 5; i++)
            {
                myArray[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("The values are : ");

            for (int i = 0; i < 5; i++)
            {
                Console.Write(myArray[i] + " ");
            }

            Console.WriteLine("\nBy another method the values are : ");
            Console.WriteLine(string.Join(" ", myArray));


            // Sum of even numbers in an array.

            int n;

            Console.WriteLine("\nEnter the number of elements : ");
            n = int.Parse(Console.ReadLine());

            int[] myArray2 = new int[n];
            int evenSum = 0;

            Console.WriteLine("Enter the values : ");

            for (int i = 0; i < n; i++)
            {
                myArray2[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("The even sum is : ");

            for (int i = 0; i < n; i++)
            {
                if (myArray2[i] % 2 == 0)
                {
                    evenSum += myArray2[i];
                }
            }
            Console.Write(evenSum + "\n");


            // String array.

            string[] nullString = new string[3];
            Console.WriteLine($"\nUninitialized null string array first element : {nullString[0]}");

            string[] nullStringTwo = { null, null, null };
            Console.WriteLine($"Initialized null string array first element : {nullStringTwo[0]}");

            string[] emptyString = new string[3] { "", "", "" };
            Console.WriteLine($"Empty string array first element : {emptyString[0]}");

            string[] names = new string[3] { "anu", "binu", "cinu" };
            Console.WriteLine($"Initialized string array first element in uppercase : {names[0].ToUpper()}");

            // Null check operator.

            Console.WriteLine($"\nNull check operator in string array functions : {nullString[0]?.ToLower()}");


            // Array resizing.

            int[] resizableArray = new int[3];
            resizableArray[0] = 1;
            resizableArray[1] = 2;
            resizableArray[2] = 3;

            Console.WriteLine($"Array length before resizing : {resizableArray.Length}");
            Array.Resize(ref resizableArray, resizableArray.Length * 2);
            Console.WriteLine($"Resized array length : {resizableArray.Length}");

            resizableArray[3] = 4;


            // Array functions.

            var theArray = new int[2] { 2, 1 };

            //Array.Copy(arr2, arr3, 2);
            //Array.Clear(arr3, 1, 1);
            //Array.Sort();

        }
    }
}
