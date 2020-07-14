using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint0.Commands
{
    class Bomb : ICommand
    {
        private Game1 myGame;

        public Bomb(Game1 game)
        {
            myGame = game;
        }

        public void Execute()
        {
            if(myGame.link.itemCount()[2]>0)myGame.link.Bomb();
        }
    }
}
