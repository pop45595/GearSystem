
namespace GearSystem
{
    public delegate void UpdateStateCallback();
    public interface IState
    {
        void setNextState(IState _state);
        bool changeValue(ref IPropertyV2 _Property);
        void setUpdateCallBack(UpdateStateCallback _updateCallback);
    }
}
