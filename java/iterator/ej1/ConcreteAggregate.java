package patrones.iterator.ej1;

import java.util.ArrayList;

class ConcreteAggregate extends Aggregate
{
    private ArrayList<Object> items = new ArrayList<Object>();

    public Iterator createIterator()
    {
        return new ConcreteIterator(this);
    }

    public int count()
    {
        return items.size(); 
    }

    public Object getItem(int index)
    {
        return items.get(index);
    }
    public void setItem(int index, Object value){
    	items.add(index,value);
    	
    	
    }
}

