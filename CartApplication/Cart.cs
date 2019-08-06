using System.Collections.Generic;

namespace CartApplication
{
    public class Cart
    {
        private List<CartItem> _cartItemsList = new List<CartItem>();
        private double _discount = 0;

        public void SetDiscount(double discount)
        {
            _discount = discount;
        }
        private CartItem GetCartItemByName(string name)
        {
            return _cartItemsList.Find(cartItem => cartItem.product.Name == name);
        }

        public void AddItem(CartItem item)
        {
            var cartItem = GetCartItemByName(item.product.Name);

            if (cartItem == null)
            {
                _cartItemsList.Add(item);
                item.CalculateCartItemTotalPrice();
            }
            else
            {
                cartItem.quantity += item.quantity;
                cartItem.CalculateCartItemTotalPrice();
            }
        }


        public bool RemoveItem(string name, int quantity = 1)
        {
            var cartItem = GetCartItemByName(name);

            if (cartItem == null)
            {
                return false;
            }
            else if (cartItem.quantity < quantity)
            {
                return false;    
            }
            else if(cartItem.quantity == quantity)
            {
                _cartItemsList.Remove(cartItem);
            }
            else
            {
                cartItem.quantity -= quantity;
                cartItem.CalculateCartItemTotalPrice();
            }
            return true;
        }


        public double GetTotalCartPrice()
        {
            double totalPrice = 0;
            foreach(var item in _cartItemsList)
            {
                totalPrice += item.totalPrice - item.totalPrice * item.product.Discount / 100;
            }
            totalPrice -= totalPrice * _discount / 100;
            return totalPrice;
        }


        public List<CartItem> GetCartItems()
        {
            return _cartItemsList;
        }

    }
}
