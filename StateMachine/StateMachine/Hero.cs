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

        private string m_szLocation;
        private string m_szName;
        private int m_iAge;
        private string m_szRank;
        private string m_szTitle;

        public Hero(string name) : base()
        {
            m_szLocation = LocationConst.LOCATION_HOME;
            m_szName = name;
            fsm = new StateMachine<Hero>(this, PlayerNone.Instance(), PlayerNone.Instance(), null);
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
            return string.Format("姓名:{0} 年龄:{1} 职位:{2} 级别:{3}", this.Name, this.Age, this.Title, this.Rank);
        }

        public string Name
        {
            set { m_szName = value; }
            get { return m_szName; }
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
            return this.fsm;
        }

        //public void ChangeState(State<Hero> newState)
        //{
        //    fsm.ChangeState(newState);
        //}
    }
}
