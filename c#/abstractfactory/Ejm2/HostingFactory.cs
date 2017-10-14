
namespace AbstractFactory.Ejm2
{
    public abstract class HostingFactory
    {
        public const string WindowsHosting = "Windows";
        public const string LinuxHosting = "Linux";

        public abstract Basic getBasic();

        public abstract Premium getPremium();

        public abstract PremiumPlus getPremiumPlus();

        public static HostingFactory getHostingFactory(string type)
        {
            if (type.Equals(HostingFactory.WindowsHosting))
                return new WindowsHostingFactory();
            if (type.Equals(HostingFactory.LinuxHosting))
                return new LinuxHostingFactory();
            return new WindowsHostingFactory();
        }
    }
}
