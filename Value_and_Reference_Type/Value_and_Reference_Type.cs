using System;

namespace Value_and_Reference_Type
{
    internal class Value_and_Reference_Type
    {
        public class MyClass
        {
            public string Data { get; set; }
        }

        static void ChangeDataRefType(MyClass obj) => obj.Data = "New Data";

        static void ChangeDataValueType(int i) => i = 10;

        static void Main(string[] args)
        {
            // Reference Type

            MyClass obj = new MyClass() { Data = "Old Data" };

            Console.WriteLine($"Before Reference Type Change: {obj.Data}");

            ChangeDataRefType(obj);

            Console.WriteLine($"\nAfter Reference Type Change: {obj.Data}");

            // Value Type

            int i = 5;

            Console.WriteLine($"\nBefore Value Type Change: {i}");

            ChangeDataValueType(i);

            Console.WriteLine($"\nAfter Value Type Change: {i}");
        }
    }
}
