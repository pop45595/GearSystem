namespace GearSystem
{
    public interface IState
    {
        bool changeValue(ref IPropertyV2 _Property);
        int getLevel();
    }
}
