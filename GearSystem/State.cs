using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GearSystem
{
    class State : IState
    {
        private eGearState m_eGearState = eGearState.攻擊力;
        private int m_iValue = 0;

        public State(eGearState _eGearState, int _iValue)
        {
            m_eGearState = _eGearState;
            m_iValue = _iValue;
        }

        public bool changeValue(ref IPropertyV2 _Property)
        {
            if (null != _Property)
            {
                int iValue = _Property.getPropertyValue<int>(m_eGearState);
                _Property.setPropertyValue<int>(m_eGearState, m_iValue + iValue);
                return true;
            }
            else
            {
                return false;
            }
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
