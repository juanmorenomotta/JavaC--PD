package patrones.prototype.clonadosuperficial;

public class ClienteMain {

	public static void main(String[] args) {
		/**
		 * En la clonación superficial, un cambio sobre el 
		 * objeto asociado con un clon afecta al objeto 
		 * original, porque los objetos relacionados son los 
		 * mismos (es decir, la clonación replica sólo el 
		 * propio objeto y su estado, no sus asociaciones 
		 * con terceros objetos); 
		 * mientras que en la clonación profunda se clonan 
		 * los objetos y también sus objetos relacionados.
		 */
		// Original Object
		Person p = new Person("Person-A", "Civic");
		System.out.println("Original (orginal values): " + p.getName() + " - "
				+ p.getCar().getName());
		// Clone as a shallow copy
		Person q = (Person) p.clone();
		System.out.println("Clone (before change): " + q.getName() + " - "
				+ q.getCar().getName());
		// change the primitive member
		q.setName("Person-B");
		// change the lower-level object
		q.getCar().setName("Accord");
		System.out.println("Clone (after change): " + q.getName() + " - "
				+ q.getCar().getName());
		System.out.println("Original (after clone is modified): " + p.getName()
				+ " - " + p.getCar().getName());

	}
}
