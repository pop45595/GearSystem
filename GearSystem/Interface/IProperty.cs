
namespace GearSystem
{
    public interface IProperty
    {
        int 取攻擊(int _iValue);
        int 取攻擊力加乘(int _iValue);
        int 取防禦力(int _iValue);
        int 取防禦力加乘(int _iValue);
        int 取最大血量(int _iValue);
        int 取血量加乘(int _iValue);
        int 取最大魔量(int _iValue);
        int 取魔量加乘(int _iValue);
        int 取移動速度(int _iValue);
        int 取生命回復(int _iValue);
        int 取攻擊速度(int _iValue);
        int 取爆擊率(int _iValue);
        int 取爆擊傷害(int _iValue);
        int 取格檔值(int _iValue);
        int 取金幣拾取量(int _iValue);
    }
}
