using System;

namespace CartApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Pen pen = new Pen();
            Shoes shoes = new Shoes();

            Cart cart = new Cart();
            cart.AddItem(pen, 3); //20
            cart.AddItem(shoes, 2); //100
            Console.WriteLine(cart.GetCheckoutPrice());
            Console.ReadKey(true);
        }
    }
}
