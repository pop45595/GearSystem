namespace GearSystem
{
    interface IGearV2 : IGear
    {
        bool setGear(IGear _gear);
        bool addState(IState _state);
    }
}
