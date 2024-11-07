using System;
using System.Collections.Generic;
using E_Commerce_Cart_Management_System.Discount_Strategy;
using E_Commerce_Cart_Management_System.Entities;

namespace E_Commerce_Cart_Management_System
{
    internal class Program
    {
        // class DiscountStrategy
        // {
        //     public decimal ApplyDiscount(decimal totalPrice, string strategy)
        //     {
        //         if (strategy == "percentage")
        //         {
        //             return totalPrice - (totalPrice * 2 / 100);
        //         }
        //         else if(strategy == "flat")
        //         {
        //             return totalPrice - 200;
        //         }
        //     }
        // }

        static void Main(string[] args)
        {
            CartManager cartManager = new CartManager();
            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("\n--- E-Commerce Cart Management System ---");

                Console.WriteLine("\n1. Add Item to Cart");
                Console.WriteLine("2. Remove Item from Cart");
                Console.WriteLine("3. View All Items in Cart");
                Console.WriteLine("4. Exit");

                Console.Write("\nChoose an option: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.Write("Enter product name: ");
                        string name = Console.ReadLine();

                        Console.Write("Enter quantity: ");
                        int quantity = int.Parse(Console.ReadLine());

                        cartManager.Add(new CartItem { Name = name, Quantity = quantity });
                        Console.WriteLine("Item added successfully!");

                        break;

                    case "2":
                        Console.Write("Enter the product name to remove: ");
                        string productName = Console.ReadLine();

                        cartManager.Remove(productName);
                        Console.WriteLine("Item removed successfully!");

                        break;

                    case "3":
                        Console.WriteLine("Items in Cart:");
                        List<CartItem> items = cartManager.GetAll();

                        if (items.Count > 0)
                        {
                            foreach (CartItem item in items)
                            {
                                Console.WriteLine($"{item.Name} - Quantity: {item.Quantity}");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Cart is empty.");
                        }
                        break;

                    case "4":
                        exit = true;
                        Console.WriteLine("Exiting program...");
                        break;

                    default:
                        Console.WriteLine("Invalid option. Please choose a valid option.");
                        break;
                }
            }

            CartManager cart = new CartManager();

            cart.Add(new CartItem { Name = "Item 1", Price = 100, Quantity = 2 });
            cart.Add(new CartItem { Name = "Item 2", Price = 200, Quantity = 3 });
            cart.Add(new CartItem { Name = "Item 3", Price = 300, Quantity = 4 });

            PercentageDiscountStrategy discountStrategy = new PercentageDiscountStrategy();
            BillingService billingService = new BillingService(discountStrategy);
            decimal totalAmount = billingService.CalculateTotalAmount(cart.GetAll());
            Console.WriteLine($"Total amount: {totalAmount}");
        }
    }
}
