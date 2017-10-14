
namespace Iterator.Ejm1
{
    /// <summary>
    /// Define una interface para acceder y atravesar elementos
    /// </summary>
    public abstract class Iterator
    {
        public abstract object First();
        public abstract object Next();
        public abstract bool IsDone();
        public abstract object CurrentItem();
    }
}
