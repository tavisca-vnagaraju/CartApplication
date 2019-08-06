namespace CartApplication
{
    public abstract class Product
    {
        public abstract string Name { get; }
        public abstract double Price { get; }
        public double Discount { get; private set; }
        public abstract Category category { get; }
        public Product()
        {
            ProductDiscount productDiscount = new ProductDiscount();
            Discount = productDiscount.GetDiscount(category);
        }
    }
}
