using System;
using System.Diagnostics;
using System.IO;
using System.Text;

namespace Streamer_and_Appender
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }

    internal class Streamer_and_Appender
    {
        private static Person[] data = new Person[50000];
        private static string csvRow = "{0},{1}";

        // Method to write using StreamWriter

        static void WriteUsingStreamWriter()
        {
            Stopwatch watch = new Stopwatch();
            watch.Start();

            string targetPath = @"C:\Users\cleme\Documents\DotNet\File Stream\data-stream.csv";

            using (StreamWriter streamWriter = new StreamWriter(targetPath, true, Encoding.UTF8))
            {
                foreach (Person item in data)
                {
                    if (item != null)
                    {
                        string textToWrite = string.Format(csvRow, item.Name, item.Age);
                        streamWriter.WriteLine(textToWrite);
                    }
                }
            }

            watch.Stop();
            Console.WriteLine($"StreamWriter: {watch.ElapsedMilliseconds / 1000.0} seconds");
        }

        // Method to write using AppendAllText

        static void WriteUsingAppendAllText()
        {
            Stopwatch watch = new Stopwatch();
            watch.Start();

            string targetPath = @"C:\Users\cleme\Documents\DotNet\File Stream\data-append.csv";

            foreach (Person item in data)
            {
                if (item != null)
                {
                    string textToWrite = string.Format(csvRow, item.Name, item.Age);
                    File.AppendAllText(targetPath, textToWrite + Environment.NewLine);
                }
            }

            watch.Stop();
            Console.WriteLine($"AppendAllText: {watch.ElapsedMilliseconds / 1000.0} seconds");
        }

        public static void Main()
        {
            // Populate the data array with sample data

            for (int i = 0; i < data.Length; i++)
            {
                data[i] = new Person() { Name = $"Person{i + 1}", Age = 20 + (i % 30) };
            }

            // Writing data

            WriteUsingStreamWriter();

            WriteUsingAppendAllText();
        }
    }
}
