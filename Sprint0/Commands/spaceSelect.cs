using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sprint0.Sprite;

namespace Sprint0.Commands
{
    class spaceSelect : ICommand
    {
        private Game1 myGame;

        public spaceSelect(Game1 game)
        {
            myGame = game;
        }

        public void Execute()
        {
            if (myGame.currentState == myGame.stateList[7])
            {
                myGame.currentState.Select();
            }
        }

    }
}
