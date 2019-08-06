namespace CartApplication
{
    public abstract class Product
    {
        public abstract string Name { get; set; }
        public abstract double Price { get; set; }

        public abstract double Discount { get; set; }
    }
}
