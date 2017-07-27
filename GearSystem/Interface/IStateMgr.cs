
namespace GearSystem
{
    public interface IStateMgr
    {
        bool addGear(IGear _IGear);
        bool removeGear(int _iIndex);
        void updateProprety();
    }
}
