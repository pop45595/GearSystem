using System.Collections;
using GearSystem;
namespace LOLGearSystem
{
    class GearFlyweight : ICreator<IGearV2>
    {
        private Hashtable m_baseGearhash = null;
        private BaseGearTable m_baseGeartable = null;
        private StateFlyweight m_stateFlyweight = null;
        public GearFlyweight(StateFlyweight _stateFlyweight) {
            m_baseGearhash = new Hashtable();
            m_baseGeartable = new BaseGearTable();
            m_stateFlyweight = _stateFlyweight;
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
                    gear.addState(m_stateFlyweight.create(i));
                }

                m_baseGearhash.Add(_iId, gear);
            }

            return (IGearV2)m_baseGearhash[_iId];
        }
    }
}
