namespace StateMachine
{
    class PlayerMove:State<Hero>
    {
        private static PlayerMove instance = new PlayerMove();
        public static PlayerMove Instance()
        {
            return instance;
        }
        public PlayerMove() : base(StateConst.STATE_PLAYER_MOVE)
        {
        }

        public override void Enter(Hero entity)
        {
           //throw new System.NotImplementedException();       
        }

        public override void Execute(Hero entity)
        {
            throw new System.NotImplementedException();
            Log.Print("{0} 移动到 {1}", entity.GetID(), LocationConst.LOCATION_WUDANGSHAN);
        }

        public override void Exit(Hero entity)
        {
            //throw new System.NotImplementedException();
        }
    }
}