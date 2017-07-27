using System;
using System.Collections;

namespace GearSystem
{
    public class PropertyForm : IPropertyV2
    {
        private Hashtable m_Hashtable = null;

        public PropertyForm()
        {
            reset();
        }

        public bool checkProperty(eGearState _eKey)
        {
            return m_Hashtable.ContainsKey(_eKey);
        }

        public IPropertyV2 copy()
        {
            PropertyForm newProperty = new PropertyForm();
            foreach(DictionaryEntry TheValue in m_Hashtable)
            {
                newProperty.setPropertyValue<object>((eGearState)TheValue.Key, TheValue.Value);
            }

            return newProperty;
        }

        public T getPropertyValue<T>(eGearState _eKey)
        {
            return (m_Hashtable.ContainsKey(_eKey)) ? (T)m_Hashtable[_eKey] : default(T);
        }

        public void reset()
        {
            m_Hashtable = new Hashtable();
        }

        public bool setPropertyValue<T>(eGearState _eGearState, T _iValue)
        {
            m_Hashtable.Add(_eGearState, _iValue);
            return true;
        }
    }
}
