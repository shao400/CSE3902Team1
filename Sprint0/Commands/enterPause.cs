using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sprint0.Sprite;

namespace Sprint0.Commands
{
    class enterPause : ICommand
    {
        private Game1 myGame;
        int count = 0;

        public enterPause(Game1 game)
        {
            myGame = game;
        }

        public void Execute()
        {

            if (myGame.currentState == myGame.stateList[8])
            {
                myGame.currentState = myGame.stateList[0];
            }
            else if (myGame.currentState == myGame.stateList[0]
                || myGame.currentState == myGame.stateList[4])
            {
                if (count == 0)
                {
                    myGame.currentState = myGame.stateList[2];
                    count++;
                }
                else
                {
                    myGame.currentState = myGame.stateList[3];
                    count = 0;
                }
            }                       
        }

    }
}
