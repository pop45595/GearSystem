using GearSystem;
namespace LOLGearSystem
{
    class BaseStateTable : IRule
    {
        // 欄位結構：
        // {0 狀態名, 1 狀態值, 2層級}
        public int[] searchById(int _iId)
        {
            if(_iId >= i2ArrTable.Length)
            {
                return null;
            }
            return i2ArrTable[_iId];
        }

        private int[][] i2ArrTable =
        {          
            new int[]{(int)PropertyRule.e狀態名.生命,        300,   0},        //300生命
            new int[]{(int)PropertyRule.e狀態名.魔力,        300,   0},        //300魔力
            new int[]{(int)PropertyRule.e狀態名.魔法攻擊,     60,   0},        //60魔法攻擊
        };
    }
}
