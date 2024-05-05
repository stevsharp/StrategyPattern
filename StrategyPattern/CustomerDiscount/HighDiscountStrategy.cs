namespace StrategyPattern.CustomerDiscount
{
    public class HighDiscountStrategy : IDiscountStrategy
    {

        
        public HighDiscountStrategy(decimal totalSalesAmount)
        {
            TotalSalesAmount = totalSalesAmount;
        }

        public decimal TotalSalesAmount { get; }

        public void ApplyDiscount()
        {
            Console.WriteLine($"Applying High Discount. {TotalSalesAmount}");
        }
    }
}
