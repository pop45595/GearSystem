namespace GearSystem
{
    public interface ICreator<T>
    {
        T create(int _iId);
    }
}
