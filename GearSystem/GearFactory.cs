using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GearSystem
{
    enum eGearType
    {
        小刀,
        長劍,
        盾牌,
        鐵靴
    }

    class GearFactory
    {
        public static Gear createFactory(eGearType _eGearType,IState[] _arrSates)
        {
            
            Gear gear = new Gear((int)_eGearType);

            switch (_eGearType)
            {
                case eGearType.小刀:
                    gear.setGear(new Knife());
                    break;
                case eGearType.長劍:
                    break;
                case eGearType.盾牌:
                    break;
                case eGearType.鐵靴:
                    break;
                default:
                    break;
            }

            foreach(IState state in _arrSates)
            {
                gear.addState(state);
            }
            return gear;
        }
    }
}
