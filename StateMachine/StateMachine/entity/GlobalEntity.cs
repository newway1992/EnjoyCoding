using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateMachine
{
    class GlobalEntity : BaseGameEntity, IUpdate
    {
        public GlobalEntity(int id,string name):base(id,name)
        {
        }

        public void Update(float delta)
        {
        }

        public override bool HandleMessage(Msg msg)
        {
            if (msg == null)
            {
                return false;
            }
            if(msg.msgId == MsgDef.MSG_CANJIAKAOSHI)
            {
                var entity = EntityManager.GetInstance().GetEntity(msg.sender) as Hero;
                Log.Print("恭喜{0}以优异的成绩通过考试!", entity.Name);
                MsgDispatcher.GetInstance().DispatchMessage(5, this.GetID(), entity.GetID(), MsgDef.MSG_TONGGUOKAOSHI,RankDef.RANK_ZHENGKEJI,TitleDef.Title_KEZHANG);
                return true;
            }
            return false;
        }
    }
}
