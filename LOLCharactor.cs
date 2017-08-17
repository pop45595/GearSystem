﻿using System;
using System.Collections.Generic;
using GearSystem;

public class LOLCharactor : ICharactor<GearInfo, StateUpdateInfo>
{
    private IStateMgr m_stateMgr = null;
    private List<int> m_iListGearIDRecord = null;
    private int m_iMaxGear = 6;
    public LOLCharactor() {
        m_iListGearIDRecord = new List<int>();
        m_stateMgr = new StateMgr(m_iMaxGear);
    }
    public IProperty getProperty()
    {
        return m_stateMgr.getProperty();
    }

    public bool addGear(GearInfo _addGearInfo) {
        IGear gear = SuperMarket.instance.m_gearCreator.create(_addGearInfo.m_GearId);
        if (m_stateMgr.addGear(gear, m_iListGearIDRecord.Count)) {
            int iGearId = _addGearInfo.m_GearId;
            m_iListGearIDRecord.Add(iGearId);
            return true;
        } else {
            return false;
        }
    }

    public bool removeGear(GearInfo _delGearInfo) {
        int? iGearPosition = getGearPosition(_delGearInfo.m_GearId);
        if (iGearPosition.HasValue) {
            if (m_stateMgr.removeGear(iGearPosition.Value)) {
                m_iListGearIDRecord.RemoveAt(iGearPosition.Value);
                return true;
            }
        }
        return false;
    }
    private int? getGearPosition(int _delGearID) {
        int iTargetID = _delGearID;
        for (int i = 0; i < m_iListGearIDRecord.Count; ++i) {
            if (m_iListGearIDRecord[i] == iTargetID) {
                return i;
            }
        }
        return null;
    }
    public void setPropertyUpdateCallBack(reflashCallback _callBack)
    {
        m_stateMgr.setReflashCallback(_callBack);
    }

    public void updateState(StateUpdateInfo[] _stateUpdateInfo) {
        if (_stateUpdateInfo != null) {
            for (int i = 0; i < _stateUpdateInfo.Length; ++i) {
                if (null != _stateUpdateInfo[i]) {
                    m_stateMgr.updateState(_stateUpdateInfo[i].m_iGearId, _stateUpdateInfo[i].m_iStateId, _stateUpdateInfo[i].m_iUpdateUnit);
                }
            }
        }
    }
}


