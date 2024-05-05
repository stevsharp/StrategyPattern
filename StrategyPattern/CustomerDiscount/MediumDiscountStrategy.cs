namespace StrategyPattern.CustomerDiscount
{
    public class MediumDiscountStrategy : IDiscountStrategy
    {
        public MediumDiscountStrategy(decimal totalSalesAmount)
        {
            TotalSalesAmount = totalSalesAmount;
        }

        public decimal TotalSalesAmount { get; }
        public void ApplyDiscount()
        {
            Console.WriteLine("Applying Medium Discount.");
        }
    }
}
