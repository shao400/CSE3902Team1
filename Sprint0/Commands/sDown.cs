using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint0.Commands
{
    class sDown : ICommand
    {
        private Game1 myGame;

        public sDown(Game1 game)
        {
            myGame = game;
        }

        public void Execute()
        {
            if (myGame.currentState == myGame.stateList[7])
            {
                myGame.currentState.NextOption();
            }else 
            myGame.link.Down();
        }

    }
}
