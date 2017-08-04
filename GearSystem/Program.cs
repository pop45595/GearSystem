using System;


using GearSystem;

class Program
{
    static void Main(string[] args)
    {
        ICharactor<GearInfo> lolChractor = new LOLCharactor();
        IProperty lolProperty = lolChractor.getProperty();
        lolChractor.setPropertyUpdateCallBack(delegate {
            Console.WriteLine("攻擊力 : " + lolProperty.getValueToInt(e狀態名.攻擊));
            Console.WriteLine("攻擊力加乘 : " + lolProperty.getValueToInt(e狀態名.攻擊力加乘));
            Console.WriteLine("防禦力 : " + lolProperty.getValueToInt(e狀態名.防禦力)); 
            Console.WriteLine("防禦力加乘 : " + lolProperty.getValueToInt(e狀態名.防禦力加乘));
            Console.WriteLine("最大血量 : " + lolProperty.getValueToInt(e狀態名.最大血量));
            Console.WriteLine("血量加乘 : " + lolProperty.getValueToInt(e狀態名.血量加乘));
            Console.WriteLine("最大魔量 : " + lolProperty.getValueToInt(e狀態名.最大魔量));
            Console.WriteLine("魔量加乘 : " + lolProperty.getValueToInt(e狀態名.魔量加乘));
            Console.WriteLine("移動速度 : " + lolProperty.getValueToInt(e狀態名.移動速度));
            Console.WriteLine("生命回復 : " + lolProperty.getValueToInt(e狀態名.生命回復));
            Console.WriteLine("攻擊速度 : " + lolProperty.getValueToInt(e狀態名.攻擊速度));
            Console.WriteLine("爆擊率 : " + lolProperty.getValueToInt(e狀態名.暴擊率));
            Console.WriteLine("爆擊傷害 : " + lolProperty.getValueToInt(e狀態名.暴擊傷害));
            Console.WriteLine("格檔值 : " + lolProperty.getValueToInt(e狀態名.格擋值));
            Console.WriteLine("金幣拾取量 : " + lolProperty.getValueToInt(e狀態名.金幣時取量));
        });
        lolChractor.addGear(new GearInfo(1));
        Console.ReadLine(); // 暫停，沒寫則會很快關閉程式
    }
}

