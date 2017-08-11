namespace GearSystem
{
    public delegate void OnSensorTrigger();
    public interface ISensor{
        void triggerSensor();
        void addListener(OnSensorTrigger _sensorListener);
    }
}
