namespace CartApplication
{
    public class SmartBand : Product
    {
        public override string Name => "SmartBand";
        public override double Price => 1700.0;

        public override Category category => Category.Electronics;
        
    }
}
