package patrones.iterator.ej1;

public class Client {

	public static void main(String[] args) {
        ConcreteAggregate a = new ConcreteAggregate();
        a.setItem(0,"Item A");
        a.setItem(1,"Item B");
        a.setItem(2,"Item C");
        a.setItem(3,"Item D");

        // Create Iterator and provide aggregate 
        ConcreteIterator i = new ConcreteIterator(a);

        System.out.println("Iterating over collection:");

        Object item = i.first();
        while (item != null)
        {
            System.out.println(item);
            item = i.next();
        }


	}

}
