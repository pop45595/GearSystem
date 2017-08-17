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
        int iTime = 0;

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
                                    new StateUpdateInfo(iGrarId, (int)PropertyRule.e狀態名.生命, iTime),
                                    new StateUpdateInfo(iGrarId, (int)PropertyRule.e狀態名.魔法攻擊, iTime)
                                }
                            );
                            ++iTime;
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
        for(int i = 0;i< fAryValue.Length && i< iAry狀態名.Length; ++i) {
            Console.WriteLine(((PropertyRule.e狀態名)iAry狀態名[i]).ToString()+" : "+ fAryValue[i].ToString("F2"));
        }

        Console.WriteLine("");
    }
}

