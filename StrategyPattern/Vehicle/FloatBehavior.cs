namespace StrategyPattern.Vehicle
{
    class FloatBehavior : VehicleBehavior
    {
        public override void AboutMe(string vehicle)
        {
            Console.WriteLine($"My {vehicle} can float now.");
        }
    }
}
