using System.Collections.Generic;
using System.Linq;

namespace E_Commerce_Cart_Management_System.Entities
{
    class CartManager
    {
        private readonly List<CartItem> _items = new List<CartItem>();

        public void Add(CartItem item)
        {
            CartItem existingItem = _items.FirstOrDefault(i => i.Name == item.Name);
            if (existingItem != null)
            {
                existingItem.Quantity += item.Quantity;
            }
            else
            {
                _items.Add(item);
            }
        }

        public void Remove(string productName)
        {
            _items.RemoveAll(i => i.Name == productName);
        }

        public List<CartItem> GetAll() => _items;
    }

}
