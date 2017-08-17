
namespace LOLGearSystem
{
    class PropertyRule
    {
        public enum e狀態名
        {
            物理攻擊,
            物理攻擊加成,
            魔法攻擊,
            魔法攻擊加成,
            防禦力,
            防禦力加成,
            生命,
            生命加成,
            魔力,
            魔力加乘,
            移動速度,
            生命回復,
            攻擊速度,
            暴擊率,
            暴擊傷害,
            格擋值,
            金幣時取量
        }
        private static PropertyRule m_PropertyRule = null;

        public static PropertyRule instance
        {
            get
            {
                if (null == m_PropertyRule)
                {
                    m_PropertyRule = new PropertyRule();
                }
                return m_PropertyRule;
            }
        }

    }
}
