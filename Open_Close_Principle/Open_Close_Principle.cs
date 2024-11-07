using System;

namespace Open_Close_Principle
{
    // Interface for discount calculation

    public interface IDiscountCalculator
    {
        decimal CalculateDiscount(decimal amount);
    }

    // Discount for regular customers

    public class RegularCustomerDiscount : IDiscountCalculator
    {
        public decimal CalculateDiscount(decimal amount)
        {
            return amount * 0.1m; // 10% discount
        }
    }

    // Discount for premium customers

    public class PremiumCustomerDiscount : IDiscountCalculator
    {
        public decimal CalculateDiscount(decimal amount)
        {
            return amount * 0.2m; // 20% discount
        }
    }

    // Discount for gold customers (new functionality)

    public class GoldCustomerDiscount : IDiscountCalculator
    {
        public decimal CalculateDiscount(decimal amount)
        {
            return amount * 0.3m; // 30% discount
        }
    }

    // Context class for applying discount

    public class DiscountService
    {
        private readonly IDiscountCalculator _discountCalculator;

        public DiscountService(IDiscountCalculator discountCalculator)
        {
            _discountCalculator = discountCalculator;
        }

        public decimal ApplyDiscount(decimal amount)
        {
            return _discountCalculator.CalculateDiscount(amount);
        }
    }

    internal class Open_Close_Principle
    {
        static void Main(string[] args)
        {
            decimal amount = 1000m;

            // Applying regular discount

            DiscountService regularService = new DiscountService(new RegularCustomerDiscount());
            Console.WriteLine("Regular Customer Discounted Price: " + regularService.ApplyDiscount(amount));

            // Applying premium discount

            DiscountService premiumService = new DiscountService(new PremiumCustomerDiscount());
            Console.WriteLine("Premium Customer Discounted Price: " + premiumService.ApplyDiscount(amount));

            // Adding a new type without modifying existing code

            DiscountService goldService = new DiscountService(new GoldCustomerDiscount());
            Console.WriteLine("Gold Customer Discounted Price: " + goldService.ApplyDiscount(amount));
        }
    }
}

