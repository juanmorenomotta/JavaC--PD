
namespace AbstractFactory.Ejm1
{
    public class NonLuxurySUV : SUV
    {
        private string Name;

        public NonLuxurySUV(string sName)
        {
            Name = sName;
        }

        public string GetSUVName()
        {
            return Name;
        }

        public string GetSUVFeatures()
        {
            return "Non-Luxury SUV Features ";
        }
    }
}
