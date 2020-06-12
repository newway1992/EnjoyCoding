using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateMachine
{
    abstract class State
    {
        public abstract void Execute(BaseGameEntity entity);

        public abstract void Enter(BaseGameEntity entity);

        public abstract void Exit(BaseGameEntity entity);
    }
}
