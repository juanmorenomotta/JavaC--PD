
namespace AbstractFactory.Ejm1
{
    public class NonLuxuryVehicleFactory : VehicleFactory
    {
        public override Car getCar()
        {
            return new NonLuxuryCar("NL-C");
        }

        public override SUV getSUV()
        {
            return new NonLuxurySUV("NL-S");
        }
    }
}
