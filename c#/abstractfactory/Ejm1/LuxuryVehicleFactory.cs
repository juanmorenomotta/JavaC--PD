
namespace AbstractFactory.Ejm1
{
    public class LuxuryVehicleFactory : VehicleFactory
    {
        public override Car getCar()
        {
            return new LuxuryCar("L-C");
        }

        public override SUV getSUV()
        {
            return new LuxurySUV("L-S");
        }
    }
}
