using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GearSystem
{
    class GearFlyweight : ICreator<IGearV2>
    {
        private static GearFlyweight m_gearFlyweight = null;
        private Hashtable m_baseGearhash = new Hashtable();
        private BaseGearTable m_baseGeartable = new BaseGearTable();
        private GearFlyweight() { }

        public static IGearV2 Create(int _iId)
        {
            if(null == m_gearFlyweight)
            {
                m_gearFlyweight = new GearFlyweight();
            }

            return m_gearFlyweight.create(_iId);
        }

        public IGearV2 create(int _iId)
        {

            if (!m_baseGearhash.ContainsKey(_iId))
            {
                IGearV2 gear = new Gear(_iId);

                // 基礎武器表中取得對應狀態，並生成武器填入狀態
                int[] iArrStates = m_baseGeartable.searchById(_iId);
                int iStatesLenght = iArrStates.Length;
                for(int i = 0; i < iStatesLenght; ++i)
                {
                    gear.addState(StateFlyweight.Create(i));
                }

                m_baseGearhash.Add(_iId, gear);
            }

            return (IGearV2)m_baseGearhash[_iId];
        }
    }
}
