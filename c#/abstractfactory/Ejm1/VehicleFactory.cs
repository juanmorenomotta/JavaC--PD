
namespace AbstractFactory.Ejm1
{
    public abstract class VehicleFactory
    {
        public const string LuxuryVehicle = "Luxury";
        public const string NonLuxuryVehicle = "Non-Luxury";

        public abstract Car getCar();

        public abstract SUV getSUV();

        public static VehicleFactory getVehicleFactory(string type)
        {
            if (type.Equals(VehicleFactory.LuxuryVehicle))
                return new LuxuryVehicleFactory();
            if (type.Equals(VehicleFactory.NonLuxuryVehicle))
                return new NonLuxuryVehicleFactory();
            return new LuxuryVehicleFactory();
        }
    }
}
