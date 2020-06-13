using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            Hero hero = new Hero();
            hero.ChangeState(new PlayerMove());
            System.Console.ReadKey();
        }
    }
}
