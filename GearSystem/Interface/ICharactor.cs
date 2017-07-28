namespace GearSystem
{
    
    interface ICharactor
    {
        bool addGear(IGear _addGear);
        bool removeGear(IGear _delGear);
        IProperty getProperty();
        void setPropertyUpdateCallBack(updateCallback _callBack);
    }
}
