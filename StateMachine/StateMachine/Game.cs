using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace StateMachine
{
    class Game
    {
        public Dictionary<int, BaseGameEntity> entityMap;

        private const int FRAMES_PER_SECOND = 25;
        private bool isRunning;
        private float curTick;
        public Game()
        {
            isRunning = true;
            entityMap = new Dictionary<int, BaseGameEntity>();
        }

        public void GameStart()
        {
            Hero hero = new Hero("刘伟");
            entityMap.Add(hero.GetID(), hero);
            GameLoop();
        }

        public void GameLoop()
        {
            while (isRunning)
            {
                Thread.Sleep(1000);
                Update(1);
            }
        }

        public void Update(float delta)
        {
            foreach(IUpdate entity in entityMap.Values)
            {
                entity.Update(delta);
            }
        }
    }
}
