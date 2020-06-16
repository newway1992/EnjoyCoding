using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateMachine
{
    class Hero : BaseGameEntity, IUpdate
    {
        private StateMachine<Hero> fsm;
        private string m_szName;
        private string m_szSex;
        private int m_iAge;
        private string m_szRank;
        private string m_szTitle;

        public Hero(int id,string name) : base(id,name)
        {
            m_szName = name;
            m_szSex = "男";
            m_iAge = 22;
            m_szTitle = TitleDef.Title_NONE;
            m_szRank = RankDef.RANK_DAXUESHENG;
            fsm = new StateMachine<Hero>(this, PlayerNone.Instance(), PlayerNone.Instance(),GlobalState.Instance());
        }

        public void Update(float delta)
        {
            if (fsm != null)
            {
                fsm.Update(delta);
            }
        }

        public string Desc()
        {
            return string.Format("ID:{0} 姓名:{1} 性别:{2} 年龄:{3} 职位:{4} 级别:{5}", this.GetID(), this.Name, this.m_szSex, this.Age, this.Title, this.Rank);
        }

        public string Name
        {
            set { m_szName = value; }
            get { return m_szName; }
        }

        public string Sex
        {
            set { m_szSex = value; }
            get { return m_szSex; }
        }

        public string Rank
        {
            set { m_szRank = value; }
            get { return m_szRank; }
        }

        public string Title
        {
            set { m_szTitle = value; }
            get { return m_szTitle; }
        }

        public int Age
        {
            set { m_iAge = value; }
            get { return m_iAge; }
        }

        public StateMachine<Hero> GetFSM()
        {
            return fsm;
        }

        public override bool HandleMessage(Msg msg)
        {
            if(fsm == null)
            {
                return base.HandleMessage(msg);
            }
            return fsm.HandleMessage(msg);
        }
        //public void ChangeState(State<Hero> newState)
        //{
        //    fsm.ChangeState(newState);
        //}
    }
}
