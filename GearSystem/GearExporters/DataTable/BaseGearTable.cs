namespace GearSystem
{
    class BaseGearTable : IRule
    {
        // 欄位結構：
        // {0 狀態, 1 狀態, 2狀態, 3狀態, .....}
        // 暫時不做安全機制這樣
        public int[] searchById(int _iId)
        {
            return i2ArrTable[_iId];
        }

        private int[][] i2ArrTable =
        {
            new int[]{0},       //小刀
        };
    }
}
