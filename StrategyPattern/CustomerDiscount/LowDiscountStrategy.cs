namespace StrategyPattern.CustomerDiscount
{
    public class LowDiscountStrategy : IDiscountStrategy
    {
        public LowDiscountStrategy(decimal totalSalesAmount)
        {
            TotalSalesAmount = totalSalesAmount;
        }

        public decimal TotalSalesAmount { get; }

        public void ApplyDiscount()
        {
            Console.WriteLine("Applying High Discount.");
        }
    }
}
