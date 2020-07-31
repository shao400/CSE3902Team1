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
        int count = 0;

        public bHandbook(Game1 game)
        {
            myGame = game;
            
        }

        public void Execute()
        {

            if (myGame.currentState == myGame.stateList[0]
                || myGame.currentState == myGame.stateList[11]
                || myGame.currentState == myGame.stateList[9])
            {
                if (count == 0)
                {
                    if (myGame.currentState == myGame.stateList[0])
                    {
                        myGame.normalOrNight = 0;
                    }
                    else if (myGame.currentState == myGame.stateList[9])
                    {
                        myGame.normalOrNight = 9;
                    }
                    myGame.currentState = myGame.stateList[12];
                    count++;
                }
                else
                {
                    myGame.currentState = myGame.stateList[13];
                    count = 0;
                }
            }
        }
    }
}
