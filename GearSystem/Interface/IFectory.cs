namespace GearSystem
{
    public interface IFectory<T>
    {
        T create(int _iID);
    }
}
