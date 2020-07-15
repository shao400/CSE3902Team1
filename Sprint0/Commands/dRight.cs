using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint0.Commands
{
    class dRight : ICommand
    {
        private Game1 myGame;

        public dRight(Game1 game)
        {
            myGame = game;
        }

        public void Execute()
        {
            if (myGame.currentState == myGame.stateList[3])
            {
                myGame.link.myInventory.pickingItem(1);
            }
            else
            {
                myGame.link.Right();
            }
        }

    }
}
