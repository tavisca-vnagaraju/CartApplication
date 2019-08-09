using System;

namespace CartApplication
{
    public class CartDiscount: IDiscount
    {
        private double _discount;
        public CartDiscount(double discount)
        {
            _discount = discount;
        }
        public double GetDiscountAmount(double amount)
        {
            return amount * (_discount / 100);
        }

        public double GetDiscountAmount(Cart cart)
        {
            throw new System.NotImplementedException();
        }
    }
}
