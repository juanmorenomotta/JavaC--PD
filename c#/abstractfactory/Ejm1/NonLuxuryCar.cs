using System;
namespace AbstractFactory.Ejm1
{
    public class NonLuxuryCar : Car
    {
        private string Name;

        public NonLuxuryCar(string cName)
        {
            Name = cName;
        }

        public String GetCarName()
        {
            return Name;
        }

        public String GetCarFeatures()
        {
            return "Non-Luxury Car Features ";
        }
    }
}
