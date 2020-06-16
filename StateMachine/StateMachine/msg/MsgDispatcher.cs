using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateMachine
{
    class MsgComparer : IComparer<Msg>
    {
        public int Compare(Msg x, Msg y)
        {
            if(x.dispatchTime < y.dispatchTime)
            {
                return -1;
            }else if(x.dispatchTime > y.dispatchTime)
            {
                return 1;
            }else
            {
                return 0;
            }
        }

    }
    class MsgDispatcher
    {
        private SortedSet<Msg> priorityQ = new SortedSet<Msg>(new MsgComparer());

        private static MsgDispatcher instance = new MsgDispatcher();

        public static MsgDispatcher GetInstance()
        {
            return instance;
        }

        private void Discharge(BaseGameEntity entity, Msg msg)
        {
            if (entity != null)
            {
                entity.HandleMessage(msg);
            }
        }

        public void DispatchMessage(float delay, int sender, int reciever, int msg,params object[] extraInfo)
        {
            var receiverEntity = EntityManager.GetInstance().GetEntity(reciever);
            Msg message = new Msg(sender, reciever, msg, delay, DateTime.Now);
            message.extraInfo = extraInfo;
            if (Math.Abs(delay - 0) < 0.01)
            {
                Discharge(receiverEntity, message);
            }
            else
            {
                DateTime dispatchTime = DateTime.Now.AddSeconds(delay);
                message.dispatchTime = dispatchTime;
                priorityQ.Add(message);
            }
        }

        public void DispatchDelayMessage()
        {
            DateTime now = DateTime.Now;
            while (priorityQ.Count > 0 && priorityQ.First() != null && priorityQ.First().dispatchTime < now)
            {
                Msg message = priorityQ.First();
                var receiverEntity = EntityManager.GetInstance().GetEntity(message.reciever);
                Discharge(receiverEntity, message);
                var result = priorityQ.Remove(message);
            }
        }
    }
}
