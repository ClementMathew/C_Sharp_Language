using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Async_File_Reading
{
    internal class Async_File_Reading
    {
        public static async Task Main(string[] args)
        {

            string path = @"C:\Users\cleme\Documents";
            string fileName = "sample.txt"; // Path to the file you want to read

            var filePath = Path.Combine(path, fileName);

            if (Directory.Exists(path))
            {
                Console.WriteLine("Exists.");
            }
            else
            {
                Directory.CreateDirectory(path);
            }

            try
            {

            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("Error: The file was not found.");
            }
            catch (UnauthorizedAccessException)
            {
                Console.WriteLine("Error: You do not have permission to access this file.");
            }
            catch (IOException ex)
            {
                Console.WriteLine($"An I/O error occurred: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An unexpected error occurred: {ex.Message}");
            }
        }
    }
}

