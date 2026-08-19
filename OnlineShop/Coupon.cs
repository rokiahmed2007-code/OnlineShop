using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop
{
    internal class Coupon
    {
        public enum DiscountType
        {
            Percentage,
            FixedAmount
        }
        public int CouponID { get; private set; }
        public string Code { get; set; }
        public decimal DiscountValue { get; private set; }
        public DiscountType Type { get; private set; }
        public bool isActive { get; private set; } = true;

        public Coupon(int CouponID, string Code, decimal DiscountValue, DiscountType Type)
        {
            this.CouponID = CouponID;
            this.Code = Code;
            this.DiscountValue = DiscountValue;
            this.Type = Type;
        }
        public decimal ApplayDiscount(decimal total)
        {
            if (!isActive)
            {
                return total;
            }

            if (Type == DiscountType.Percentage)
            {
                return total - (total * DiscountValue / 100);
            }

            return total - DiscountValue;
        }

        public void DeactiveCoupon()
        {
            isActive = false;
        }
        public void ActivateCoupon()
        {
            isActive = true;
        }
    }
}
