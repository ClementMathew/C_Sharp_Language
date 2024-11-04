using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using E_Commerce_Cart_Management_System.Models;

namespace E_Commerce_Cart_Management_System.Discount_Strategy
{
    public class PercentageDiscountStrategy : IDiscountStrategy
    {
        private readonly decimal _discountPercentage = 2;

        public decimal ApplyDiscount(decimal totalAmount) => totalAmount - (totalAmount * _discountPercentage / 100);
    }
}
