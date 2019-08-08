using System.Collections.Generic;

namespace CartApplication
{
    public class CategoryDiscount
    {
        private Dictionary<Category, double> _categoryDiscount = new Dictionary<Category, double>();
        public CategoryDiscount(Category category, double discount)
        {
            _categoryDiscount[category] = discount;
        }
        public double GetDiscountAmount(Product product)
        {
            if (_categoryDiscount.ContainsKey(product.category))
            {
                var discountAmount = product.Price * (_categoryDiscount[product.category] / 100);
                return discountAmount;
            }
            return 0;
        }
    }
}
