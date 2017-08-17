using System;
using GearSystem;
namespace LOLGearSystem
{
    class State : IState
    {
        private int m_iId = -1;
        private PropertyRule.e狀態名 m_eStateName = PropertyRule.e狀態名.生命;
        private float m_fValue = -1;
        private int m_iLevel = -1;

        public State(int _iId, PropertyRule.e狀態名 _eStateName, float _fValue, int _iLevel)
        {
            m_iId = _iId;
            m_eStateName = _eStateName;
            m_fValue = _fValue;
            m_iLevel = _iLevel;
        }

        public bool changeValue(ref IPropertyV2 _Property)
        {
            if (null == _Property)
            {
                return false;
            }
            else
            {
                float fOrginV = _Property.getValueToFloat((int)m_eStateName);
                _Property.setValue((int)m_eStateName, m_fValue + fOrginV);
            }
            return true;
        }

        public int getLevel()
        {
            return m_iLevel;
        }

        public int getID()
        {
            return m_iId;
        }

        public void updateState(int _iUpdateUnit) {
            
        }
    }
}
