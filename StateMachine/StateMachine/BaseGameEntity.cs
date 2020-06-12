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
        private static int m_iNextValidID;
        protected State m_pCurrentState;
        protected State m_pPreState;
        protected State m_pGlobalState;

        void SetID()
        {
            m_ID = m_iNextValidID;
            m_iNextValidID++;
        }

        public BaseGameEntity()
        {
            SetID();
        }

        public int GetID()
        {
            return m_ID;
        }

        public virtual void Update()
        {

        }
    }
}
