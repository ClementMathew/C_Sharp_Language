using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Credit_Card_Management_System
{
    internal class CreditCardManager
    {
        private List<CreditCard> creditCards = new List<CreditCard>();

        public void AddCard(string name, long cardNumber, int cvv, string expiryDate)
        {
            CreditCard card = new CreditCard();

            card.Name = name;
            card.CardNumber = cardNumber;
            card.CVV = cvv;
            card.ExpiryDate = DateTime.Parse(expiryDate);

            creditCards.Add(card);
            Console.WriteLine("\nCard added successfully.");
        }

        public void UpdateCard(long cardNumber, string newHolderName)
        {
            foreach (var card in creditCards)
            {
                if (card.CardNumber == cardNumber)
                {
                    card.Name = newHolderName;

                    Console.WriteLine("\nCard updated successfully.");
                    return;
                }
            }
            Console.WriteLine("\nCard not found.");
        }

        public void DeleteCard(long cardNumber)
        {
            for (int i = 0; i < creditCards.Count; i++)
            {
                if (creditCards[i].CardNumber == cardNumber)
                {
                    creditCards.RemoveAt(i);
                    Console.WriteLine("\nCard deleted successfully.");
                    return;
                }
            }
            Console.WriteLine("\nCard not found.");
        }

        public void SearchCard(long cardNumber)
        {
            foreach (var card in creditCards)
            {
                if (card.CardNumber == cardNumber)
                {
                    card.DisplayCard();
                    return;
                }
            }
            Console.WriteLine("\nCard not found.");
        }
    }
}
