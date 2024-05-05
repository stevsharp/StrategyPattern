namespace StrategyPattern.CustomerDiscount
{
    // Define concrete discount strategies
    public class NoDiscountStrategy : IDiscountStrategy
    {
        public void ApplyDiscount()
        {
            Console.WriteLine("No discount applied.");
        }
    }
}
