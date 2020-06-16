using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace StateMachine
{
    class Game
    {

        private const int FRAMES_PER_SECOND = 25;
        private bool isRunning;
        public Game()
        {
            isRunning = true;
        }

        public void GameStart()
        {
            GlobalEntity global = new GlobalEntity(EntityDef.GLOBAL,"世界");
            EntityManager.GetInstance().AddEntity(global.GetID(), global);

            Hero hero = new Hero(EntityDef.MAIN_HERO,"刘伟");
            EntityManager.GetInstance().AddEntity(hero.GetID(), hero);
            GameLoop();
        }

        public void GameLoop()
        {
            while (isRunning)
            {
                //Thread.Sleep(1000);
                GameUpdate(1);
                MsgDispatcher.GetInstance().DispatchDelayMessage();
            }
        }

        public void GameUpdate(float delta)
        {
            foreach(IUpdate entity in EntityManager.GetInstance().GetEntityMap().Values)
            {
                entity.Update(delta);
            }
        }
    }
}
