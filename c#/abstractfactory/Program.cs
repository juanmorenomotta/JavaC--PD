using System;
using AbstractFactory.Ejm1;
using AbstractFactory.Ejm2;
namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            string vhCategory = "Non-Luxury"; // o se puede colocar Luxury
            string vhType = "Suv"; // o se puede colocar Car
            string searchResult = "";

            // get one of Luxury or NonLuxury vehicle factories
            VehicleFactory vf = VehicleFactory.getVehicleFactory(vhCategory);
            if (vhType.Equals("Car"))
            {
                Car c = vf.getCar();
                searchResult = "Name: " + c.GetCarName() + " Features: "
                        + c.GetCarFeatures();
            }
            if (vhType.Equals("Suv"))
            {
                SUV s = vf.getSUV();
                searchResult = "Name: " + s.GetSUVName() + " Features: "
                        + s.GetSUVFeatures();
            }
            Console.WriteLine(searchResult);
            */


            string hosPlat = "Linux"; // o se puede colocar Linux
            string hostType = "Basic"; // o se puede colocar Premium o PremiumPLus
            string searchResult = "";

            // get one of Luxury or NonLuxury vehicle factories
            HostingFactory hf = HostingFactory.getHostingFactory(hosPlat);
            if (hostType.Equals("Basic"))
            {
                Basic b = hf.getBasic();

                searchResult = "Name: " + b.GetBasicName() + " Features: "
                        + b.GetBasicFeatures();
            }

            if (hostType.Equals("Premium"))
            {
                Premium p = hf.getPremium();

                searchResult = "Name: " + p.GetPremiumName() + " Features: "
                        + p.GetPremiumFeatures();
            }

            if (hostType.Equals("PremiumPlus"))
            {
                PremiumPlus pp = hf.getPremiumPlus();

                searchResult = "Name: " + pp.GetPremiumPlusName() + " Features: "
                        + pp.GetPremiumPlusFeatures();
            }

            Console.WriteLine(searchResult);
            Console.ReadKey();
        }
    }
}
