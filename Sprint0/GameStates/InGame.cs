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
using Sprint0.HUD;

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
            if (myGame.link.GetCurrentStatus() == "attacking")
            {
                myGame.link.getPlayerItem().Stab();
            }
            else if (myGame.link.GetCurrentStatus() == "arrowShooting")
            {
                myGame.link.getPlayerItem().Shoot();
            }
            else if (myGame.link.GetCurrentStatus() == "booming")
            {
                myGame.link.getPlayerItem().Shoot();
            }
            else if (myGame.link.GetCurrentStatus() == "boomrangShooting")
            {
                myGame.link.getPlayerItem().Shoot();
            }

            else if (myGame.link.getPlayerItem().IsExplode() == 0)
            {
                myGame.link.getPlayerItem().Shoot();
            }
            else if (myGame.link.getPlayerItem().IsExplode() == 1)
            {
                myGame.link.getPlayerItem().Explode();
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
