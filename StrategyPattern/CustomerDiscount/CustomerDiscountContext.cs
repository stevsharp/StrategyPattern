namespace StrategyPattern.CustomerDiscount
{
    public class CustomerDiscountContext
    {
        private IDiscountStrategy discountStrategy;

        public CustomerDiscountContext(Func<int, IDiscountStrategy> strategyFunc, int totalSalesAmount)
        {
            discountStrategy = strategyFunc(totalSalesAmount);
        }

        public void ProcessDiscount()
        {
            discountStrategy.ApplyDiscount();
        }
    }

}
