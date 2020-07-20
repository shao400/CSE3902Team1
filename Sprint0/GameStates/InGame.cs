using Sprint0.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Sprint0.xml;
using Sprint0.HUDs;
using Sprint0.UtilityClass;

namespace Sprint0.GameStates
{
    class InGame : IGameState
    {
        Game1 myGame;
        private Hud myHud;
        int x = 0;
        int y = 0;

        public InGame(Game1 game, Hud hud1)
        {
            myGame = game;
            myHud = hud1;
        }
        public void Draw()
        {
            myGame.currentRoom.Draw();
            myHud.Draw(x, y);
            if (myGame.link.GetCurrentStatus() == StringHolder.Attacking) { myGame.link.getAttacking().Stab(); }
            if (myGame.link.GetCurrentStatus() == StringHolder.ArrowShooting) { myGame.link.getPlayerItem2().Shoot(); }
            if (myGame.link.GetCurrentStatus() == StringHolder.Booming) { myGame.link.getPlayerItem2().Shoot(); }
            if (myGame.link.GetCurrentStatus() == StringHolder.BoomrangShooting) { myGame.link.getPlayerItem2().Shoot(); }

            if (myGame.link.getPlayerItem1().IsExplode() == 0)
            {
                myGame.link.getPlayerItem1().Shoot();
            }
            else if (myGame.link.getPlayerItem1().IsExplode() == 1)
            {
                myGame.link.getPlayerItem1().Explode();
            }
            if (myGame.link.getPlayerItem2().IsExplode() == 0)
            {
                myGame.link.getPlayerItem2().Shoot();
            }
            else if (myGame.link.getPlayerItem2().IsExplode() == 1)
            {
                myGame.link.getPlayerItem2().Explode();
            }
            myGame.link.getSprite().Draw(new Vector2(myGame.link.xAxis, myGame.link.yAxis), myGame.link.isTakingDmg());
            for (int i = 0; i < myGame.currentRoom.DoorList.Count; i++)
            {
                myGame.currentRoom.DoorList[i].Draw();
            }
        }

        public void Update()
        {
            myGame.link.Update();
            myGame.link.BlockCollisionTest(myGame.currentRoom.blockList);
            myGame.link.ProjectileBlocksCollisionTest(myGame.currentRoom.blockList);
            myGame.link.EnemyCollisionTest(myGame.currentRoom.enemyList);
            myGame.link.ProjectileEnemiesCollisionTest(myGame.currentRoom.enemyList);
            myGame.link.ItemCollisionTest(myGame.currentRoom.itemList);
            myGame.currentRoom.Update();
        }
        public void loadNextRoom(int nextRoom)
        {
            
        }
    }
}
