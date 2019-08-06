using CartApplication;
using System;
using Xunit;

namespace CartApplicationTesting
{
    public class CartFixature
    {
        [Fact]
        public void CheckForProduct()
        {
            SmartBand smartBand = new SmartBand();
            SmartWatch smartWatch = new SmartWatch();
            Assert.Equal("SmartBand", smartBand.Name);
        }
        [Fact]
        public void TestForTotalCartItemPrice()
        {
            SmartBand smartBand = new SmartBand();
            SmartWatch smartWatch = new SmartWatch();
            CartItem cartItemBand = new CartItem(smartBand, 4);
            cartItemBand.CalculateCartItemTotalPrice();
            Assert.Equal(6800, cartItemBand.totalPrice);
        }
        [Fact]
        public void TestForTotalCartPrice()
        {
            SmartBand smartBand = new SmartBand();
            SmartWatch smartWatch = new SmartWatch();
            Cart cart = new Cart();
            CartItem cartItemBand = new CartItem(smartBand,2);
            cart.AddItem(cartItemBand);
            CartItem cartItemWatch = new CartItem(smartWatch, 2);
            cart.AddItem(cartItemWatch);
            Assert.Equal(19400, cart.GetTotalCartPrice());
        }
        [Fact]
        public void TestForTotalCartPriceWithDiscount()
        {
            SmartBand smartBand = new SmartBand();
            SmartWatch smartWatch = new SmartWatch();
            Cart cart = new Cart();
            CartItem cartItemBand = new CartItem(smartBand, 2);
            cart.AddItem(cartItemBand);
            CartItem cartItemWatch = new CartItem(smartWatch, 2);
            cart.AddItem(cartItemWatch);
            cart.SetDiscount(10);
            Assert.Equal(17460, cart.GetTotalCartPrice());
        }
    }
}
