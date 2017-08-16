
namespace LOLGearSystem
{
    class PropertyRule
    {
        public enum e狀態名
        {
            攻擊,
            攻擊力加乘,
            防禦力,
            防禦力加乘,
            最大血量,
            血量加乘,
            最大魔量,
            魔量加乘,
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
