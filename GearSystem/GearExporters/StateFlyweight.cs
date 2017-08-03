using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GearSystem
{
    class StateFlyweight : ICreator<IState>
    {
        private static StateFlyweight m_stateFlyweight = null;
        private Hashtable m_baseStatehash = new Hashtable();
        private BaseStateTable m_baseStatetable = new BaseStateTable();
        private StateFlyweight() { }

        public static IState Create(int _iId)
        {
            if(null == m_stateFlyweight)
            {
                m_stateFlyweight = new StateFlyweight();
            }

            return m_stateFlyweight.create(_iId);
        }

        public IState create(int _iId)
        {
            if (!m_baseStatehash.ContainsKey(_iId))
            {
                int[] iArrStateStruct = m_baseStatetable.searchById(_iId);
                e狀態名 eStateName = (e狀態名)iArrStateStruct[0];
                float fValue = (float)iArrStateStruct[1];
                int iLevel = iArrStateStruct[2];

                IState state = new State(_iId,eStateName, fValue,iLevel);
                m_baseStatehash.Add(_iId, state);
            }

            return (IState)m_baseStatehash[_iId];
        }
    }
}
