﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateMachine
{
    class StateMachine<T> where T : BaseGameEntity
    {
        private T m_entity;
        protected State<T> m_pCurrentState;
        protected State<T> m_pPreState;
        protected State<T> m_pGlobalState;

        public StateMachine(T entity, State<T> currentState, State<T> preState, State<T> globalState)
        {
            m_entity = entity;
            m_pCurrentState = currentState;
            m_pPreState = preState;
            m_pGlobalState = globalState;

        }

        public void Update(float delta)
        {
            if (m_pGlobalState != null)
            {
                m_pGlobalState.Execute(m_entity);
            }
            if (m_pCurrentState != null)
            {
                m_pCurrentState.Execute(m_entity);
            }
        }

        public void ChangeState(State<T> newState)
        {
            if (m_pCurrentState != null)
            {
                Log.Print("entity:{0} [{1}]->[{2}]", m_entity.GetID(),m_pPreState?.GetName(), m_pCurrentState.GetName());
                m_pPreState = m_pCurrentState;
                m_pCurrentState.Exit(m_entity);
                m_pCurrentState = newState;
                m_pCurrentState.Enter(m_entity);
            }
        }

        public void RevertToPreState()
        {
            ChangeState(m_pPreState);
        }

    }
}