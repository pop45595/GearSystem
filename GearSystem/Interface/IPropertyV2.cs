
namespace GearSystem
{
    public interface IPropertyV2 : IProperty
    {
        int getValueToInt(e狀態名 _eKey );
        float getValueToFloat(e狀態名 _eKey);
        IPropertyV2 copy();
    }
}
