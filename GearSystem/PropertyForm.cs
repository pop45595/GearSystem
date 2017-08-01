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
            throw new NotImplementedException();
        }

        public int getValue(e狀態名 _eKey)
        {
            throw new NotImplementedException();
        }

        public void setValue(e狀態名 _eKey, int _iValue)
        {
            throw new NotImplementedException();
        }
    }
}
