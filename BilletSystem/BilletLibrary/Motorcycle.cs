namespace BilletLibrary
{
    public class Motorcycle : Vehicle
    {
        public override decimal Price()
        {
            return 125;
        }

        public override string VehicleStatus()
        {
            return "MC";
        }
    }
}