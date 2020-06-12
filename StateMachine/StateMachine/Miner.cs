using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateMachine
{
    class Miner : BaseGameEntity
    {
        private string m_szLocation;
        private int m_iThirst;
        private int m_iGoldNum;
        private int m_iMoney;
        private int m_iFatigue;

        public Miner()
        {
            m_szLocation = LocationConst.LOCATION_HOME;
            m_iThirst = 0;
            m_iGoldNum = 0;
            m_iMoney = 0;
            m_iFatigue = 0;
        }

        public override void Update()
        {
            if(m_pCurrentState != null)
            {
                m_pCurrentState.Execute(this);
            }
        }

        public void ChangeState(State newState)
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
