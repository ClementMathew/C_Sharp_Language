using System;
using System.IO;

namespace Write_Image_File
{
    class Write_Image_File
    {
        public static void Main()
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            string filePath = Path.Combine(path, "DotNet", "Images", "image.png");
            string targetPath = Path.Combine(path, "DotNet", "Images", "NEWFILE.png");

            try
            {
                // Read the content of the original file

                byte[] content = File.ReadAllBytes(filePath);

                // Write the content to the new file

                File.WriteAllBytes(targetPath, content);

                Console.WriteLine("File copied successfully!");
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("The source file was not found.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }
    }
}
