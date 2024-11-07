using System;
using System.Collections.Generic;

namespace Person_Address
{
    public class Addresses
    {
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string Address3 { get; set; }

        public override string ToString()
        {
            return $"The addresses are {Address1}, {Address2} and {Address3}";
        }
    }

    public class Person
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public List<Addresses> Addresses { get; set; }
        public List<Addresses> Addresses2 { get; set; } = new List<Addresses>();
    }

    internal class Person_Address
    {
        static void Main(string[] args)
        {

            // First Method of initialization.

            Person person = new Person();

            person.Name = "Clement";
            person.Email = "clement@mail.com";
            person.Addresses = new List<Addresses>();

            Addresses addresses = new Addresses();

            addresses.Address1 = "Home";
            addresses.Address2 = "Office";
            addresses.Address3 = "Work";

            person.Addresses.Add(addresses);

            Console.WriteLine($"First method : \n{addresses}");


            // Second Method of initialization.

            Person person2 = new Person();

            person2.Name = "Clement";
            person2.Email = "clement@mail.com";
            person2.Addresses = new List<Addresses>();

            person2.Addresses.Add(new Addresses { Address1 = "Home", Address2 = "Office", Address3 = "Work" });

            Console.WriteLine($"\nSecond method : ");

            foreach (Addresses address in person2.Addresses)
            {
                Console.WriteLine(address);
            }

            // Third method of initialization.

            Person person3 = new Person();

            person3.Name = "Clement";
            person3.Email = "clement@mail.com";
            person3.Addresses = new List<Addresses>
            {
                new Addresses { Address1 = "Home",  Address2 = "Work",Address3 = "Office"},
                new Addresses { Address1 = "Home",  Address2 = "Work",Address3 = "Office"}
            };

            Console.WriteLine($"\nThird method : ");

            foreach (Addresses address in person3.Addresses)
            {
                Console.WriteLine(address);
            }

            // Fourth Method

            Person person4 = new Person();

            person4.Name = "Clement";
            person4.Email = "clement@mail.com";
            person4.Addresses2.Add(new Addresses { Address1 = "Home", Address2 = "Work", Address3 = "Office" });

            Console.WriteLine($"\nFourth method : ");

            foreach (Addresses address in person4.Addresses2)
            {
                Console.WriteLine(address);
            }
        }
    }
}
