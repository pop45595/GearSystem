using System;
using System.Collections.Generic;

namespace GearSystem
{
    public class StateMgr : IStateMgr
    {
        private IPropertyV2 m_Property = null;
        private IGear[] m_ArrGear = null;
        private List<IState> m_ListState = null;
        private IState m_FirstState = null;
        private reflashCallback m_updateCallback = null;

        public StateMgr(IPropertyV2 _Property , int _iCount)
        {
            m_ArrGear = new IGear[_iCount];
            m_ListState = new List<IState>();
            m_Property = _Property;
        }

        public bool addGear(IGear _IGear , int _iIndex)
        {   //Add
            setStateArray(_IGear.getAllState());
            m_ArrGear[_iIndex] =_IGear;
            setAllStateNext();
            updateProprety();
            return true;
        }
        public bool removeGear(int _iIndex)
        {   //remove
            bool bAnswer = false;

            if (m_ArrGear.Length > _iIndex && _iIndex >= 0)
            {
                m_ArrGear[_iIndex] = null ;
                bAnswer = true;

                resetStateArray();
            }
            updateProprety();
            return bAnswer;
        }

        public void updateProprety()
        {   //update
            m_FirstState.changeValue(ref m_Property);
            if(null!= m_updateCallback)
            {
                m_updateCallback();
            }
        }

        public void setReflashCallback(reflashCallback _updateCallback)
        {
            m_updateCallback = _updateCallback;
        }

        //------------------------------------------------------------------------------------
        private void setStateArray(IState[] _ArrState)
        {   //State add ListState
            if (null != _ArrState)
            {
                for (int i = 0; i < _ArrState.Length; ++i)
                {
                    _ArrState[i].setUpdateCallBack(updateProprety);
                    m_ListState.Add(_ArrState[i]);
                }
            }
        }

        private void resetStateArray()
        {   //reset
            m_ListState.Clear();

            for (int i = 0; i< m_ArrGear.Length; ++i)
            {
                setStateArray(m_ArrGear[i].getAllState());
            }
            setAllStateNext();
        }

        private void setAllStateNext()
        {   //set state next and get first state
            for (int i = 0; i < m_ListState.Count-1; ++i)
            {
                m_ListState[i].setNextState(m_ListState[i+1]);
            }
            m_FirstState = m_ListState[0];
        }

        public IProperty getProperty()
        {
            throw new NotImplementedException();
        }
    }
}
