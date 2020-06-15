using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateMachine.state.common
{
    class Authorize:State<BaseGameEntity>
    {
        private static PlayerMove instance = new PlayerMove();
        public static PlayerMove Instance()
        {
            return instance;
        }
        public Authorize() : base(StateConst.STATE_PLAYER_MOVE)
        {
        }

        public override void Enter(BaseGameEntity entity)
        {
            //throw new System.NotImplementedException();
        }

        public override void Execute(BaseGameEntity entity)
        {

        }

        public override void Exit(BaseGameEntity entity)
        {
            //throw new System.NotImplementedException();
        }
    }
}
