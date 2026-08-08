using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop
{
    internal class Cart
    {
        public List<CartItem> Items { get; set; }
        public Cart()
        {
            Items = new List<CartItem>();
        }
        public void AddItem(Product product,int quantity)
        {
            CartItem item = new CartItem(product, quantity);

            Items.Add(item);
        }
        public void RemoveItem(int productId)
        {
            CartItem ItemToremove = null;

            foreach(CartItem item in Items)
            {
                if (item.Product.ID == productId)
                {
                    ItemToremove = item;
                    break;
                }
            }
            if (ItemToremove != null)
            {
                Items.Remove(ItemToremove);
            }
            else
            {
                Console.WriteLine("Product Not found In Cart.");
            }

        }
        public decimal CalculateTotal()
        {
            decimal total = 0.0m;
            foreach(CartItem item in Items)
            {
                total += item.GetTotal();
            }

            return total;

        }
    }
}
