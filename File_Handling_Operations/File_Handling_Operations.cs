using System;
using System.IO;

namespace File_Handling_Operations
{
    internal class File_Handling_Operations
    {
        static void Main()
        {
            string path = @"C:\Users\cleme\Documents\DotNet\File Handling";
            string fileName = "Data.txt";

            string filePath = Path.Combine(path, fileName);

            // Directory operations

            if (Directory.Exists(path))
            {
                Console.WriteLine("Directory exists.");
            }
            else
            {
                Console.WriteLine("Directory does not exist. Creating it...");

                Directory.CreateDirectory(path);
            }

            // File operations

            if (File.Exists(filePath))
            {
                Console.WriteLine("File exists.");
            }
            else
            {
                Console.WriteLine("File does not exist. Creating it...");

                File.WriteAllText(filePath, "Initial content in the file.");
            }

            // Append text to the file

            File.AppendAllText(filePath, "\nAppending some text.");
            File.AppendAllText(filePath, "\nAdding more content.");

            // Reading the entire file content

            string content = File.ReadAllText(filePath);

            Console.WriteLine("\nFile Content:\n" + content);

            // Reading file content line by line

            string[] contentLines = File.ReadAllLines(filePath);

            Console.WriteLine("\nFile Content (Line by Line):");

            foreach (string line in contentLines)
            {
                Console.WriteLine(line);
            }

            // Rename the file

            string newFilePath = Path.Combine(path, "RenamedFile.txt");

            File.Move(filePath, newFilePath);

            Console.WriteLine("\nFile renamed.");

            // List all files in the Directory

            string[] files = Directory.GetFiles(path);

            Console.WriteLine("\nFiles in the folder :");

            foreach (string file in files)
            {
                Console.WriteLine(file);
            }

            // Delete the file

            Console.WriteLine("\nDeleting the file...");

            File.Delete(filePath);

            // Delete the directory

            Console.WriteLine("Deleting the directory...");

            Directory.Delete(path, true);

            Console.WriteLine("\nOperations complete.");
        }
    }
}


