using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateMachine
{
    public class Msg
    {
        public int sender;
        public int reciever;
        public int msgId;
        public float delay;
        public DateTime dispatchTime;

        public Msg(int _sender,int _reciever, int _msgId, float _delay, DateTime _dispatchTime)
        {
            sender = _sender;
            reciever = _reciever;
            msgId = _msgId;
            delay = _delay;
            dispatchTime = _dispatchTime;
        }
    }
}
