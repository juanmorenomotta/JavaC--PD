using System;
namespace AbstractFactory.Ejm2
{
    public class LinuxPremiumPlus : PremiumPlus
    {
        private String Name;

        public LinuxPremiumPlus(string name)
        {
            this.Name = name;
        }

        public string GetPremiumPlusName()
        {
            return Name;
        }
        public string GetPremiumPlusFeatures()
        {
            return "Linux PremiumPlus Features";
        }
    }
}
