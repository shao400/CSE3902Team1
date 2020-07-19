using Sprint0.Player;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint0.Commands
{
    class D1UseItem : ICommand
    {
        private Game1 myGame;

        public D1UseItem(Game1 game)
        {
            myGame = game;
        }

        public void Execute()
        {
            if (myGame.link.myInventory.currentItem == 1)
            {
                if (myGame.link.itemCount()[2] > 0)
                {
                    myGame.link.Bomb();
                }
            }
            else if (myGame.link.myInventory.currentItem == 2)
            {
                myGame.link.Arrow();
            }
            else if (myGame.link.myInventory.currentItem == 3)
            {
                myGame.link.Boomrang();
            }
        }
    }
}
