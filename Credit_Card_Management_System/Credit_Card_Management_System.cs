using System;

namespace Credit_Card_Management_System
{
    internal class Credit_Card_Management_System
    {
        static CreditCardManager cardManager = new CreditCardManager();

        static void Main(string[] args)
        {
            bool running = true;

            while (running)
            {
                Console.WriteLine("\n1. Add Card");
                Console.WriteLine("2. Search Card");
                Console.WriteLine("3. Update Card");
                Console.WriteLine("4. Delete Card");
                Console.WriteLine("5. Exit");

                Console.WriteLine("\nEnter value : ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        GetCardData();
                        break;

                    case "2":
                        SearchCardData();
                        break;

                    case "3":
                        UpdateCardData();
                        break;

                    case "4":
                        DeleteCardData();
                        break;

                    case "5":
                        running = false;
                        Console.WriteLine("Exiting...");
                        break;

                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }
            }
        }

        private static void DeleteCardData()
        {
            Console.WriteLine("Enter the card number : ");
            long num = long.Parse(Console.ReadLine());

            cardManager.DeleteCard(num);
        }

        private static void UpdateCardData()
        {
            Console.WriteLine("Enter card number : ");
            long num = long.Parse(Console.ReadLine());

            Console.WriteLine("Enter card holder name : ");
            string name = Console.ReadLine();

            cardManager.UpdateCard(num, name);
        }

        private static void SearchCardData()
        {
            Console.WriteLine("Enter card number : ");
            long num = long.Parse(Console.ReadLine());

            cardManager.SearchCard(num);
        }

        private static void GetCardData()
        {
            Console.WriteLine("\nEnter card holder name : ");
            string name = Console.ReadLine();

            Console.WriteLine("Enter card number : ");
            long num = long.Parse(Console.ReadLine());

            Console.WriteLine("Enter the CVV number : ");
            int cvv = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the expiry date : ");
            string expiryDate = Console.ReadLine();

            cardManager.AddCard(name, num, cvv, expiryDate);
        }
    }
}
