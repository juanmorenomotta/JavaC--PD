package patrones.prototype.ej1;

/**
 * Esta clase es definida para contener objetos prototipo que representan cuentas UserAccount de tipo Supervisor y AccountRep
 *
 */
public class AccountPrototypeFactory {
	private UserAccount accountRep;
	private UserAccount supervisor;

	public AccountPrototypeFactory(UserAccount supervisorAccount,
			UserAccount arep) {
		accountRep = arep;
		supervisor = supervisorAccount;
	}

	public UserAccount getAccountRep() {
		return (UserAccount) accountRep.clone();
	}

	public UserAccount getSupervisor() {
		return (UserAccount) supervisor.clone();
	}
}
