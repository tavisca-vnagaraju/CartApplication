namespace CartApplication
{
    public class CartItem
    {
        public Product product;
        public int quantity;
        private double _totalPrice;

        public CartItem(Product product, int quantity = 1)
        {
            this.product = product;
            this.quantity = quantity;
            _totalPrice = quantity * product.Price;
        }

        public double GetCartItemTotalPrice()
        {
            return _totalPrice;
        }
    }
}
