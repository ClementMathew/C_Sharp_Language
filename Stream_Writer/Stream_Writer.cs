using System;
using System.IO;

namespace Stream_Writer
{
    class Stream_Writer
    {
        public static void Main()
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string filePath = Path.Combine(path, "DotNet", "Stream Writer", "stream.txt");

            Directory.CreateDirectory(Path.GetDirectoryName(filePath));

            // Use StreamWriter with FileMode.Append to add text to the file

            using (StreamWriter writer = new StreamWriter(filePath, append: true))
            {
                while (true)
                {
                    Console.Write("\nDo you wish to add 1 more line to the file? (Y/N): ");

                    if (Console.ReadKey().Key == ConsoleKey.Y)
                    {
                        Console.WriteLine();
                        string line = $"This is a line added at {DateTime.Now}";

                        // Write the line to the file

                        writer.WriteLine(line);
                        Console.WriteLine("Line added to the file.");
                    }
                    else
                    {
                        Console.WriteLine("\nExiting...");
                        break;
                    }
                }
            } // StreamWriter is automatically closed here due to 'using'
        }
    }
}
