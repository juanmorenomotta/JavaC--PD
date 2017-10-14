
namespace Iterator.Ejm2
{
    /// <summary>
    /// Define una interface para acceder y atravesar elementos
    /// </summary>
    public abstract class Iterator
    {
        public abstract object Next();
        public abstract bool HasNext();

    }
}
