namespace CartApplication
{
    public class SmartWatch : Product
    {
        public override string Name => "SmartWatch";
        public override double Price => 8000.0;

        public override Category category => Category.Electronics;
    }
}
