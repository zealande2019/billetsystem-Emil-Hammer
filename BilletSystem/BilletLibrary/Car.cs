namespace BilletLibrary
{
    public class Car : Vehicle
    {
        public override decimal Price()
        {
            return 240;
        }

        public override string VehicleStatus()
        {
            return "Bil";
        }
    }
}
