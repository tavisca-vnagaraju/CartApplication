namespace CartApplication
{
    public class CartItem
    {
        public Product product;
        public int quantity;
        public double totalPrice;

        public CartItem(Product product, int quantity = 1)
        {
            this.product = product;
            this.quantity = quantity;
            this.totalPrice = quantity * product.Price;
        }

        public double GetCartItemTotalPrice()
        {
            return this.totalPrice;
        }
    }
}
