using System;

namespace GearSystem
{
    class State : IState
    {
        private int m_iId = -1;
        private e狀態名 m_eStateName = e狀態名.攻擊;
        private float m_fValue = -1;
        private int m_iLevel = -1;

        public State(int _iId, e狀態名 _eStateName, float _iValue, int _iLevel)
        {
            m_iId = _iId;
            m_eStateName = _eStateName;
            m_fValue = _iValue;
            m_iLevel = _iLevel;
        }

        public bool changeValue(ref IPropertyV2 _Property)
        {
            float fOrginV = _Property.getValueToFloat(m_eStateName);
            _Property.setValue(m_eStateName, m_fValue + fOrginV);
            return true;
        }

        public int getLevel()
        {
            return m_iLevel;
        }

        public void setNextState(IState _state)
        {
            throw new NotImplementedException();
        }

        public void setUpdateCallBack(UpdateStateCallback _updateCallback)
        {
            throw new NotImplementedException();
        }
    }
}
