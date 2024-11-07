using System;

namespace Array_Resizing_Manually
{
    internal class Array_Resizing_Manually
    {
        static void Main(string[] args)
        {
            int[] arr = new int[1];
            bool running = true;
            int size = 1;

            Console.WriteLine("Enter the first number:");
            arr[0] = int.Parse(Console.ReadLine());

            while (running)
            {
                Console.WriteLine("Do you want to continue? (Yes/No)");
                string status = Console.ReadLine();

                if (status == "Yes")
                {
                    int[] arr2 = new int[size + 1];

                    for (int i = 0; i < arr.Length; i++)
                    {
                        arr2[i] = arr[i];
                    }

                    Console.WriteLine("Enter the next number:");
                    arr2[size] = int.Parse(Console.ReadLine());

                    arr = arr2;
                    size++;
                }
                else
                {
                    running = false;
                }
            }

            Console.WriteLine("The numbers entered are:");
            foreach (int number in arr)
            {
                Console.Write(number + " ");
            }
            Console.ReadKey();
        }
    }
}
