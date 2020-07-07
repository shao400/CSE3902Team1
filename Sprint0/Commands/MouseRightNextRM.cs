using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sprint0.Sprite;
using Sprint0.Interfaces;

namespace Sprint0.Commands
{
    class MouseRightNextRM : ICommand
    {
        private Game1 myGame;

        public MouseRightNextRM(Game1 game)
        {
            myGame = game;
        }

        public void Execute()
        {

            if (myGame.currentRoom.roomID < 2)
            {
                myGame.currentState = myGame.stateList[1];
                myGame.currentState.loadNextRoom(myGame.currentRoom.roomID + 1);
            }

            /*            if (myGame.roomCount != 2)
                        {
                            myGame.roomCount++;
                            myGame.currentRoom = myGame.roomList[myGame.roomCount];
                        }*/
        }

    }
}
