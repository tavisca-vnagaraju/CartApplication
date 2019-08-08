using System.Collections.Generic;

namespace CartApplication
{
    public class ProductDiscount
    {
        private Dictionary<Product, double> _productDiscount = new Dictionary<Product, double>();
        public ProductDiscount(Product product,double discount)
        {
            _productDiscount[product] = discount;
        }
        public double GetDiscountAmount(Product product)
        {
            if (_productDiscount.ContainsKey(product))
            {
                var discountAmount = product.Price * (_productDiscount[product] / 100);
                return discountAmount;
            }
            return 0;
        }
    }
}
