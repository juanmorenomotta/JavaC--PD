
namespace AbstractFactory.Ejm2
{
    public class LinuxHostingFactory : HostingFactory
    {
        public override Basic getBasic()
        {
            return new LinuxBasic("L-B");
        }

        public override Premium getPremium()
        {
            return new LinuxPremium("L-P");
        }

        public override PremiumPlus getPremiumPlus()
        {
            return new LinuxPremiumPlus("L-PP");
        }

    }
}
