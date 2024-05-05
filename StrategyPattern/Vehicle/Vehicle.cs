namespace StrategyPattern.Vehicle
{
    public class Vehicle : VehicleBehavior
    {
        VehicleBehavior behavior;
        string vehicleType;

        public Vehicle(string vehicleType)
        {
            this.vehicleType = vehicleType;
            //Setting the initial behavior
            behavior = new InitialBehavior();
        }

        public void SetVehicleBehavior(VehicleBehavior behavior)
        {
            this.behavior = behavior;
        }

        public void DisplayAboutMe()
        {
            behavior.AboutMe(vehicleType);
        }

        public override void AboutMe(string vehicle)
        {
            Console.WriteLine($"My {vehicle} is just born.It cannot do anything special.");
        }

    }
}
