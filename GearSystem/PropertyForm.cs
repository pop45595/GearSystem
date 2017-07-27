using System;
using System.Collections;

namespace GearSystem
{
    public class PropertyForm : IPropertyV2
    {
        private enum e存入key名
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

        private Hashtable m_Hashtable = null;

        public PropertyForm()
        {
            m_Hashtable = new Hashtable();
        }

        public IPropertyV2 copy()
        {
            PropertyForm newProperty = new PropertyForm();

            newProperty.設攻擊(取攻擊());
            newProperty.設攻擊力加乘(取攻擊力加乘());
            newProperty.設防禦力(取防禦力());
            newProperty.設防禦力加乘(取防禦力加乘());
            newProperty.設最大血量(取最大血量());
            newProperty.設血量加乘(取血量加乘());
            newProperty.設最大魔量(取最大魔量());
            newProperty.設魔量加乘(取魔量加乘());
            newProperty.設移動速度(取移動速度());
            newProperty.設生命回復(取生命回復());
            newProperty.設攻擊速度(取攻擊速度());
            newProperty.設爆擊率(取爆擊率());
            newProperty.設爆擊傷害(取爆擊傷害());
            newProperty.設格檔值(取格檔值());
            newProperty.設金幣拾取量(取金幣拾取量());

            return newProperty;
        }
        
        public int 取攻擊()
        {
            return (m_Hashtable.ContainsKey(e存入key名.攻擊)) ? (int)m_Hashtable[e存入key名.攻擊] : 0 ;
        }

        public int 取攻擊力加乘()
        {
            return (m_Hashtable.ContainsKey(e存入key名.攻擊力加乘)) ? (int)m_Hashtable[e存入key名.攻擊力加乘] : 0;
        }

        public int 取攻擊速度()
        {
            return (m_Hashtable.ContainsKey(e存入key名.攻擊速度)) ? (int)m_Hashtable[e存入key名.攻擊速度] : 0;
        }

        public int 取最大血量()
        {
            return (m_Hashtable.ContainsKey(e存入key名.最大血量)) ? (int)m_Hashtable[e存入key名.最大血量] : 0;
        }

        public int 取最大魔量()
        {
            return (m_Hashtable.ContainsKey(e存入key名.最大魔量)) ? (int)m_Hashtable[e存入key名.最大魔量] : 0;
        }
        
        public int 取格檔值()
        {
            return (m_Hashtable.ContainsKey(e存入key名.格擋值)) ? (int)m_Hashtable[e存入key名.格擋值] : 0;
        }

        public int 取爆擊傷害()
        {
            return (m_Hashtable.ContainsKey(e存入key名.暴擊傷害)) ? (int)m_Hashtable[e存入key名.暴擊傷害] : 0;
        }

        public int 取爆擊率()
        {
            return (m_Hashtable.ContainsKey(e存入key名.暴擊率)) ? (int)m_Hashtable[e存入key名.暴擊率] : 0;
        }

        public int 取生命回復()
        {
            return (m_Hashtable.ContainsKey(e存入key名.生命回復)) ? (int)m_Hashtable[e存入key名.生命回復] : 0;
        }

        public int 取移動速度()
        {
            return (m_Hashtable.ContainsKey(e存入key名.移動速度)) ? (int)m_Hashtable[e存入key名.移動速度] : 0;
        }
        
        public int 取血量加乘()
        {
            return (m_Hashtable.ContainsKey(e存入key名.血量加乘)) ? (int)m_Hashtable[e存入key名.血量加乘] : 0;
        }

        public int 取金幣拾取量()
        {
            return (m_Hashtable.ContainsKey(e存入key名.金幣時取量)) ? (int)m_Hashtable[e存入key名.金幣時取量] : 0;
        }

        public int 取防禦力()
        {
            return (m_Hashtable.ContainsKey(e存入key名.防禦力)) ? (int)m_Hashtable[e存入key名.防禦力] : 0;
        }

        public int 取防禦力加乘()
        {
            return (m_Hashtable.ContainsKey(e存入key名.防禦力加乘)) ? (int)m_Hashtable[e存入key名.防禦力加乘] : 0;
        }
        
        public int 取魔量加乘()
        {
            return (m_Hashtable.ContainsKey(e存入key名.魔量加乘)) ? (int)m_Hashtable[e存入key名.魔量加乘] : 0;
        }

        public bool 設攻擊(int _iValue)
        {
            if (m_Hashtable.ContainsKey(e存入key名.攻擊))
            {
                int lastValue = (int)m_Hashtable[e存入key名.攻擊];
                _iValue += lastValue;
                m_Hashtable[e存入key名.攻擊] = _iValue;
            }
            else
            {
                m_Hashtable.Add(e存入key名.攻擊, _iValue);
            }

            return true;
        }

        public bool 設攻擊力加乘(int _iValue)
        {
            if (m_Hashtable.ContainsKey(e存入key名.攻擊力加乘))
            {
                int lastValue = (int)m_Hashtable[e存入key名.攻擊力加乘];
                _iValue += lastValue;
                m_Hashtable[e存入key名.攻擊力加乘] = _iValue;
            }
            else
            {
                m_Hashtable.Add(e存入key名.攻擊力加乘, _iValue);
            }

            return true;
        }

        public bool 設攻擊速度(int _iValue)
        {
            if (m_Hashtable.ContainsKey(e存入key名.攻擊速度))
            {
                int lastValue = (int)m_Hashtable[e存入key名.攻擊速度];
                _iValue += lastValue;
                m_Hashtable[e存入key名.攻擊速度] = _iValue;
            }
            else
            {
                m_Hashtable.Add(e存入key名.攻擊速度, _iValue);
            }

            return true;
        }

        public bool 設最大血量(int _iValue)
        {
            if (m_Hashtable.ContainsKey(e存入key名.最大血量))
            {
                int lastValue = (int)m_Hashtable[e存入key名.最大血量];
                _iValue += lastValue;
                m_Hashtable[e存入key名.最大血量] = _iValue;
            }
            else
            {
                m_Hashtable.Add(e存入key名.最大血量, _iValue);
            }

            return true;
        }

        public bool 設最大魔量(int _iValue)
        {
            if (m_Hashtable.ContainsKey(e存入key名.最大魔量))
            {
                int lastValue = (int)m_Hashtable[e存入key名.最大魔量];
                _iValue += lastValue;
                m_Hashtable[e存入key名.最大魔量] = _iValue;
            }
            else
            {
                m_Hashtable.Add(e存入key名.最大魔量, _iValue);
            }

            return true;
        }

        public bool 設格檔值(int _iValue)
        {
            if (m_Hashtable.ContainsKey(e存入key名.格擋值))
            {
                int lastValue = (int)m_Hashtable[e存入key名.格擋值];
                _iValue += lastValue;
                m_Hashtable[e存入key名.格擋值] = _iValue;
            }
            else
            {
                m_Hashtable.Add(e存入key名.格擋值, _iValue);
            }

            return true;
        }

        public bool 設爆擊傷害(int _iValue)
        {
            if (m_Hashtable.ContainsKey(e存入key名.暴擊傷害))
            {
                int lastValue = (int)m_Hashtable[e存入key名.暴擊傷害];
                _iValue += lastValue;
                m_Hashtable[e存入key名.暴擊傷害] = _iValue;
            }
            else
            {
                m_Hashtable.Add(e存入key名.暴擊傷害, _iValue);
            }

            return true;
        }

        public bool 設爆擊率(int _iValue)
        {
            if (m_Hashtable.ContainsKey(e存入key名.暴擊率))
            {
                int lastValue = (int)m_Hashtable[e存入key名.暴擊率];
                _iValue += lastValue;
                m_Hashtable[e存入key名.暴擊率] = _iValue;
            }
            else
            {
                m_Hashtable.Add(e存入key名.暴擊率, _iValue);
            }

            return true;
        }

        public bool 設生命回復(int _iValue)
        {
            if (m_Hashtable.ContainsKey(e存入key名.生命回復))
            {
                int lastValue = (int)m_Hashtable[e存入key名.生命回復];
                _iValue += lastValue;
                m_Hashtable[e存入key名.生命回復] = _iValue;
            }
            else
            {
                m_Hashtable.Add(e存入key名.生命回復, _iValue);
            }

            return true;
        }

        public bool 設移動速度(int _iValue)
        {
            if (m_Hashtable.ContainsKey(e存入key名.移動速度))
            {
                int lastValue = (int)m_Hashtable[e存入key名.移動速度];
                _iValue += lastValue;
                m_Hashtable[e存入key名.移動速度] = _iValue;
            }
            else
            {
                m_Hashtable.Add(e存入key名.移動速度, _iValue);
            }

            return true;
        }

        public bool 設血量加乘(int _iValue)
        {
            if (m_Hashtable.ContainsKey(e存入key名.血量加乘))
            {
                int lastValue = (int)m_Hashtable[e存入key名.血量加乘];
                _iValue += lastValue;
                m_Hashtable[e存入key名.血量加乘] = _iValue;
            }
            else
            {
                m_Hashtable.Add(e存入key名.血量加乘, _iValue);
            }

            return true;
        }

        public bool 設金幣拾取量(int _iValue)
        {
            if (m_Hashtable.ContainsKey(e存入key名.金幣時取量))
            {
                int lastValue = (int)m_Hashtable[e存入key名.金幣時取量];
                _iValue += lastValue;
                m_Hashtable[e存入key名.金幣時取量] = _iValue;
            }
            else
            {
                m_Hashtable.Add(e存入key名.金幣時取量, _iValue);
            }

            return true;
        }

        public bool 設防禦力(int _iValue)
        {
            if (m_Hashtable.ContainsKey(e存入key名.防禦力))
            {
                int lastValue = (int)m_Hashtable[e存入key名.防禦力];
                _iValue += lastValue;
                m_Hashtable[e存入key名.防禦力] = _iValue;
            }
            else
            {
                m_Hashtable.Add(e存入key名.防禦力, _iValue);
            }

            return true;
        }

        public bool 設防禦力加乘(int _iValue)
        {
            if (m_Hashtable.ContainsKey(e存入key名.防禦力加乘))
            {
                int lastValue = (int)m_Hashtable[e存入key名.防禦力加乘];
                _iValue += lastValue;
                m_Hashtable[e存入key名.防禦力加乘] = _iValue;
            }
            else
            {
                m_Hashtable.Add(e存入key名.防禦力加乘, _iValue);
            }

            return true;
        }

        public bool 設魔量加乘(int _iValue)
        {
            if (m_Hashtable.ContainsKey(e存入key名.魔量加乘))
            {
                int lastValue = (int)m_Hashtable[e存入key名.魔量加乘];
                _iValue += lastValue;
                m_Hashtable[e存入key名.魔量加乘] = _iValue;
            }
            else
            {
                m_Hashtable.Add(e存入key名.魔量加乘, _iValue);
            }

            return true;
        }
    }
}
