using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GearSystem
{
    class Knife : IGear
    {
        private IState[] m_arrState = null;

        public Knife()
        {            
            m_arrState = new IState[] {
                new State(eGearState.攻擊力, 100),
                new State(eGearState.爆擊傷害, 300),
                new State(eGearState.移動速度, -50)
            };
        }

        public IState[] getAllState()
        {
            return m_arrState;
        }

        public int getGearID()
        {
            return -1;
        }
    }
}
