﻿namespace LOLGearSystem
{
    class GearTable : GearSystem.IRule
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
            new int[]{0,0,1,2},    //時光之杖
            new int[]{0,1,2,3,4}       //大天使之杖
        };
    }
}
