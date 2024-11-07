namespace E_Commerce_Cart_Management_System.Models
{
    public interface IDiscountStrategy
    {
        decimal ApplyDiscount(decimal totalAmount);
    }
}
