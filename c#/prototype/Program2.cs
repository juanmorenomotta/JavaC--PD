using System;
using System.Collections;
using Prototype.Ejm2;
namespace Prototype
{
    class Program2
    {

        static void Main(string[] args)
        {
            
            Vehicle luxuryCar = new Vehicle();
            Vehicle nonLuxuryCar = new Vehicle();
            Vehicle luxurySUV = new Vehicle();
            Vehicle nonLuxurySUV = new Vehicle();

            VehiclePrototypeFactory factory = new VehiclePrototypeFactory(luxurySUV,
                nonLuxurySUV, luxuryCar, nonLuxuryCar);


            /* Using protype objects to create others vehicles*/
            Vehicle newluxuryCar = factory.GetLuxuryCar();
            newluxuryCar.Name = "L-C";
            newluxuryCar.Features = "Luxury Car Features";
            Console.WriteLine(newluxuryCar);

            Vehicle newNonLuxuryCar = factory.GetNonLuxuryCar();
            newNonLuxuryCar.Name = "Non L-C";
            newNonLuxuryCar.Features = "Non Luxury Car Features";
            Console.WriteLine(newNonLuxuryCar);
  

            Vehicle newLuxurySUV = factory.GetLuxurySUV();
            newLuxurySUV.Name = "L-S";
            newLuxurySUV.Features = "Luxury SUV Features";
            Console.WriteLine(newLuxurySUV);

            Vehicle newNonLuxurySUV = factory.GetNonLuxurySUV();
            newNonLuxurySUV.Name = "NonL-S";
            newNonLuxurySUV.Features = "Non Luxury SUV Features";
            Console.WriteLine(newNonLuxurySUV);

            Console.ReadKey();
        }
    }
}
