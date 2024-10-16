using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Credit_Card_From_User
{
    internal class CreditCard
    {
        public string Name;
        public long CardNumber;
        public int CVC;
        public DateTime ExpiryDate;

        public void DisplayCardDetails()
        {
            Console.WriteLine($"\nThe credit card number is {CardNumber}");
            Console.WriteLine($"The CV number is {CVC}");
            Console.WriteLine($"The expiry date is {ExpiryDate}");
        }

        public override string ToString()
        {
            return $"\nThe credit card {CardNumber} with CV number {CVC} will expire in {ExpiryDate}";
        }
    }

}
