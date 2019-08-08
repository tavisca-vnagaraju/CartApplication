using System;

namespace CartApplication
{
    public class CartDiscount
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
    }
}
