package patrones.prototype.ej1;

import java.util.Vector;
public class ClienteMain {

	public static void main(String[] args) {
		/*
		 * Create Prototypical Objects.
		 * En primer lugar se crean dos objetos que representan los tipos de cuenta: Supervisor y
		 * AccountRep. Estas instancias se almacenan dentro de
		 * AccountPrototypeFactory,  como objetos de prototipo. Esta es la única vez que los
		 * permisos se leen de los archivos de datos.
		 * Cada vez que un nueva cuenta tipo Supervisor AccountRep necesitan ser creadas,
		 * el cliente invoca uno  de las métodos getSupervisor o getAccountRep de la clase AccountPrototypeFactory. 
		 * En respuesta, AccountPrototypeFactory clona un objeto prototipo adecuado de tipo UserAccount, 
		 * y lo devuelve al cliente. Una vez que el clon UserAccou es recibido, el cliente puede hacer los cambios necesarios, 
		 * tales como el establecimiento del nuevo nombre de usuario y contraseña
		 */
		Vector supervisorPermissions = getPermissionsFromFile("supervisor.txt");
		UserAccount supervisor = new UserAccount();
		supervisor.setPermissions(supervisorPermissions);

		Vector accountRepPermissions = getPermissionsFromFile("accountrep.txt");
		UserAccount accountRep = new UserAccount();
		accountRep.setPermissions(accountRepPermissions);

		AccountPrototypeFactory factory = new AccountPrototypeFactory(
				supervisor, accountRep);

		/* Using protype objects to create other user accounts */
		UserAccount newSupervisor = factory.getSupervisor();
		newSupervisor.setUserName("wpantoja");
		newSupervisor.setFName("Libardo Pantoja");
		newSupervisor.setLName("Pantoja Yepez");
		newSupervisor.setPassword("h4%84JDHFD");
		System.out.println(newSupervisor);

		UserAccount anotherSupervisor = factory.getSupervisor();
		anotherSupervisor.setUserName("juanmanuelpv");
		anotherSupervisor.setPassword("*/-dfd34");
		System.out.println(anotherSupervisor);

		UserAccount newAccountRep = factory.getAccountRep();
		newAccountRep.setUserName("juanito");
		newAccountRep.setPassword("fjd&5$$5");
		System.out.println(newAccountRep);

	}

	/**
	 * Por simplicidad no se leen los permisos del archivo, sino se establecen manualemente
	 * @param archivo archivo donde están los permisos
	 * @return Vector de permisos
	 */
	public static Vector getPermissionsFromFile(String archivo) {
		Vector permisos = new Vector();
		if (archivo.equals("supervisor.txt")) {
			permisos.add("RWX");
			permisos.add("RWX");
			permisos.add("RWX");
		} else {
			permisos.add("R-X");
			permisos.add("R-X");
			permisos.add("R--");
		}
		return permisos;
	}
}
