package patrones.prototype.clonadoprofundo;

public class ClienteMain {
	public static void main(String[] args) {

		/**
		 * Cuando el objeto Car asociados con el objeto clonado
		 * es modificado, se puede observar que el objeto Car
		 * asociado con el objeto original no es afectado.
		 * Esto es debido a que el objeto Car de nivel inferior
		 * se duplica y no es compartido por los objetos
		 * persona tanto original, como clonados.
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
