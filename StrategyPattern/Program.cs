
using StrategyPattern.CustomerDiscount;
using StrategyPattern.Vehicle;

try
{
    int totalSalesAmount = 6000;

    Func<int, IDiscountStrategy> discountStrategy = (totalSalesAmount) =>
    {
        if (totalSalesAmount >= 5000)
        {
            return new HighDiscountStrategy(totalSalesAmount);
        }
        else if (totalSalesAmount >= 3000)
        {
            return new MediumDiscountStrategy(totalSalesAmount);
        }
        else if (totalSalesAmount >= 1000)
        {
            return new LowDiscountStrategy(totalSalesAmount);
        }
        else
        {
            return new NoDiscountStrategy();
        }
    };


    var customerDiscountContext = new CustomerDiscountContext(discountStrategy, totalSalesAmount);

    // Process discount
    customerDiscountContext.ProcessDiscount();

    Console.WriteLine("***Strategy Pattern Demo.***\n");

    Vehicle context = new Vehicle("Aeroplane");
    context.DisplayAboutMe();
    
    Console.WriteLine("Setting flying capability to vehicle.");
    context.SetVehicleBehavior(new FlyBehavior());
    context.DisplayAboutMe();
    
    Console.WriteLine("Changing the vehicle behavior again.");
    context.SetVehicleBehavior(new FloatBehavior());
    context.DisplayAboutMe();
    

}
catch (Exception ex)
{
    Console.WriteLine(ex.ToString());
}

Console.ReadLine();