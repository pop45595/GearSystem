using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GearSystem
{
    class State : IState
    {
        public enum e狀態效果
        {
            基礎攻擊,
            基礎攻擊力加乘,
            基礎防禦力,
            基礎防禦力加乘,
            基礎最大血量,
            基礎血量加乘,
            基礎最大魔量,
            基礎魔量加乘,
            基礎移動速度,
            基礎生命回復,
            基礎攻擊速度,
            基礎爆擊率,
            基礎爆擊傷害,
            基礎格擋值,
            基礎金幣拾取量,
        }

        private e狀態效果 m_e狀態效果 = e狀態效果.基礎攻擊;
        private int m_iValue = 0;

        public State(e狀態效果 _e狀態效果 ,int _iValue)
        {
            m_e狀態效果 = _e狀態效果;
            m_iValue = _iValue;
        }

        public bool changeValue(ref IPropertyV2 _Property)
        {
            if (null != _Property)
            {
                switch (m_e狀態效果)
                {
                    case e狀態效果.基礎攻擊:
                        _Property.設攻擊(m_iValue);
                        break;
                    case e狀態效果.基礎攻擊力加乘:
                        _Property.設攻擊力加乘(m_iValue);
                        break;
                    case e狀態效果.基礎防禦力:
                        _Property.設防禦力(m_iValue);
                        break;
                    case e狀態效果.基礎防禦力加乘:
                        _Property.設防禦力加乘(m_iValue);
                        break;
                    case e狀態效果.基礎最大血量:
                        _Property.設最大血量(m_iValue);
                        break;
                    case e狀態效果.基礎血量加乘:
                        _Property.設血量加乘(m_iValue);
                        break;
                    case e狀態效果.基礎最大魔量:
                        _Property.設最大魔量(m_iValue);
                        break;
                    case e狀態效果.基礎魔量加乘:
                        _Property.設魔量加乘(m_iValue);
                        break;
                    case e狀態效果.基礎移動速度:
                        _Property.設移動速度(m_iValue);
                        break;
                    case e狀態效果.基礎生命回復:
                        _Property.設生命回復(m_iValue);
                        break;
                    case e狀態效果.基礎攻擊速度:
                        _Property.設攻擊速度(m_iValue);
                        break;
                    case e狀態效果.基礎爆擊率:
                        _Property.設爆擊率(m_iValue);
                        break;
                    case e狀態效果.基礎爆擊傷害:
                        _Property.設爆擊傷害(m_iValue);
                        break;
                    case e狀態效果.基礎格擋值:
                        _Property.設格檔值(m_iValue);
                        break;
                    case e狀態效果.基礎金幣拾取量:
                        _Property.設金幣拾取量(m_iValue);
                        break;
                    default:
                        return false;
                }
                return true;
            }
            else
            {
                return false;
            }
        }

        public void setNextState(IState _state)
        {
            throw new NotImplementedException();
        }

        public void setUpdateCallBack(UpdateStateCallback _updateCallback)
        {
            throw new NotImplementedException();
        }
    }
}
