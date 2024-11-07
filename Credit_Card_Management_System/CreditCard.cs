using System;

namespace Credit_Card_Management_System
{
    internal class CreditCard
    {
        public string Name;
        public long CardNumber;
        public int CVV;
        public DateTime ExpiryDate;

        public void DisplayCard()
        {
            Console.WriteLine($"\nThe credit card holder name is {Name}");
            Console.WriteLine($"The credit card number is {CardNumber}");
            Console.WriteLine($"The CV number is {CVV}");
            Console.WriteLine($"The expiry date is {ExpiryDate}");
        }
    }
}
