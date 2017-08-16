
namespace LOLGearSystem
{
    class SuperMarket
    {
        private GearCreator _gearCreator = null;
        public GearCreator m_gearCreator {
            get { return _gearCreator; }
        }
        private static SuperMarket m_superMarket = null;
        public static SuperMarket instance
        {
            get
            {
                if(null == m_superMarket)
                {
                    m_superMarket = new SuperMarket();
                    m_superMarket._gearCreator = new GearCreator();
                }
                return m_superMarket;
            }
        }
    }
}
