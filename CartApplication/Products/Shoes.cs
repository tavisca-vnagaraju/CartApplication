namespace CartApplication
{
    public class Shoes : Product
    {
        public override string Name => "Shoes";
        public override double Price => 100;

        public override Category category => Category.Clothes;

    }
}
