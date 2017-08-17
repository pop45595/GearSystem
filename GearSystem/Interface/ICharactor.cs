namespace GearSystem
{
    interface ICharactor<GEAR_INFO,STATE_UPDATE_INFO>
    {
        bool addGear(GEAR_INFO _addGearInfo);
        bool removeGear(GEAR_INFO _delGearInfo);
        IProperty getProperty();
        void setPropertyUpdateCallBack(reflashCallback _callBack);
        void updateState(STATE_UPDATE_INFO[] _stateUpdateInfo);
    }
}
