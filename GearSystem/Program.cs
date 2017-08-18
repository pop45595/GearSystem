using System;
using GearSystem;
using LOLGearSystem;
class Program
{
    static void Main(string[] args)
    {
        ICharactor<GearInfo, StateUpdateInfo> lolChractor = new LOLCharactor();
        IProperty lolProperty = lolChractor.getProperty();
        showInfo(lolProperty);
        lolChractor.setPropertyUpdateCallBack(delegate {
            lolProperty = lolChractor.getProperty();
            showInfo(lolProperty);
        });
        bool bAddPass = true;
        bool bDelPass = true;
        string strInput = null;
        string[] strAryInput = null;
        Console.WriteLine("說明 :");
        Console.WriteLine("加入物品 add [id] ( ex.add 0 )");
        Console.WriteLine("刪除物品 del [id] ( ex.del 0 )");
        Console.WriteLine("更新物品 update [id] ( ex.update 0 ) ###測試程式只能更新第一把時光之杖");
        Console.WriteLine("顯示狀態 show ( ex.show )");

        while (true) {
            strInput =  Console.ReadLine();
            strAryInput = strInput.Split(' ');

            if (strAryInput.Length >= 2) {
                int iGrarId = 0;
                if (int.TryParse(strAryInput[1], out iGrarId)) {
                    if (strAryInput[0].ToLower() == "add") {
                        bAddPass = lolChractor.addGear(new GearInfo(iGrarId));
                    } else if (strAryInput[0].ToLower() == "del") {
                        bDelPass = lolChractor.removeGear(new GearInfo(iGrarId));
                    } else if (strAryInput[0].ToLower() == "update") {
                        if (iGrarId == 0) { //時光之仗更新
                            lolChractor.updateState(
                                new StateUpdateInfo[] {
                                    new StateUpdateInfo(iGrarId, 5, 1),
                                    new StateUpdateInfo(iGrarId, 6, 1),
                                    new StateUpdateInfo(iGrarId, 7, 1)
                                }
                            );
                        }
                    } else {
                        Console.WriteLine("指令錯誤");
                    }
                }  else {
                    Console.WriteLine("指令錯誤");
                }
            } else if (strAryInput.Length > 0) {
                if (strAryInput[0].ToLower() == "show") {
                    showInfo(lolProperty);
                }
            } else {
                Console.WriteLine("指令錯誤");
            }
            if (!bAddPass) {
                Console.WriteLine("裝備物品失敗");
                bAddPass = true;
            }
            if (!bDelPass) {
                Console.WriteLine("卸除物品失敗");
                bDelPass = true;
            }
        }

    }
    private static void showInfo(IProperty _lolProperty) {
        int[] iAry狀態名 = new int[0];
        float[] fAryValue = new float[0];
        _lolProperty.getAllValue(ref iAry狀態名, ref fAryValue);
        if (iAry狀態名.Length > 0 || fAryValue.Length > 0) {
            for (int i = 0; i < fAryValue.Length && i < iAry狀態名.Length; ++i) {
                Console.WriteLine(((PropertyRule.e狀態名)iAry狀態名[i]).ToString() + " : " + fAryValue[i].ToString("F2"));
            }
            Console.WriteLine("");
        } else {
            Console.WriteLine("無狀態被改動");
        }
    }
}

