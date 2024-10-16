using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store_Inventory_Management_System
{
    internal class Store_Inventory_Management_System
    {
        static Dictionary<int, Dictionary<string, string>> Products = new Dictionary<int, Dictionary<string, string>>();

        static int product_id = 0;

        static void AddProduct()
        {
            Console.WriteLine("Enter the name : ");
            string product_name = Console.ReadLine();

            Console.WriteLine("Enter the price : ");
            string price = Console.ReadLine();

            Console.WriteLine("Enter the stock : ");
            string stock = Console.ReadLine();

            Dictionary<string, string> Temp = new Dictionary<string, string>();

            Temp.Add("name", product_name);
            Temp.Add("price", price);
            Temp.Add("stock", stock);

            Products.Add(product_id, Temp);
            product_id++;
        }

        static void UpdateStock()
        {
            Console.WriteLine("Enter the product id : ");
            int id = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the new stock count : ");
            int newStock = int.Parse(Console.ReadLine());

            foreach (var Product in Products)
            {
                if (Product.Key == id)
                {
                    int stockInt = int.Parse(Product.Value["stock"]);
                    int newStockVal = stockInt + newStock;
                    Product.Value["stock"] = newStockVal.ToString();
                }
            }
        }

        static void GetProductDetails()
        {
            Console.WriteLine("Enter the product id : ");
            int id = int.Parse(Console.ReadLine());

            Console.WriteLine("\n------- Products -------\n");

            foreach (var Product in Products)
            {
                if (Product.Key == id)
                {
                    Console.WriteLine($"Name : {Product.Value["name"]}");
                    Console.WriteLine($"Price : {Product.Value["price"]}");
                    Console.WriteLine($"Stock : {Product.Value["stock"]}");
                }
            }
        }

        static void GetLowStockProducts()
        {
            Console.WriteLine("Enter the threshold : ");
            int threshold = int.Parse(Console.ReadLine());

            Console.WriteLine("\n------- Products -------\n");

            foreach (var Product in Products)
            {
                int stockInt = int.Parse(Product.Value["stock"]);

                if (stockInt < threshold)
                {
                    Console.WriteLine($"Name : {Product.Value["name"]}");
                    Console.WriteLine($"Price : {Product.Value["price"]}");
                    Console.WriteLine($"Stock : {Product.Value["stock"]}");
                }

            }
        }

        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("\n1. AddProduct \n2. UpdateStock \n3. GetProductDetails \n4. GetLowStockProducts \n\nEnter the value : ");
                int n = int.Parse(Console.ReadLine());

                Console.WriteLine();

                switch (n)
                {
                    case 1:
                        AddProduct();
                        break;
                    case 2:
                        UpdateStock();
                        break;
                    case 3:
                        GetProductDetails();
                        break;
                    case 4:
                        GetLowStockProducts();
                        break;

                    default:
                        Console.WriteLine("No match");
                        break;
                }
            }
        }
    }
}
