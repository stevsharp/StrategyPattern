namespace StrategyPattern.Vehicle
{
    class FlyBehavior : VehicleBehavior
    {
        public override void AboutMe(string vehicle)
        {
            Console.WriteLine($"My {vehicle} can fly now.");
        }
    }
}
