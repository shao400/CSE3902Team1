using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sprint0.Sprite;

namespace Sprint0.Commands
{
    class pPrevEnemy : ICommand
    {
        private Game1 myGame;

        public pPrevEnemy(Game1 game)
        {
            myGame = game;
        }
        public void Execute()
        {
            //myGame.enemyCount--;
            //if (myGame.enemyCount < 0) myGame.enemyCount = SpriteFactory.EnemyList.Count - 1;
            //myGame.enemy = SpriteFactory.EnemyList[myGame.enemyCount];
        }
    }
}
