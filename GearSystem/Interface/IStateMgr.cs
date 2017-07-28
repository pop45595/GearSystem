
namespace GearSystem
{
    public delegate void updateCallback();
    public interface IStateMgr
    {
        bool addGear(IGear _IGear, int _iIndex);
        bool removeGear(int _iIndex);
        void setUpdateCallback(updateCallback _updateCallback);
    }
}
