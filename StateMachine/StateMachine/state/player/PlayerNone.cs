namespace StateMachine
{
    class PlayerNone : State<Hero>
    {
        private static PlayerNone instance = new PlayerNone();
        public static PlayerNone Instance()
        {
            return instance;
        }
        public PlayerNone() : base(StateConst.STATE_PLAYER_NONE)
        {
        }

        public override void Enter(Hero entity)
        {
        }

        public override void Execute(Hero entity)
        {
            StateMachine<Hero> fsm = entity.GetFSM();
            if (fsm == null)
            {
                return;
            }
            if(string.IsNullOrEmpty(entity.Name))
            {
                return;
            }
            fsm.ChangeState(PlayerBorn.Instance());
        }

        public override void Exit(Hero entity)
        {
        }
    }
}