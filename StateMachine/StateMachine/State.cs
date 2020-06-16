using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateMachine
{
    abstract class State<T> where T:BaseGameEntity
    {
        private string m_szName = "";

        public State(string name)
        {
            m_szName = name;
        }

        public string GetName()
        {
            return m_szName;
        }

        public abstract void Execute(T entity);

        public abstract void Enter(T entity);

        public abstract void Exit(T entity);

        public virtual bool OnMessage(T entity, Msg msg)
        {
            return false;
        }
    }
}
