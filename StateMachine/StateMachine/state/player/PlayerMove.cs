namespace StateMachine
{
    class PlayerMove:State
    {

        public PlayerMove() : base(StateConst.STATE_PLAYER_MOVE)
        {
        }

        public override void Enter(BaseGameEntity entity)
        {
            throw new System.NotImplementedException();
            Hero hero = entity as Hero;
          
        }

        public override void Execute(BaseGameEntity entity)
        {
            throw new System.NotImplementedException();
        }

        public override void Exit(BaseGameEntity entity)
        {
            throw new System.NotImplementedException();
        }
    }
}