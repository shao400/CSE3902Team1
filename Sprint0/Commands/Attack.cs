using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint0.Commands
{
    class Attack : ICommand
    {
        private Game1 myGame;

        public Attack(Game1 game)
        {
            myGame = game;
        }

        public void Execute()

        {
            if (myGame.currentState == myGame.stateList[4])
            {
                myGame.link.myInventory.pickingItem(-1);
            }
            else if (myGame.currentState == myGame.stateList[8])
            {
                myGame.link.myStock.pickingItem(-1);
            }
            else
            {
                myGame.link.Attack();
            }
        }
    }
}
