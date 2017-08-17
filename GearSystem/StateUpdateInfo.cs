namespace GearSystem {
    public class StateUpdateInfo {
        public int m_iGearId = 0;
        public int m_iStateId = 0;
        public int m_iUpdateUnit = 0;
        public StateUpdateInfo(int _iGearId, int _iStateId, int _iUpdateUnit) {
            m_iGearId = _iGearId;
            m_iStateId = _iStateId;
            m_iUpdateUnit = _iUpdateUnit;
        }
    }
}
