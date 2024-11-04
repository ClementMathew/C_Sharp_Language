﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics_List_and_Dictionary
{
    // Generic SortedList class

    public class SortedList<T>
    {
        private List<T> _data = new List<T>();

        public int Count => _data.Count;

        public void Add(T data)
        {
            _data.Add(data);
            _data.Sort();
        }

        public void PrintData()
        {
            Console.WriteLine("Sorted List Data: ");
            foreach (var item in _data)
            {
                Console.WriteLine(item);
            }
        }
    }

    // Generic NewDictionary class

    class NewDictionary<T, TValue>
    {
        private Dictionary<T, TValue> _data = new Dictionary<T, TValue>();

        public int Count => _data.Count;

        public void Add(T key, TValue value)
        {
            _data.Add(key, value);
        }

        public void PrintData()
        {
            Console.WriteLine("Dictionary Data: ");
            foreach (var kvp in _data)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
    }

    internal class Generics_List_and_Dictionary
    {
        static void Main(string[] args)
        {
            // Example usage of SortedList with integers

            var numberList = new SortedList<int>();

            numberList.Add(1);
            numberList.Add(2);
            numberList.PrintData();

            // Example usage of SortedList with strings

            var stringList = new SortedList<string>();

            stringList.Add("hello");
            stringList.PrintData();

            // Example usage of NewDictionary with integer keys and string values

            var dict = new NewDictionary<int, string>();

            dict.Add(1, "One");
            dict.Add(2, "Two");
            dict.PrintData();
        }
    }
}
