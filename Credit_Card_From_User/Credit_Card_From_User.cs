using System;

namespace Credit_Card_From_User
{
    internal class Credit_Card_From_User
    {
        static void Main(string[] args)
        {
            CreditCard card = new CreditCard();

            Console.WriteLine("Enter the credit card number : ");
            card.CardNumber = long.Parse(Console.ReadLine());

            Console.WriteLine("Enter the CVV number : ");
            card.CVV = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the expiry date (YYYY-MM-DD) : ");
            card.ExpiryDate = DateTime.Parse(Console.ReadLine());

            card.DisplayCardDetails();

            Console.WriteLine(card);
        }
    }
}
