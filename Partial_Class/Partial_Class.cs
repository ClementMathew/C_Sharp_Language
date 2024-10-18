using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Partial_Class
{
    internal class Partial_Class
    {
        static void Main(string[] args)
        {
            Product product = new Product();

            product.ProductName = "Laptop";
            product.ProductID = "P001";
            product.Price = 1200.99m;
            product.StockQuantity = 30;

            product.DisplayBasicInfo();
            product.DisplayPricingInfo();
        }
    }
}
