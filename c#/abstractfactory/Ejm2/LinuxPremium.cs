using System;
namespace AbstractFactory.Ejm2
{
    public class LinuxPremium : Premium
    {
        private String Name;

        public LinuxPremium(string name)
        {
            this.Name = name;
        }

        public string GetPremiumName()
        {
            return Name;
        }
        public string GetPremiumFeatures()
        {
            return "Linux Premium Features";
        }
    }
}
