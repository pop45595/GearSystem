
namespace GearSystem
{
    public interface IPropertyV2 : IProperty
    {
        bool 設攻擊();
        bool 設攻擊力加乘();
        bool 設防禦力();
        bool 設防禦力加乘();
        bool 設最大血量();
        bool 設血量加乘();
        bool 設最大魔量();
        bool 設魔量加乘();
        bool 設移動速度();
        bool 設生命回復();
        bool 設攻擊速度();
        bool 設爆擊率();
        bool 設爆擊傷害();
        bool 設格檔值();
        bool 設金幣拾取量();
        IPropertyV2 copy();
    }
}
