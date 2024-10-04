using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //// Custom replace from string

            //string sentence = "My name is Clement";
            //Console.WriteLine(sentence.Replace("Clement","Mathew"));

            //// 

            //Console.WriteLine("Enter the string : ");
            //string str = Console.ReadLine();

            //string[] arr = str.Split(' ');
            //string[] counter = new string[arr.Length];

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    int count = 0;
            //    for (int j = 0; j < arr.Length; j++)
            //    {
            //        if (arr[i] == arr[j])
            //        {
            //            count++;
            //        }
            //    }
            //    Console.WriteLine(arr[i] + ":" + count);
            //    if (count > 1)
            //    {
            //        counter[]
            //    }
            //}

            // foreach

            // palindrome

            //Console.WriteLine("Enter a string:");
            //string input = Console.ReadLine();

            //char[] charArray = input.ToCharArray();
            //Array.Reverse(charArray);
            //string reversedInput = new string(charArray);

            //if (input == reversedInput)
            //{
            //    Console.WriteLine("The string is a palindrome.");
            //}
            //else
            //{
            //    Console.WriteLine("The string is not a palindrome.");
            //}

            // StringBuilder

            //var sb = new StringBuilder();
            //string[] names = { "Clement", "Mathew", "Sheba" };

            //for (int i = 0; i < names.Length; i++)
            //{
            //    sb.AppendLine($"{names[i]} is {i} years old.");
            //}
            //Console.WriteLine(sb.ToString());

            // 

            //string[] numbers = {"One","2","Three","Four","5" };

            //for (int i=0;i< numbers.Length;i++)
            //{
            //    if (numbers[i] == "1")
            //    {
            //        numbers[i] = "One";
            //    }
            //    if (numbers[i] == "2")
            //    {
            //        numbers[i] = "Two";
            //    }
            //    if (numbers[i] == "3")
            //    {
            //        numbers[i] = "Three";
            //    }
            //    if (numbers[i] == "4")
            //    {
            //        numbers[i] = "Four";
            //    }
            //    if (numbers[i] == "5")
            //    {
            //        numbers[i] = "Five";
            //    }
            //    Console.WriteLine(numbers[i]);
            //}

            // vowels print

            string text = "Clement";

            foreach (var item in text)
            {
                if (item == 'a' || item =='e' || item == 'i' || item == 'o' || item == 'u')
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}
