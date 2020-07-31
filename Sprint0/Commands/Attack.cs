using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sprint0.UtilityClass;

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
            if (myGame.currentState == myGame.stateList[IntegerHolder.Four])
            {
                myGame.link.myInventory.pickingItem(-1);
            }
            else if (myGame.currentState == myGame.stateList[IntegerHolder.Eight])
            {
                myGame.link.myStock.buyItem();
            }
            else
            {
                myGame.link.Attack();
            }
        }
    }
}
