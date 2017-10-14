package patrones.factorymethod.ej1;

/**
 * 	// using the factory method pattern
 *
 */
public class ClienteMain {


	public static void main(String args[]) {

		// creating the factory
		PetFactory petFactory = new PetFactory();

		// factory instantiates an object
		Pet pet = petFactory.getPet("guau");

		// you don't know which object factory created
		System.out.println(pet.speak());
		
		Pet pet2 = petFactory.getPet("quack");
		System.out.println(pet2.speak());

		
	}

}
