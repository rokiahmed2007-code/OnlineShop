using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop
{
    internal class Order
    {
        public enum OrderStatus
        {
            Pending,
            Confirmed,
            Shipped,
            Deliverd,
            Cancelled
        }
        private static int nextid = 0;
        public int OrderID { get;private set; }
        public Customer Customer { get; set; }
        public List<CartItem> Items { get; set; }
        public OrderStatus Status { get;private set; }

       
        public Order( Customer Customer, List<CartItem> Items) {

            OrderID = nextid;
            this.Customer = Customer;
            this.Items = Items;
            Status = OrderStatus.Pending;
        }

        public void ConfirmOrder()
        {
            if (Status == OrderStatus.Pending)
            {
                Status = OrderStatus.Confirmed;
            }
        }
        public void ShipOrder()
        {
            if (Status == OrderStatus.Confirmed)
            {
                Status = OrderStatus.Shipped;
            }
        }
        public void DeliverOrder()
        {
            if(Status== OrderStatus.Shipped)
            {
                Status = OrderStatus.Deliverd;
            }
        }
        public void Cancelorder()
        {
            if (Status == OrderStatus.Pending || Status == OrderStatus.Confirmed)
            {
                Status = OrderStatus.Cancelled;
            }
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
