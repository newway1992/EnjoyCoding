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
            if(msg.msgId == MsgDef.MSG_TONGGUOKAOSHI)
            {
                var hero = EntityManager.GetInstance().GetEntity(msg.reciever) as Hero;
                hero.Rank = msg.extraInfo[0] as string;
                hero.Title = msg.extraInfo[1] as string;
                hero.GetFSM().ChangeState(PlayerMove.Instance());
            }
            return true;
        }
    }
}
