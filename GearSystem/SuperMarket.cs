using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GearSystem
{
    class SuperMarket
    {
        public GearCreator m_gearCreator = null;
        private static SuperMarket m_superMarket = null;
        public static SuperMarket instance
        {
            get
            {
                if(null == m_superMarket)
                {
                    m_superMarket = new SuperMarket();
                    m_superMarket.m_gearCreator = new GearCreator();
                }
                return m_superMarket;
            }
        }
    }
}
