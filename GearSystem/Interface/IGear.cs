namespace GearSystem
{
    public interface IGear
    {
        int getGearID();
        IState[] getAllState();
        void updateState(int _iInfoID);
    }
}
