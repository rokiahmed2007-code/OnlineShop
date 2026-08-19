using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop
{
    internal class Customer
    {
        public int PhoneNumber { get; set; }
        public int ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public Cart Cart { get; set; }
        public Order Order { get; set; }

        public Customer(int PhoneNumber, int ID, string Name, string Email, string Address, Cart Cart,Order Order)
        {
            this.PhoneNumber = PhoneNumber;
            this.ID = ID;
            this.Name = Name;
            this.Email = Email;
            this.Address = Address;
            this.Cart = Cart;
            this.Order = Order;

        }
        public void AddToCart(Product product, int quantity)
        {
            Cart.AddItem(product, quantity);
        }
        public void RemoveFromCart(int productID)
        {
            Cart.RemoveItem(productID);
        }

        public void ViewCart()
        {
            foreach (var item in Cart.Items)
            {
                item.ViewCartItem();
            }
        }
        
        public void ViewOrder()
        {
            Order.DisplayOrder();
        }
    }
}
