using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sprint0.Sprite;

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
            if (myGame.roomCount != 2)
            {
                myGame.roomCount++;
                myGame.currentRoom = myGame.roomList[myGame.roomCount];
            }
        }

    }
}
