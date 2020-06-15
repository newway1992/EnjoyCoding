using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateMachine
{
    class GlobalState : State<BaseGameEntity>
    {
        private static GlobalState instance = new GlobalState();
        public static GlobalState Instance()
        {
            return instance;
        }
        public GlobalState() : base(StateConst.STATE_GLOBAL)
        {
        }

        public override void Enter(BaseGameEntity entity)
        {
        }

        public override void Execute(BaseGameEntity entity)
        {

        }

        public override void Exit(BaseGameEntity entity)
        {
        }

        public override bool OnMessage(BaseGameEntity entity, Msg msg)
        {
            return true;
        }
    }
}
