using System.Collections;
namespace Iterator.Ejm1
{
    /// <summary>
    /// Implementa la interfaz de creación de Iterator para devolver una instancia ConcreteIterator apropiada
    /// </summary>
    class ConcreteAggregate : Aggregate
    {
        private ArrayList items = new ArrayList();

        public override Iterator CreateIterator()
        {
            return new ConcreteIterator(this);
        }

        // Property 
        public int Count
        {
            get { return items.Count; }
        }

        // Indexer 
        public object this[int index]
        {
            get { return items[index]; }
            set { items.Insert(index, value); }
        }
    }
}
