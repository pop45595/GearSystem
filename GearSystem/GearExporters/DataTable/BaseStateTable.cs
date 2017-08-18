using GearSystem;
namespace LOLGearSystem
{
    class BaseStateTable : IRule
    {
        // 欄位結構：
        // {0 狀態名, 1 層級, 2 基礎狀態值, 3 浮動狀態值}
        public int[] searchById(int _iId)
        {
            if (_iId >= i2ArrTable.Length)
            {
                return null;
            }
            return i2ArrTable[_iId];
        }

        private int[][] i2ArrTable =
        {
            new int[]{(int)PropertyRule.e狀態名.生命,        0,   300,    0},        //靜態300生命
            new int[]{(int)PropertyRule.e狀態名.魔力,        0,   300,    0},        //靜態300魔力
            new int[]{(int)PropertyRule.e狀態名.魔法攻擊,    0,    60,    0},        //靜態60魔法攻擊
            new int[]{(int)PropertyRule.e狀態名.魔法攻擊,    0,    20,    0},        //靜態20魔法攻擊
            new int[]{(int)PropertyRule.e狀態名.魔力,        0,   -50,    0},        //靜態-50魔力

            new int[]{(int)PropertyRule.e狀態名.生命,        0,     0,   20},        //動態20生命
            new int[]{(int)PropertyRule.e狀態名.魔力,        0,     0,   10},        //動態10魔力
            new int[]{(int)PropertyRule.e狀態名.魔法攻擊,    0,     0,    4},        //動態4魔法攻擊
        };
    }
}
