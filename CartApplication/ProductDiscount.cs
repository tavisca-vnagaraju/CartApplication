using System.Collections.Generic;

namespace CartApplication
{
    public class ProductDiscount: IDiscount
    {
        public Dictionary<Product, double> productDiscount = new Dictionary<Product, double>();
        public ProductDiscount(Product product,double discount)
        {
            productDiscount[product] = discount;
        }
        public double GetDiscountAmount(CartItem cartItem)
        {
            if (productDiscount.ContainsKey(cartItem.product))
            {
                var discountAmount = cartItem.GetCartItemTotalPrice() * (productDiscount[cartItem.product] / 100);
                return discountAmount;

            }
            return 0;
        }

        public double GetDiscountAmount(Cart cart)
        {
            var cartItem = cart.GetCartItemsList();
            return 0;
        }
    }
}
