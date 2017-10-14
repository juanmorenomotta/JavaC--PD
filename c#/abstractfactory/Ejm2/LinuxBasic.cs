using System;
namespace AbstractFactory.Ejm2
{
    public class LinuxBasic : Basic
    {
        private String Name;

        public LinuxBasic(string name)
        {
            this.Name = name;
        }

        public string GetBasicName()
        {
            return Name;
        }
        public string GetBasicFeatures()
        {
            return "Linux Basic Features";
        }
    }
}
