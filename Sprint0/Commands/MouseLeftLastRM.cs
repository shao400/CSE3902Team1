﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sprint0.Sprite;
using Sprint0.UtilityClass;
namespace Sprint0.Commands
{
    class MouseLeftLastRM : ICommand
    {
        private Game1 myGame;

        public MouseLeftLastRM(Game1 game)
        {
            myGame = game;
        }

        public void Execute()
        {
            if (myGame.currentRoom.roomID > 0)
            {
                myGame.currentState = myGame.stateList[1];
                myGame.currentState.loadNextRoom(myGame.currentRoom.roomID - 1);
            }
        }

    }
}
