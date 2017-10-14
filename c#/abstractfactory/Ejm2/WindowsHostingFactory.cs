
namespace AbstractFactory.Ejm2
{
    public class WindowsHostingFactory : HostingFactory
    {
        public override Basic getBasic()
        {
            return new WindowsBasic("W-B");
        }

        public override Premium getPremium()
        {
            return new WindowsPremium("W-P");
        }

        public override PremiumPlus getPremiumPlus()
        {
            return new WindowsPremiumPlus("W-PP");
        }

    }
}
