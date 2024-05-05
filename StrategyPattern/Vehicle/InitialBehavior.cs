namespace StrategyPattern.Vehicle
{
    class InitialBehavior : VehicleBehavior
    {
        public override void AboutMe(string vehicle)
        {
            Console.WriteLine($"My {vehicle} is just born.It cannot do anything special.");
        }
    }
}
