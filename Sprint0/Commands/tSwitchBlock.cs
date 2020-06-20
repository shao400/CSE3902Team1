using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sprint0.Sprite;

namespace Sprint0.Commands
{
    class ySwitchBlock : ICommand
    {
        private Game1 myGame;

        public ySwitchBlock(Game1 game)
        {
            myGame = game;
        }

        public void Execute()
        {
            myGame.blockCount++;
            if (myGame.blockCount >= SpriteFactory.BlockList.Count) myGame.blockCount = 0;
            //myGame.block = SpriteFactory.BlockList[myGame.blockCount];
        }

    }
}
