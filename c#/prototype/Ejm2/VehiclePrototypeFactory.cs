
namespace Prototype.Ejm2
{
    /// <summary>
    /// Esta clase es definida para contener objetos prototipo que representan vehiculos
    /// </summary>
    public class VehiclePrototypeFactory
    {
        private Vehicle LuxurySUV;
        private Vehicle NonLuxurySUV;
        private Vehicle LuxuryCar;
        private Vehicle NonLuxuryCar;

        public VehiclePrototypeFactory(Vehicle luxurySUV,
                Vehicle nonLuxurySUV, Vehicle luxuryCar, Vehicle nonLuxuryCar)
        {
            LuxurySUV = luxurySUV;
            NonLuxurySUV = nonLuxurySUV;
            LuxuryCar = luxuryCar;
            NonLuxuryCar = nonLuxuryCar;
        }

        public Vehicle GetLuxurySUV()
        {
            return (Vehicle)LuxurySUV.Clone();
        }

        public Vehicle GetNonLuxurySUV()
        {
            return (Vehicle)NonLuxurySUV.Clone();
        }

        public Vehicle GetLuxuryCar()
        {
            return (Vehicle)LuxuryCar.Clone();
        }

        public Vehicle GetNonLuxuryCar()
        {
            return (Vehicle)NonLuxuryCar.Clone();
        }
    }
}
