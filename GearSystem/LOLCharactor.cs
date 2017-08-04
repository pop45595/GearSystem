using System;
using System.Collections.Generic;
using GearSystem;

namespace GearSystem { 
    public class LOLCharactor : ICharactor<GearInfo>
    {
        private IPropertyV2 m_charactorProperty = null;
        private IStateMgr m_stateMgr = null;
        //private ICreator<IGear> m_GearCreator = null;
        private List<int> m_iListGearIDRecord = null;
        private int m_iMaxGear = 6;
        public LOLCharactor() {
            m_iListGearIDRecord = new List<int>();
            m_charactorProperty = new PropertyForm();
            m_stateMgr = new StateMgr(m_iMaxGear);
        }
        public IProperty getProperty()
        {
            return m_stateMgr.getProperty();
        }

        public bool addGear(GearInfo _addGearInfo) {
            IGear gear = GearCreator.Create(_addGearInfo.m_GearId);
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

    }
}

