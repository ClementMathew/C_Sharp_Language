using System.Collections.Generic;
using System.Linq;
using E_Commerce_Cart_Management_System.Entities;
using E_Commerce_Cart_Management_System.Models;

namespace E_Commerce_Cart_Management_System
{
    public class BillingService
    {
        private readonly IDiscountStrategy _discountStrategy;

        public BillingService(IDiscountStrategy discountStrategy)
        {
            _discountStrategy = discountStrategy;
        }

        public decimal CalculateTotalAmount(List<CartItem> cartItems)
        {
            decimal totalAmount = cartItems.Sum(i => i.TotalPrice);
            return _discountStrategy.ApplyDiscount(totalAmount);
        }
    }

}
