﻿using System;
using GearSystem;
using LOLGearSystem;
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

        Console.ReadKey(); // 暫停，沒寫則會很快關閉程式
    }
    private static void showInfo(IProperty _lolProperty) {
        int[] iAry狀態名 = new int[0];
        float[] fAryValue = new float[0];
        _lolProperty.getAllValue(ref iAry狀態名, ref fAryValue);
        for(int i = 0;i< fAryValue.Length && i< iAry狀態名.Length; ++i) {
            Console.WriteLine(((PropertyRule.e狀態名)iAry狀態名[i]).ToString()+" : "+ fAryValue[i].ToString("F2"));
        }
        Console.WriteLine("");
    }
}

