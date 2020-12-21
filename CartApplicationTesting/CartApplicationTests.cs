using CartApplication;
using System;
using Xunit;

namespace CartApplicationTesting
{
    public class CartApplicationTests
    {
        [Fact]
        public void TestForAddingItemToCart()
        {
            Pen pen = new Pen();
            Shoes shoes = new Shoes();
            SmartBand smartBand = new SmartBand();
            SmartWatch smartWatch = new SmartWatch();

            Cart cart = new Cart();
            cart.AddItem(pen);
            cart.AddItem(pen);
            cart.AddItem(pen, 3);
            cart.RemoveItem(pen,4);
            Assert.Equal(1, cart.GetQuantity(pen));
        }
        [Fact]
        public void TestForCartPrice()
        {
            Pen pen = new Pen();

            Cart cart = new Cart();
            cart.AddItem(pen,3);
            cart.RemoveItem(pen, 2);
            Assert.Equal(20, cart.GetCartItemPrice(pen));
        }
        [Fact]
        public void TestForCheckoutPrice()
        {
            Pen pen = new Pen();
            Shoes shoes = new Shoes();

            Cart cart = new Cart();
            cart.AddItem(pen, 3); //20
            cart.AddItem(shoes,2); //100
            Assert.Equal(260, cart.GetCheckoutPrice());
        }
        [Fact]
        public void TestForCartDiscount()
        {
            Shoes shoes = new Shoes();
            CartDiscount cartDiscount = new CartDiscount(10);
            Assert.Equal(10, cartDiscount.GetDiscountAmount(100));
        }
        [Fact]
        public void TestForProductDiscount()
        {
            Pen pen = new Pen();
            Shoes shoes = new Shoes();
            ProductDiscount productDiscount = new ProductDiscount(shoes, 10);

            Cart cart = new Cart(productDiscount);
            cart.AddItem(pen, 3); //20
            cart.AddItem(shoes, 2); //100
            Assert.Equal(240, cart.GetCheckoutPrice());
        }
    }
}
