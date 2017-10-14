using System;
namespace AbstractFactory.Ejm2
{
    public class WindowsBasic : Basic
    {
        private String Name;

        public WindowsBasic(string name)
        {
            this.Name = name;
        }

        public string GetBasicName()
        {
            return Name;
        }
        public string GetBasicFeatures()
        {
            return "Windows Basic Features";
        }
    }
}
