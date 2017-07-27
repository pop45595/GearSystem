
namespace GearSystem
{
    public interface ICharacter
    {
        bool addGear(int _iGearId);
        bool removeGear(int _iGearId);
        IProperty getProperty();
    }
}
