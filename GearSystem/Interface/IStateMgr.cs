namespace GearSystem
{
    public delegate void reflashCallback();
    public interface IStateMgr
    {
        bool addGear(IGear _IGear, int _iIndex);
        bool removeGear(int _iIndex);
        IProperty getProperty();
        void setReflashCallback(reflashCallback _reflashCallback);
        void updateState(int _iIndex,int _iStateId,int _iUpdateUnit);
    }
}
