using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace SQL_and_C_
{
    internal class SQL_and_C_
    {
        const string connString = @"Data Source=localhost\SQLExpress;Initial Catalog=Book_Library;Integrated Security=True";

        static void Main(string[] args)
        {

            // Sample user input for adding a book to the database

            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.Write("Author: ");
            string author = Console.ReadLine();

            Console.Write("Price: ");
            string price = Console.ReadLine();

            string insertQuery = $"INSERT INTO Books(name, author, price) VALUES(@name, @author, @price)";

            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                SqlCommand command = new SqlCommand(insertQuery, conn);

                command.Parameters.AddWithValue("@name", name);
                command.Parameters.AddWithValue("@author", author);
                command.Parameters.AddWithValue("@price", price);

                command.ExecuteNonQuery();
            }

            // Select statement to retrieve records

            string query = $"SELECT id, name, author, price from Books";

            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                SqlCommand command = new SqlCommand(query, conn);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    int id = reader.GetInt32(0);
                    string namee = reader.GetString(1);
                    string value = reader.GetString(2);
                    int pricee = reader.GetInt32(3);

                    Console.WriteLine($"{id} = {namee} - {value} = {pricee}");
                }
            }

            // Inserting a list of books

            List<Books> list = new List<Books>()
            {
                new Books{Name = "Book2", Author = "Author 2", Price = 2000},
                new Books { Name = "Book3", Author = "Author3", Price = 150 },
                new Books { Name = "Book4", Author = "Author4", Price = 250 },
                new Books { Name = "Book5", Author = "Author5", Price = 300 },
                new Books { Name = "Book6", Author = "Author6", Price = 500 },
            };

            using (SqlConnection connect = new SqlConnection(connString))
            {
                connect.Open();
                foreach (Books item in list)
                {
                    string insertQ = $"INSERT INTO Books(name, author, price) VALUES(@name, @author, @price)";
                    SqlCommand command = new SqlCommand(insertQ, connect);
                    command.Parameters.AddWithValue("@name", item.Name);
                    command.Parameters.AddWithValue("@author", item.Author);
                    command.Parameters.AddWithValue("@price", item.Price);
                    command.ExecuteNonQuery();
                }

            }
        }
    }
    public class Books
    {
        public string Name { get; set; }
        public string Author { get; set; }
        public int Price { get; set; }
    }
}