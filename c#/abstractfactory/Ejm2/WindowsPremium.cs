using System;
namespace AbstractFactory.Ejm2
{
    public class WindowsPremium : Premium
    {
        private String Name;

        public WindowsPremium(string name)
        {
            this.Name = name;
        }

        public string GetPremiumName()
        {
            return Name;
        }
        public string GetPremiumFeatures()
        {
            return "Windows Premium Features";
        }
    }
}
