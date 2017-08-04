using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GearSystem {
    public class GearInfo {
        public int m_GearId=0;
        public List<int> m_iListAdditionalState = new List<int>();
        public GearInfo(int _GearId,params int[] _iAryGearAdditionalState) {
            m_GearId = _GearId;
            if (null != _iAryGearAdditionalState) {
                for (int i = 0; i < _iAryGearAdditionalState.Length; ++i) {
                    m_iListAdditionalState.Add(_iAryGearAdditionalState[i]);
                }
            }
        }
    }
}
