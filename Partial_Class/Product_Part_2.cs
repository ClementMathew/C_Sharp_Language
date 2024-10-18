using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Partial_Class
{
    public partial class Product
    {
        public decimal Price { get; set; }
        public int StockQuantity { get; set; }

        public void DisplayPricingInfo()
        {
            Console.WriteLine($"Price: {Price}, Stock Quantity: {StockQuantity}");
        }
    }
}
