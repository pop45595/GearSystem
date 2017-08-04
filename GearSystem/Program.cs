using System;
using GearSystem;

class Program
{
    static void Main(string[] args)
    {
        ICharactor<GearInfo> lolChractor = new LOLCharactor();
        IProperty lolProperty = lolChractor.getProperty();
        showInfo(lolProperty);
        lolChractor.setPropertyUpdateCallBack(delegate {
            lolProperty = lolChractor.getProperty();
            showInfo(lolProperty);
        });
        lolChractor.addGear(new GearInfo(0));
        lolChractor.addGear(new GearInfo(1));
        Console.ReadLine(); // 暫停，沒寫則會很快關閉程式
    }
    private static void showInfo(IProperty _lolProperty) {
        Console.WriteLine("攻擊力 : " + _lolProperty.getValueToFloat(e狀態名.攻擊));
        Console.WriteLine("攻擊力加乘 : " + _lolProperty.getValueToFloat(e狀態名.攻擊力加乘));
        Console.WriteLine("防禦力 : " + _lolProperty.getValueToFloat(e狀態名.防禦力));
        Console.WriteLine("防禦力加乘 : " + _lolProperty.getValueToFloat(e狀態名.防禦力加乘));
        Console.WriteLine("最大血量 : " + _lolProperty.getValueToFloat(e狀態名.最大血量));
        Console.WriteLine("血量加乘 : " + _lolProperty.getValueToFloat(e狀態名.血量加乘));
        Console.WriteLine("最大魔量 : " + _lolProperty.getValueToFloat(e狀態名.最大魔量));
        Console.WriteLine("魔量加乘 : " + _lolProperty.getValueToFloat(e狀態名.魔量加乘));
        Console.WriteLine("移動速度 : " + _lolProperty.getValueToFloat(e狀態名.移動速度));
        Console.WriteLine("生命回復 : " + _lolProperty.getValueToFloat(e狀態名.生命回復));
        Console.WriteLine("攻擊速度 : " + _lolProperty.getValueToFloat(e狀態名.攻擊速度));
        Console.WriteLine("爆擊率 : " + _lolProperty.getValueToFloat(e狀態名.暴擊率));
        Console.WriteLine("爆擊傷害 : " + _lolProperty.getValueToFloat(e狀態名.暴擊傷害));
        Console.WriteLine("格檔值 : " + _lolProperty.getValueToFloat(e狀態名.格擋值));
        Console.WriteLine("金幣拾取量 : " + _lolProperty.getValueToFloat(e狀態名.金幣時取量));
        Console.WriteLine("");
    }
}

