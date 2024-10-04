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
            Console.WriteLine($"Resized array length : {resizableArray.Length} \n");

            resizableArray[3] = 4;


            // Array functions.

            int[] arr = { 4, 1, 3, 2, 3 };

            Console.WriteLine($"Array Length : {arr.Length}");

            int[,] multiArr = { { 1, 2 }, { 3, 4 }, { 5, 6 } };

            Console.WriteLine($"No of Rows : {multiArr.GetLength(0)}");
            Console.WriteLine($"No of Columns : {multiArr.GetLength(1)}");

            Console.WriteLine($"Upper Bound of 1D array : {arr.GetUpperBound(0)}");
            Console.WriteLine($"Lower Bound of 1D array : {arr.GetLowerBound(0)} \n");

            int index = Array.IndexOf(arr, 3);
            Console.WriteLine($"Index of 3 : {index}");

            int lastIndex = Array.LastIndexOf(arr, 3);
            Console.WriteLine($"Last Index of 3 : {lastIndex} \n");

            Array.Sort(arr);
            Console.WriteLine($"Sorted Array : {string.Join(", ", arr)}");

            Array.Reverse(arr);
            Console.WriteLine($"Reversed Array : {string.Join(", ", arr)} \n");

            Array.Clear(arr, 1, 2);
            Console.WriteLine($"Array after Clear : {string.Join(", ", arr)}");

            Array.Resize(ref arr, 7);
            Console.WriteLine($"Resized Array : {string.Join(", ", arr)} \n");

            int[] copyArr = new int[7];
            Array.Copy(arr, copyArr, arr.Length);
            Console.WriteLine($"Copied Array : {string.Join(", ", copyArr)}");

            int[] clonedArr = (int[])arr.Clone();
            Console.WriteLine($"Cloned Array : {string.Join(", ", clonedArr)} \n");

            bool exists = Array.Exists(arr, element => element == 4);
            Console.WriteLine($"Does 4 exist in array ? : {exists}");

            int found = Array.Find(arr, element => element > 1);
            Console.WriteLine($"First element > 1 : {found}");

            int[] foundAll = Array.FindAll(arr, element => element > 1);
            Console.WriteLine($"All elements > 1 : {string.Join(", ", foundAll)} \n");

            Array.Sort(arr);
            int searchIndex = Array.BinarySearch(arr, 2);
            Console.WriteLine($"Index of 2 after BinarySearch : {searchIndex}");

        }
    }
}
