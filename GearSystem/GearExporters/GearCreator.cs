using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GearSystem
{
    class GearCreator : ICreator<IGear>
    {
        private static GearCreator m_gearCreator = null;
        private GearTable m_gearTable = new GearTable();
       

        private GearCreator() { }

        public static IGear Create(int _iId)
        {
            if (null == m_gearCreator)
            {              
                m_gearCreator = new GearCreator();
            }

            return m_gearCreator.create(_iId);
        }

        public IGear create(int _iId)
        {
            IGearV2 gear = new Gear(_iId);
           
            // 從武器表拿出數據
            int[] iArrStructs = m_gearTable.searchById(_iId);
            int iStatesLenght = iArrStructs.Length;

            // 第0位 是基礎武器代號，之後都是各式狀態代號
            gear.setGear(GearFlyweight.Create(iArrStructs[0]));
            for (int i = 1; i < iStatesLenght; ++i)
            {
                gear.addState(StateFlyweight.Create(iArrStructs[i]));
            }

            return gear;
        }
    }
}
