using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Text;
// using System.Threading.Tasks;

using GearSystem;

class Program
{
    static void Main(string[] args)
    {
        ICharactor lolChractor = new LOLCharactor();
        IProperty lolProperty = lolChractor.getProperty();
        lolChractor.setPropertyUpdateCallBack(delegate {
            Console.WriteLine("攻擊力 : " + lolProperty.取攻擊());
            Console.WriteLine("攻擊力加乘 : " + lolProperty.取攻擊力加乘());
            Console.WriteLine("防禦力 : " + lolProperty.取防禦力()); 
            Console.WriteLine("防禦力加乘 : " + lolProperty.取防禦力加乘());
            Console.WriteLine("最大血量 : " + lolProperty.取最大血量());
            Console.WriteLine("血量加乘 : " + lolProperty.取血量加乘());
            Console.WriteLine("最大魔量 : " + lolProperty.取最大魔量());
            Console.WriteLine("魔量加乘 : " + lolProperty.取魔量加乘());
            Console.WriteLine("移動速度 : " + lolProperty.取移動速度());
            Console.WriteLine("生命回復 : " + lolProperty.取生命回復());
            Console.WriteLine("攻擊速度 : " + lolProperty.取攻擊速度());
            Console.WriteLine("爆擊率 : " + lolProperty.取爆擊率());
            Console.WriteLine("爆擊傷害 : " + lolProperty.取爆擊傷害());
            Console.WriteLine("格檔值 : " + lolProperty.取格檔值());
            Console.WriteLine("金幣拾取量 : " + lolProperty.取金幣拾取量());
        });
        lolChractor.addGear(GearCreator.Create(1));

    }
}

