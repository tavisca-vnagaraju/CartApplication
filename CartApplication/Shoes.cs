namespace CartApplication
{
    public class Shoes : Product
    {
        public override string Name => "Shoes";
        public override double Price => 200;

        public override Category category => Category.Clothes;

    }
}
