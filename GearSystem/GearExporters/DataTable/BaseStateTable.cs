﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GearSystem
{
    class BaseStateTable : IRule
    {
        // 欄位結構：
        // {0 狀態名, 1 狀態值, 2層級}
        // 暫時不做安全機制這樣
        public int[] searchById(int _iId)
        {
            return i2ArrTable[_iId];
        }

        private int[][] i2ArrTable =
        {
            new int[]{(int)e狀態名.攻擊,        100,   0},    //基礎攻擊
            new int[]{(int)e狀態名.攻擊力加乘,    5,   1},    //鋒利的
        };
    }
}