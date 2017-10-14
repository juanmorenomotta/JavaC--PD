
namespace AbstractFactory.Ejm1
{
    public class LuxurySUV : SUV
    {
        private string Name;

        public LuxurySUV(string sName)
        {
            Name = sName;
        }

        public string GetSUVName()
        {
            return Name;
        }

        public string GetSUVFeatures()
        {
            return "Luxury SUV Features ";
        }
    }

}
