﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateMachine
{
    class Hero : BaseGameEntity
    {
        private string m_szLocation;
        private int m_iHp;
        private int m_iMp;
        private int m_iWeopon;

        public Hero():base()
        {
            m_szLocation = LocationConst.LOCATION_HOME;
            m_iHp = 0;
            m_iMp = 0;
            m_iWeopon = WeaponConst.WEPON_NONE;
        }

        public override void Update()
        {
            if (m_pCurrentState != null)
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
}