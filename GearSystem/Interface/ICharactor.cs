namespace GearSystem
{
    interface ICharactor<GEARINFO>
    {
        bool addGear(GEARINFO _addGearInfo);
        bool removeGear(GEARINFO _delGearInfo);
        IProperty getProperty();
        void setPropertyUpdateCallBack(reflashCallback _callBack);
    }
}
