using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GearSystem
{
    interface IGearV2 : IGear
    {
        bool setGear(IGear _gear);
        bool addState(IState _state);
    }
}
