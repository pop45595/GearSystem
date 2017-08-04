using System;
using System.Collections;

namespace GearSystem
{
    public class PropertyForm : IPropertyV2
    {

        private Hashtable m_Hashtable = null;

        public PropertyForm()
        {
            m_Hashtable = new Hashtable();
        }

        public IPropertyV2 copy()
        {
            PropertyForm newPropertyFrom = new PropertyForm();

            foreach (DictionaryEntry value in m_Hashtable)
            {
                newPropertyFrom.setValue((e狀態名)value.Key, value.Value);
            }

            return newPropertyFrom;
        }

        public int getValueToInt(e狀態名 _eKey)
        {
            if (m_Hashtable.ContainsKey(_eKey))
            {
                return (int)m_Hashtable[_eKey];
            }
            else
            {
                return 0;
            }
        }

        public float getValueToFloat(e狀態名 _eKey)
        {
            if (m_Hashtable.ContainsKey(_eKey))
            {
                return (float)m_Hashtable[_eKey];
            }
            else
            {
                return 0.0f;
            }
        }

        public void setValue(e狀態名 _eKey, int _iValue)
        {
            if (m_Hashtable.ContainsKey(_eKey))
            {
                m_Hashtable[_eKey] = _iValue;
            }
            else
            {
                m_Hashtable.Add(_eKey, _iValue);
            }
        }

        public void setValue(e狀態名 _eKey, float _fValue)
        {
            if (m_Hashtable.ContainsKey(_eKey))
            {
                m_Hashtable[_eKey] = _fValue;
            }
            else
            {
                m_Hashtable.Add(_eKey, _fValue);
            }
        }

        public void reset()
        {
            m_Hashtable = new Hashtable();
        }

        public void setValue(e狀態名 _eKey, object _objValue)
        {
            if (m_Hashtable.ContainsKey(_eKey))
            {
                m_Hashtable[_eKey] = _objValue;
            }
            else
            {
                m_Hashtable.Add(_eKey, _objValue);
            }
        }
    }
}
