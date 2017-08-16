using System.Collections.Generic;
using GearSystem;
namespace LOLGearSystem
{
    public class StateMgr : IStateMgr
    {
        private reflashCallback m_Callback = null;

        private IPropertyV2 m_baseProperty = null;
        private List<IPropertyV2> m_ListProperty = null;
        private GearSystem.IPropertyV2 m_FinalProperty = null;

        private IGear[] m_ArrGear = null;
        private int m_iCount = 0;

        private List<List<IState>> m_ListState = null;

        public StateMgr(int _iCount)
        {
            m_iCount = _iCount;
            m_ArrGear = new IGear[_iCount];
            m_ListState = new List<List<IState>>();
            m_baseProperty = new PropertyForm();
            m_ListProperty = new List<IPropertyV2>();
            m_FinalProperty = m_baseProperty;
        }

        public bool addGear(IGear _IGear, int _iIndex)
        {
            if (checkIndex(_iIndex))
            {
                m_ArrGear[_iIndex] = _IGear;
                addState(_IGear);
                reflashProperty();
                return true;
            }else
            {
                return false;
            }
        }

        public bool removeGear(int _iIndex)
        {
            if (checkIndex(_iIndex))
            {
                m_ArrGear[_iIndex] = null;
                reflashAllGear();
                reflashProperty();
                return true;
            }
            else
            {
                return false;
            }
        }

        public IProperty getProperty()
        {
            return m_FinalProperty;
        }

        public void setReflashCallback(reflashCallback _reflashCallback)
        {
            m_Callback = _reflashCallback;
        }
//--------------------------------------------------------------------------------
        private bool checkIndex(int _iIndex)
        {
            return (_iIndex >= 0 && m_iCount > _iIndex);
        }

        private void reflashProperty()
        {
            IPropertyV2 newProperty = m_baseProperty.copy();

            for (int i = 0; i < m_ListState.Count; ++i)
            {
                for (int j = 0; j< m_ListState[i].Count; ++j)
                {
                    m_ListState[i][j].changeValue(ref newProperty);
                }

                if (m_ListProperty.Count > i)
                {
                    m_ListProperty[i] = newProperty;
                }
                else
                {
                    m_ListProperty.Add(newProperty);
                }

                if( (i+1) != m_ListState.Count) newProperty = newProperty.copy();
            }
            m_FinalProperty = newProperty;
            if (m_Callback != null) m_Callback();
        }

        private void addState(IGear _Gear)
        {
            IState[] ArrState = _Gear.getAllState();
            if (ArrState != null)
            {
                int iLevel = 0;
                for (int i = 0; i< ArrState.Length; ++i)
                {
                    iLevel = ArrState[i].getLevel();
                    if (iLevel >= 0)
                    {
                        if (iLevel >= m_ListState.Count)
                        {
                            do
                            {
                                m_ListState.Add(new List<IState>());
                            }
                            while (m_ListState.Count == iLevel);
                        }
                        
                        m_ListState[iLevel].Add(ArrState[i]);
                    }
                }
            }
        }

        private void reflashAllGear()
        {
            m_ListState.Clear();
            for (int i = 0; i<m_ArrGear.Length; ++i)
            {
                if (m_ArrGear[i] != null)
                {
                    addState(m_ArrGear[i]);
                }
            }
        }

    }
}
