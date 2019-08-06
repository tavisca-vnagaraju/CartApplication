using System.Collections.Generic;

namespace CartApplication
{
    public class ProductDiscount
    {
        private Dictionary<Category, double> _productDiscount = new Dictionary<Category, double>();
        public ProductDiscount()
        {
            _productDiscount.Add(Category.Clothes, 0);
            _productDiscount.Add(Category.Dairy, 2);
            _productDiscount.Add(Category.Education, 0);
            _productDiscount.Add(Category.Electronics, 0);
        }
        public void SetDiscount(Category category,int number)
        {
            if (_productDiscount.ContainsKey(category))
            {
                _productDiscount[category] = number;
            }
        }
        public double GetDiscount(Category category)
        {
            if (_productDiscount.ContainsKey(category))
            {
                return _productDiscount[category] ;
            }
            return 0;
        }
    }
}
