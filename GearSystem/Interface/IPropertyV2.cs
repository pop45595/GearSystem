namespace GearSystem
{
    public interface IPropertyV2 : IProperty
    {
        void setValue(int _iKey, int _iValue);
        void setValue(int _iKey, float _fValue);
        IPropertyV2 copy();
    }
}
