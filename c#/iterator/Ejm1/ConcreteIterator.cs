
namespace Iterator.Ejm1
{
    /// <summary>
    /// Implementa la interface Iterator.
    /// Mantiene un registro de la posición actual en el recorrido del agregado (todo)
    /// </summary>
    class ConcreteIterator : Iterator
    {
        private ConcreteAggregate aggregate;
        private int current = 0;

        // Constructor 
        public ConcreteIterator(ConcreteAggregate aggregate)
        {
            this.aggregate = aggregate;
        }

        public override object First()
        {
            return aggregate[0];
        }

        public override object Next()
        {
            object ret = null;
            if (current < aggregate.Count - 1)
            {
                ret = aggregate[++current];
            }

            return ret;
        }

        public override object CurrentItem()
        {
            return aggregate[current];
        }

        public override bool IsDone()
        {
            return current >= aggregate.Count ? true : false;
        }
    }
}
