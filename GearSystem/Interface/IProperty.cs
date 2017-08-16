namespace GearSystem
{
    public interface IProperty
    {
        int getValueToInt(int _iKey);
        float getValueToFloat(int _iKey);
        void getAllValue(ref int[] _iArrKeys, ref float[] _fArrValue);
    }
}
