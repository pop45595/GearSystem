using System;

namespace GearSystem
{
    class GearCreator : ICreator<IGear>
    {
        private GearTable m_gearTable = null;
        private GearFlyweight m_gearFlyweight = null;
        private StateFlyweight m_stateFlyweight = null;
       
        public GearCreator() {
            m_gearTable = new GearTable();          
            m_stateFlyweight = new StateFlyweight();
            m_gearFlyweight = new GearFlyweight(m_stateFlyweight);
        }

        public IGear create(int _iId)
        {
            IGearV2 gear = new Gear(_iId);

            // 從武器表拿出數據
            int[] iArrStructs = m_gearTable.searchById(_iId);
            int iStatesLenght = iArrStructs.Length;

            // 第0位 是基礎武器代號，之後都是各式狀態代號
            gear.setGear(m_gearFlyweight.create(iArrStructs[0]));
            for (int i = 1; i < iStatesLenght; ++i)
            {
                gear.addState(m_stateFlyweight.create(iArrStructs[i]));
            }

            return gear;
        }
    }
}
