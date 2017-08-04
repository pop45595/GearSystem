
namespace GearSystem
{
    public interface IPropertyV2 : IProperty
    {
        void setValue(e狀態名 _eKey, int _iValue);
        void setValue(e狀態名 _eKey, float _fValue);
        IPropertyV2 copy();
    }
}
