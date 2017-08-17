namespace GearSystem
{
    public interface IGear
    {
        int getGearID();
        IState[] getAllState();
        bool setIPropertyV2(IPropertyV2 _PropertyV2);
        void updateState(int _iInfoID);
    }
}
