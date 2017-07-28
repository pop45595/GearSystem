
namespace GearSystem
{
    public interface IPropertyV2 : IProperty
    {
        bool 設攻擊(int _iValue);
        bool 設攻擊力加乘(int _iValue);
        bool 設防禦力(int _iValue);
        bool 設防禦力加乘(int _iValue);
        bool 設最大血量(int _iValue);
        bool 設血量加乘(int _iValue);
        bool 設最大魔量(int _iValue);
        bool 設魔量加乘(int _iValue);
        bool 設移動速度(int _iValue);
        bool 設生命回復(int _iValue);
        bool 設攻擊速度(int _iValue);
        bool 設爆擊率(int _iValue);
        bool 設爆擊傷害(int _iValue);
        bool 設格檔值(int _iValue);
        bool 設金幣拾取量(int _iValue);
        void reset();
        IPropertyV2 copy();
    }
}
