using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateMachine
{
    class Hero : BaseGameEntity
    {
        protected State<Hero> m_pCurrentState;
        protected State<Hero> m_pPreState;
        protected State<Hero> m_pGlobalState;

        private string m_szLocation;
        private int m_iHp;
        private int m_iMp;
        private int m_iWeopon;

        public Hero() : base()
        {
            m_szLocation = LocationConst.LOCATION_HOME;
            m_iHp = 0;
            m_iMp = 0;
            m_iWeopon = WeaponConst.WEPON_NONE;
            m_pCurrentState = new PlayerBorn();
        }

        public override void Update()
        {
            if (m_pCurrentState != null)
            {
                m_pCurrentState.Execute(this);
            }
        }

        public void ChangeState(State<Hero> newState)
        {
            if (m_pCurrentState != null)
            {
                m_pCurrentState.Exit(this);
                m_pCurrentState = newState;
                m_pCurrentState.Enter(this);
            }
        }

    }
}
