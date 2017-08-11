using System.Collections;

namespace GearSystem
{
    class StateFlyweight : ICreator<IState>
    {
        private Hashtable m_baseStatehash = null;
        private BaseStateTable m_baseStatetable = null;
        public StateFlyweight()
        {
            m_baseStatehash = new Hashtable();
            m_baseStatetable = new BaseStateTable();
        }

        public IState create(int _iId)
        {
            if (!m_baseStatehash.ContainsKey(_iId))
            {
                int[] iArrStateStruct = m_baseStatetable.searchById(_iId);
                e狀態名 eStateName = (e狀態名)iArrStateStruct[0];
                float fValue = (float)iArrStateStruct[1];
                int iLevel = iArrStateStruct[2];

                IState state = new State(_iId, eStateName, fValue, iLevel);
                m_baseStatehash.Add(_iId, state);
            }

            return (IState)m_baseStatehash[_iId];
        }
    }
}
