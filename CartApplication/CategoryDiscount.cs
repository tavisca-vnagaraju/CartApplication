using System.Collections.Generic;

namespace CartApplication
{
    public class CategoryDiscount: IDiscount
    {
        private Dictionary<Category, double> _categoryDiscount = new Dictionary<Category, double>();
        public CategoryDiscount(Category category, double discount)
        {
            _categoryDiscount[category] = discount;
        }
        public double GetDiscountAmount(CartItem cartItem)
        {
            if (_categoryDiscount.ContainsKey(cartItem.product.category))
            {
                var discountAmount = cartItem.GetCartItemTotalPrice() * (_categoryDiscount[cartItem.product.category] / 100);
                return discountAmount;
            }
            return 0;
        }

        public double GetDiscountAmount(Cart cart)
        {
            throw new System.NotImplementedException();
        }
    }
}
