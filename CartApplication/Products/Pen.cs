namespace CartApplication
{
    public class Pen : Product
    {
        public override string Name => "Pen";
        public override double Price => 20;
        public override Category category => Category.Stationary;
    }
}
