using System;
using System.Runtime.CompilerServices;

namespace Username_Valid_Or_Invalid
{
    class User
    {
        private string _name;

        public string Name
        {
            get => _name;
            set
            {
                CheckIsEmpty(value);
                _name = value;
            }
        }

        // Validation method using [CallerMemberName]

        private void CheckIsEmpty(string value, [CallerMemberName] string propertyName = "")
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                Console.WriteLine($"{propertyName} is invalid");
            }
            else
            {
                Console.WriteLine($"{propertyName} is valid");
            }
        }
    }

    internal class Username_Valid_Or_Invalid
    {
        static void Main(string[] args)
        {
            User user = new User();

            user.Name = "Alice";

            user.Name = "";
        }
    }
}
