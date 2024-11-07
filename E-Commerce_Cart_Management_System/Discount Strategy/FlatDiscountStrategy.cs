using E_Commerce_Cart_Management_System.Models;

namespace E_Commerce_Cart_Management_System.Discount_Strategy
{
    public class FlatDiscountStrategy : IDiscountStrategy
    {
        public decimal ApplyDiscount(decimal totalAmount) => totalAmount - 200;
    }
}
