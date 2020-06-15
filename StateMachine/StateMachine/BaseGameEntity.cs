using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateMachine
{
    class BaseGameEntity
    {
        private int m_ID;
        private string m_szName;

        void SetID()
        {
            m_ID = IDGenerator.GetInstance().GetValidID();
        }
        public BaseGameEntity()
        {
            SetID();
        }

        public BaseGameEntity(int id,string name)
        {
            m_ID = id;
            m_szName = name;
        }

        public BaseGameEntity(string name)
        {
            SetID();
            m_szName = name;
        }

        public int GetID()
        {
            return m_ID;
        }

        public string GetName()
        {
            return m_szName;
        }

        public virtual bool HandleMessage(Msg msg)
        {
            return true;
        }
    }
}
