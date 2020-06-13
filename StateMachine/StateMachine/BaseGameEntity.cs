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
        protected State<T> m_pCurrentState;
        protected State<T> m_pPreState;
        protected State<T> m_pGlobalState;

        void SetID()
        {
            m_ID = IDGenerator.GetInstance().GetValidID();
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
