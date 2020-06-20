using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sprint0.Sprite;

namespace Sprint0.Commands
{
    class iPrevItem : ICommand
    {
        private Game1 myGame;

        public iPrevItem(Game1 game)
        {
            myGame = game;
        }

        public void Execute()
        {
            myGame.itemCount--;
            if (myGame.itemCount < 0) myGame.itemCount = SpriteFactory.ItemList.Count - 1;
            //myGame.item = SpriteFactory.ItemList[myGame.itemCount];
        }

    }
}
