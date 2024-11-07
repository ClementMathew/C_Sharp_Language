using System;

namespace Credit_Card_From_User
{
    internal class CreditCard
    {
        public string Name;
        public long CardNumber;
        public int CVV;
        public DateTime ExpiryDate;

        public void DisplayCardDetails()
        {
            Console.WriteLine($"\nThe credit card number is {CardNumber}");
            Console.WriteLine($"The CVV number is {CVV}");
            Console.WriteLine($"The expiry date is {ExpiryDate}");
        }

        public override string ToString()
        {
            return $"\nThe credit card {CardNumber} with CVV number {CVV} will expire in {ExpiryDate}";
        }
    }

}
