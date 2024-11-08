using System;
using System.IO;
using System.Text;

namespace File_Stream
{
    class File_Stream
    {
        public static void Main()
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string filePath = Path.Combine(path, "DotNet", "File Stream", "Basics", "stream.txt");

            Directory.CreateDirectory(Path.GetDirectoryName(filePath));

            // Open a FileStream with FileMode.Append

            using (FileStream stream = new FileStream(filePath, FileMode.Append, FileAccess.Write))
            {
                while (true)
                {
                    Console.Write("\nDo you wish to add 1 more line to the file? (Y/N): ");

                    if (Console.ReadKey().Key == ConsoleKey.Y)
                    {
                        Console.WriteLine();
                        string s = $"This is a line added at {DateTime.Now}{Environment.NewLine}";

                        byte[] dataToWrite = Encoding.UTF8.GetBytes(s);

                        // Write data to the file

                        stream.Write(dataToWrite, 0, dataToWrite.Length);
                        stream.Flush();

                        Console.WriteLine("Line added to the file.");
                    }
                    else
                    {
                        Console.WriteLine("\nExiting...");
                        break;
                    }
                }
            } // Stream is automatically closed here due to 'using'
        }
    }
}

