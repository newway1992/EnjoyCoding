namespace StateMachine
{
    class PlayerBorn : State<Hero>
    {
        private static PlayerBorn instance = new PlayerBorn();
        private int index = 0;
        private string[] contents =
        {
            "四年寒窗苦读，终于大学毕业了！为了用所学知识报效祖国，我参加了公务员考试...",
            "考试结果:",
            "《行政职业能力测验》（A） 80",
            "《申论》 83",
        };
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
            if(index >= contents.Length)
            {
                return;
            }
            if(index < contents.Length)
            {
                Log.Print(contents[index]);
                index++;
                if(index == contents.Length)
                {
                    MsgDispatcher.GetInstance().DispatchMessage(0, EntityDef.MAIN_HERO, EntityDef.GLOBAL, MsgDef.MSG_CANJIAKAOSHI);
                }
            }
        }

        public override void Exit(Hero entity)
        {
            //throw new System.NotImplementedException();
        }
    }
}