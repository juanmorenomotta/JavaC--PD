using System;
namespace AbstractFactory.Ejm2
{
    public class WindowsPremiumPlus : PremiumPlus
    {
        private String Name;

        public WindowsPremiumPlus(string name)
        {
            this.Name = name;
        }

        public string GetPremiumPlusName()
        {
            return Name;
        }
        public string GetPremiumPlusFeatures()
        {
            return "Windows PremiumPlus Features";
        }
    }
}
