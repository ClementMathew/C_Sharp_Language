using System;
using System.Data;
using System.Data.SqlClient;

namespace Disconnected_Architecture
{
    internal class Disconnected_Architecture
    {
        static void Main(string[] args)
        {
            string connStr = "Server=CLEMENTS-ASUS-V\\SQLEXPRESS;Database=Disconnected_Architecture;Trusted_Connection=True";

            DataTable dt = new DataTable();
            SqlConnection conn = new SqlConnection(connStr);

            // Query from Database

            string query = "SELECT * FROM Data";

            SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
            adapter.Fill(dt);

            foreach (DataRow row in dt.Rows)
            {
                Console.Write(row["Id"] + ". ");
                Console.WriteLine(row["Name"]);
            }

            // Update

            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(adapter);

            DataRow newRow = dt.NewRow();
            newRow["Id"] = 2;
            newRow["Name"] = "Mathew";

            dt.Rows.Add(newRow);
            adapter.Update(dt);

            Console.WriteLine("Task Completed.");
        }
    }
}
