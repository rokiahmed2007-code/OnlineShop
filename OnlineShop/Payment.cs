using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop
{
    internal class Payment
    {
        public enum PaymentMethod
        {
            Cash,
            CreditCard,
            PayPal
        }
        public enum PaymentStatus
        {
            Pending,
            Paid,
            Cancelled
        }
        private static int nextid = 0;
        public int PaymentId { get; private set; }
        public int Amount { get; set; }
        public PaymentMethod Method { get; set; }
        public PaymentStatus Status { get;private set; }

        public Payment(int Amount, PaymentMethod Method)
        {
            PaymentId = nextid++;
            this.Amount = Amount;
            this.Method = Method;
            Status = PaymentStatus.Pending;
        }
        public void ProcessPayment()
        {
            if (Status == PaymentStatus.Pending)
            {
                Status= Status = PaymentStatus.Paid;
            }
        }
        public void CancelPayment()
        {
            if (Status == PaymentStatus.Pending)
            {
                Status = PaymentStatus.Cancelled;
            }  
        }
        public void DisplayPaymentInfo()
        {
            Console.WriteLine($"Amount :{Amount}");
            Console.WriteLine($"Payment Method :{Method}");
            Console.WriteLine($"Payment Status :{Status}");
        }
    }
}
