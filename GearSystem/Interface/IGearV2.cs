namespace GearSystem
{
    interface IGearV2 : IGear
    {
        bool setIPropertyV2(IPropertyV2 _PropertyV2);
        bool setGear(IGear _gear);
        bool addState(IState _state);
    }
}
