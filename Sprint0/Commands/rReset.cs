using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sprint0.Sprite;

namespace Sprint0.Commands
{
    class rReset : ICommand
    {
        private Game1 myGame;

        public rReset(Game1 game)
        {
            myGame = game;
        }

        public void Execute()
        {
            myGame.link.PlayerReset();
            for (int i = 0; i < myGame.currentRoom.itemList.Count;i++)
            {
               myGame.currentRoom.itemList[i].ItemReset();
            }
        }

    }
}
