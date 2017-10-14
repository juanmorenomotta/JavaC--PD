using System;
namespace AbstractFactory.Ejm1
{
    public class LuxuryCar : Car
    {
        private string Name;

        public LuxuryCar(String cName)
        {
            Name = cName;
        }

        public string GetCarName()
        {
            return Name;
        }

        public string GetCarFeatures()
        {
            return "Luxury Car Features ";
        }
    }
}
