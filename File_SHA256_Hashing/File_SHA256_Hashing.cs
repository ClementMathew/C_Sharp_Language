using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace File_SHA256_Hashing
{
    class File_SHA256_Hashing
    {
        static void Main(string[] args)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string filePath = Path.Combine(path, "DotNet", "Hashing", "File_SHA256.txt");

            try
            {
                string hash = ComputeFileHash(filePath);

                Console.WriteLine($"SHA-256 Hash of the file:\n{hash}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }

        public static string ComputeFileHash(string filePath)
        {
            using (FileStream stream = File.OpenRead(filePath))
            {
                using (SHA256 sha256 = SHA256.Create())
                {
                    byte[] hashBytes = sha256.ComputeHash(stream);

                    StringBuilder sb = new StringBuilder();

                    foreach (byte b in hashBytes)
                    {
                        sb.Append(b.ToString("x2"));
                    }
                    return sb.ToString();
                }
            }
        }
    }

}
