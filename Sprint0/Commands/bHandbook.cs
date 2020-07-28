using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sprint0.Inventories;

namespace Sprint0.Commands
{
    class bHandbook : ICommand
    {
        private Game1 myGame;

        public bHandbook(Game1 game)
        {
            myGame = game;
            
        }

        public void Execute()
        {
            if (myGame.currentState == myGame.stateList[7])
                myGame.currentState.NextOption();
        }
    }
}
