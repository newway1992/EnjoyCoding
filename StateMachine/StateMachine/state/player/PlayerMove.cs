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
            Log.Print(entity.Desc());
        }

        public override void Execute(Hero entity)
        {
          
        }

        public override void Exit(Hero entity)
        {
            //throw new System.NotImplementedException();
        }
    }
}