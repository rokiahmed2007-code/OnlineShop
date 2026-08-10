using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop
{
    internal class Order
    {
        public int OrderID { get; set; }
        public Customer Customer { get; set; }
        public List<CartItem> Items { get; set; }
        public string Status { get; set; }

        public Order()
        {
            OrderID = 0;
            Customer = null;
            Items = new List<CartItem>();
            Status = "Pending";
        }
        public Order(int OrderID, Customer Customer, List<CartItem> Items, string Status) {

            this.OrderID = OrderID;
            this.Customer = Customer;
            this.Items = Items;
            this.Status = Status;
        }

        public decimal CalculateTotalOrder()
        {
            decimal Total = 0.0m;
            foreach(var item in Items)
            {
                Total += item.GetTotal();
            }
            return Total;
        }

        public void DisplayOrder()
        {
            Console.WriteLine($"Order ID : {OrderID}");
            Console.WriteLine($"Status :{Status}");

            foreach(var item in Items)
            {
                item.ViewCartItem();
            }
            Console.WriteLine($"Total Order Price :{CalculateTotalOrder()}");
        }

 
    }
}
