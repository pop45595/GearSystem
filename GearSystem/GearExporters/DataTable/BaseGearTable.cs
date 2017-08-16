namespace LOLGearSystem
{
    class BaseGearTable : GearSystem.IRule
    {
        // 欄位結構：
        // {0 狀態, 1 狀態, 2狀態, 3狀態, .....}
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
            new int[]{0},       //小刀
        };
    }
}
