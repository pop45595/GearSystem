﻿using System;
using System.Collections.Generic;
using GearSystem;
namespace LOLGearSystem
{
    class Gear : IGearV2
    {
        private int m_iGearID = 0;
        private IGear m_baseGear = null;
        private List<IState> m_listState = null;
        private IPropertyV2 m_property = null;

        public Gear(int _iGearID)
        {
            m_iGearID = _iGearID;
            m_listState = new List<IState>();
        }

        public IState[] getAllState()
        {
            return m_listState.ToArray();
        }

        public int getGearID()
        {
            return m_iGearID;
        }

        public bool setGear(IGear _gear)
        {
            if(null == m_baseGear)
            {
                m_baseGear = _gear;
                IState[] arrState = m_baseGear.getAllState();
                foreach(IState state in arrState)
                {
                    addState(state);
                }
                return true;
            }else
            {
                return false;
            }
        }

        public bool addState(IState _state)
        {
            if(null != _state)
            {
                m_listState.Add(_state);
                _state.changeValue(ref m_property);
                return true;
            }else
            {
                return false;
            }           
        }

        public void updateState(int _iInfoID)
        {
            throw new NotImplementedException();
        }

        public bool setIPropertyV2(IPropertyV2 _PropertyV2)
        {
            m_property = _PropertyV2;
            return true;
        }
    }
}
