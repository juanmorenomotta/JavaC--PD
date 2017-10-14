
namespace Prototype.Ejm1
{
    /// <summary>
    /// Esta clase es definida para contener objetos prototipo que representan cuentas UserAccount 
    /// de tipo Supervisor y AccountRep
    /// </summary>
    public class AccountPrototypeFactory
    {
        private UserAccount AccountRep;
        private UserAccount Supervisor;

        public AccountPrototypeFactory(UserAccount supervisorAccount,
                UserAccount arep)
        {
            AccountRep = arep;
            Supervisor = supervisorAccount;
        }

        public UserAccount GetAccountRep()
        {
            return (UserAccount)AccountRep.Clone();
        }

        public UserAccount GetSupervisor()
        {
            return (UserAccount)Supervisor.Clone();
        }
    }
}
