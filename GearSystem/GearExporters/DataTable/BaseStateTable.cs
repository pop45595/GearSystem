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
            new int[]{(int)e狀態名.攻擊,        100,   0},    //基礎攻擊
            new int[]{(int)e狀態名.攻擊力加乘,    5,   1},    //鋒利的
        };
    }
}
