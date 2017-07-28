using System;
using System.Collections.Generic;
using GearSystem;

namespace GearSystem { 
    public class LOLCharactor : ICharactor
    {
        private IPropertyV2 m_charactorProperty = null;
        private IStateMgr m_stateMgr = null;
        private List<int> m_iListGearIDRecord = null;
        private int m_iMaxGear = 6;
        public LOLCharactor() {
            m_iListGearIDRecord = new List<int>();
            m_charactorProperty = new PropertyForm();
            m_stateMgr = new StateMgr(m_charactorProperty, m_iMaxGear);
        }
        public IProperty getProperty()
        {
            //m_stateMgr.updateProprety();
            
            return m_charactorProperty as IProperty;
        }

        public bool addGear(IGear _addGear)
        {
            if (m_stateMgr.addGear(_addGear, m_iListGearIDRecord.Count)){
                int iGearId = _addGear.getGearID();
                m_iListGearIDRecord.Add(iGearId);
                return true;
            }else {
                return false;
            }

        }

        public bool removeGear(IGear _delGear)
        {
            int? iGearPosition = getGearPosition(_delGear);
            if (iGearPosition.HasValue) {
                if (m_stateMgr.removeGear(iGearPosition.Value)) {
                    m_iListGearIDRecord.RemoveAt(iGearPosition.Value);
                    return true;
                }
            }
            return false;
        }
        private int? getGearPosition(IGear _delGear) {
            int iTargetID = _delGear.getGearID();
            for (int i = 0; i < m_iListGearIDRecord.Count; ++i) {
                if (m_iListGearIDRecord[i] == iTargetID) {
                    return i;
                }
            }
            return null;
        }
        public void setPropertyUpdateCallBack(updateCallback _callBack)
        {
            m_stateMgr.setUpdateCallback(_callBack);
        }
    }
}

