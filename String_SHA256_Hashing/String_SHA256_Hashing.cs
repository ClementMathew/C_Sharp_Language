using System;
using System.Security.Cryptography;
using System.Text;

namespace String_SHA256_Hashing
{
    class String_SHA256_Hashing
    {
        static void Main(string[] args)
        {
            string inputString = "Hello, World!";

            string hash = ComputeStringHash(inputString);
            Console.WriteLine($"SHA-256 Hash of the string:\n{hash}");

            string inputString2 = "Hello, World!";

            string hash2 = ComputeStringHash(inputString2);
            Console.WriteLine($"SHA-256 Hash of the string 2 :\n{hash2}");

            Console.WriteLine(hash == hash2);
        }

        public static string ComputeStringHash(string input)
        {
            byte[] inputBytes = Encoding.UTF8.GetBytes(input);

            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] hashBytes = sha256.ComputeHash(inputBytes);
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
