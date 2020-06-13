namespace StateMachine
{
    class PlayerBorn : State<Hero>
    {

        public PlayerBorn() : base(StateConst.STATE_PLAYER_BORN)
        {
        }

        public override void Enter(Hero entity)
        {
            //throw new System.NotImplementedException();
        }

        public override void Execute(Hero entity)
        {
            //throw new System.NotImplementedException();
            Log.Print("{0} 出生", entity.GetID());
        }

        public override void Exit(Hero entity)
        {
            //throw new System.NotImplementedException();
        }
    }
}