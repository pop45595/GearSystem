namespace GearSystem
{
    class GearTable : IRule
    {
        // 欄位結構：
        // {0 基礎武器代號, 1 狀態, 2狀態, 3狀態, .....}
        public int[] searchById(int _iId)
        {
            if(_iId >= i2ArrTable.Length)
            {
                return null;
            }
            return i2ArrTable[_iId];
        }

        // 之後會做成Excel，應該會比較好懂
        private int[][] i2ArrTable =
        {
            new int[]{0,  },             //基礎小刀
            new int[]{0, 1},             //鋒利的小刀
        };
    }
}
