using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Partial_Class
{
    public partial class Product
    {
        public string ProductName { get; set; }
        public string ProductID { get; set; }

        public void DisplayBasicInfo()
        {
            Console.WriteLine($"Product Name: {ProductName}, Product ID: {ProductID}");
        }
    }
}
