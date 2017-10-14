package patrones.iterator.ej1;

public class ConcreteIterator extends Iterator
{
    private ConcreteAggregate aggregate;
    private int current = 0;

    // Constructor 
    public ConcreteIterator(ConcreteAggregate aggregate)
    {
        this.aggregate = aggregate;
    }

    public Object first()
    {
        return aggregate.getItem(0);
    }

    public Object next()
    {
        Object ret = null;
        if (current < aggregate.count() - 1)
        {
            ret = aggregate.getItem(++current);
        }

        return ret;
    }

    public Object currentItem()
    {
        return aggregate.getItem(current);
    }

    public boolean isDone()
    {
        if (current >= aggregate.count())
        	return true;
        else
        	return false;
        			
    }
}
