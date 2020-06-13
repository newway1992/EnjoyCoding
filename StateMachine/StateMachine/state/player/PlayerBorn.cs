namespace StateMachine
{
    class PlayerBorn : State<Hero>
    {
        private static PlayerBorn instance = new PlayerBorn();
        public static PlayerBorn Instance()
        {
            return instance;
        }

        public PlayerBorn() : base(StateConst.STATE_PLAYER_BORN)
        {
        }

        public override void Enter(Hero entity)
        {
            //throw new System.NotImplementedException();
            Log.Print(entity.Desc());
        }

        public override void Execute(Hero entity)
        {
            //throw new System.NotImplementedException();
            //Log.Print(entity.Desc());
        }

        public override void Exit(Hero entity)
        {
            //throw new System.NotImplementedException();
        }
    }
}