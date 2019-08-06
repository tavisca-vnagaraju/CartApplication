using CartApplication;
using System;
using Xunit;

namespace CartApplicationTesting
{
    public class CartApplicationTests
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
            Assert.Equal(6800, cartItemBand.GetCartItemTotalPrice());
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
        [Fact]
        public void TestForAddToCartAndRemoveCart()
        {
            Pen pen = new Pen();
            Shoes shoes = new Shoes();
            Cart cart = new Cart();
            CartItem penItems = new CartItem(pen, 5);//50
            cart.AddItem(penItems);
            CartItem shoesItems = new CartItem(shoes, 2);//400
            cart.AddItem(shoesItems);
            cart.RemoveItem(shoesItems);//200
            Assert.Equal(250, cart.GetTotalCartPrice());
        }
        [Fact]
        public void TestForEnumCategory()
        {
            SmartWatch smartWatch = new SmartWatch();
            var category = smartWatch.category;
            Assert.Equal(Category.Electronics, category);
        }
        [Fact]
        public void TestForDiscountClass()
        {
            ProductDiscount productDiscount = new ProductDiscount();
            Assert.Equal(2,productDiscount.GetDiscount(Category.Dairy));
        }
    }
}
