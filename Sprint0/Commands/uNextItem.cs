﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sprint0.Sprite;

namespace Sprint0.Commands
{
    class uNextItem : ICommand
    {
        private Game1 myGame;

        public uNextItem(Game1 game)
        {
            myGame = game;
        }

        public void Execute()
        {
            myGame.itemCount++;
            if (myGame.itemCount >= SpriteFactory.ItemList.Count) myGame.itemCount = 0;
            myGame.item = SpriteFactory.ItemList[myGame.itemCount];
        }

    }
}