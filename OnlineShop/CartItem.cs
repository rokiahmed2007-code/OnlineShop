using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop
{
    internal class CartItem
    {
        public Product Product { get; set; }
        public int Quantity { get; set; }

        public CartItem()
        {
            Quantity = 0;
        }
        public CartItem(Product Product,int Quantity)
        {
            this.Product = Product;
            this.Quantity = Quantity;
        }

        public decimal GetTotal()
        {
            return Product.Price * Quantity;
        }
        public void ViewCartItem()
        {
            
            Console.WriteLine($" Product :{Product.Name}\nPrice :{Product.Price}\nQuantity :{Quantity}\n Total Price :{GetTotal()}");
        }

    }
}
