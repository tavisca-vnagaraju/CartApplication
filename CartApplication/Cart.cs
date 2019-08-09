using System;
using System.Collections.Generic;

namespace CartApplication
{
    public class Cart
    {
        private readonly List<CartItem> _cartItemsList = new List<CartItem>();
        private CartItem _cartItem;
        private double _totalCartPrice=0;
        private ProductDiscount _productDiscount;
        private CartDiscount _cartDiscount;
        private CategoryDiscount _categoryDiscount;
        private double _discountAmount = 0;
        public Cart()
        {

        }
        public Cart(ProductDiscount productDiscount)
        {
            _productDiscount = productDiscount;
        }
        public Cart(CartDiscount cartDiscount)
        {
            _cartDiscount = cartDiscount;
        }
        public Cart(CategoryDiscount categoryDiscount)
        {
            _categoryDiscount = categoryDiscount;
        }
        public void AddItem(Product product, int quantity=1)
        {
            //check product is in cartItems list if not add new cartItem or increase quantity
            var foundCartItem = _cartItemsList.Find( cartItem => cartItem.product == product);
            if(foundCartItem != null)
            {
                foundCartItem.quantity += quantity;
                foundCartItem.totalPrice = foundCartItem.quantity * product.Price;
            }
            else
            { 
                _cartItem = new CartItem(product, quantity);
                _cartItemsList.Add(_cartItem);
            }
        }
        public void RemoveItem(Product product, int quantity = 1)
        {   
            var foundCartItem = _cartItemsList.Find(cartItem => cartItem.product == product);
            if (foundCartItem != null)
            {
                if(foundCartItem.quantity > 0)
                {
                    foundCartItem.quantity -= quantity;
                    foundCartItem.totalPrice = foundCartItem.quantity * product.Price;
                }
                if(foundCartItem.quantity == 0)
                {
                    _cartItemsList.Remove(foundCartItem);
                }

            }
        }
        public double GetQuantity(Product product)
        {
            var foundCartItem = _cartItemsList.Find(cartItem => cartItem.product == product);
            if(foundCartItem != null)
            {
                return foundCartItem.quantity;
            }
            return 0;
        }
        public double GetCartItemPrice(Product product)
        {
            var foundCartItem = _cartItemsList.Find(cartItem => cartItem.product == product);
            if (foundCartItem != null)
            {
                return foundCartItem.totalPrice;
            }
            return 0;
        }
        public List<CartItem> GetCartItemsList()
        {
            return _cartItemsList;
        }
        
        public double GetCheckoutPrice()
        {
            if(_cartItemsList.Count > 0)
            {
                foreach (var cartItem in _cartItemsList)
                {  
                    _totalCartPrice += cartItem.totalPrice;
                }
                if (_productDiscount != null)
                {
                    foreach (var cartItem in _cartItemsList)
                    {
                        _discountAmount += _productDiscount.GetDiscountAmount(cartItem);
                    }
                }
                if(_categoryDiscount != null)
                {
                    foreach (var cartItem in _cartItemsList)
                    {
                        _discountAmount += _categoryDiscount.GetDiscountAmount(cartItem);
                    }
                }
                if(_cartDiscount != null)
                {
                    _discountAmount += _cartDiscount.GetDiscountAmount(_totalCartPrice);
                }
            }
            return _totalCartPrice - _discountAmount;
        }
        
    }
}
