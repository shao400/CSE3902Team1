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

namespace Sprint0.GameStates
{
    class InGame : IGameState
    {
        Game1 myGame;
        //GraphicsDeviceManager myGraphics;
        public InGame(Game1 game)
        {
            myGame = game;
        }
        public void Draw()
        {
            myGame.currentRoom.Draw();
            myGame.link.getSprite().Draw(new Vector2(myGame.link.xAxis, myGame.link.yAxis), myGame.link.isTakingDmg());
            if (myGame.link.GetCurrentStatus() == "attacking")
            {
                myGame.link.getPlayerItem().Stab();
            }
            else if (myGame.link.GetCurrentStatus() == "shooting")
            {
                myGame.link.getPlayerItem().Shoot();
            }
            else if (myGame.link.GetCurrentStatus() == "exploding")
            {
                myGame.link.getPlayerItem().Explode();
            }
        }

        public void Update()
        {
            myGame.link.Update();
            myGame.link.BlockCollisionTest(myGame.currentRoom.blockList);
            myGame.link.ProjectileCollisionTest(myGame.currentRoom.blockList);
            myGame.link.EnemyCollisionTest(myGame.currentRoom.enemyList);
            myGame.link.ItemCollisionTest(myGame.currentRoom.itemList);
            myGame.currentRoom.Update();
        }
        public void loadNextRoom(int nextRoom)
        {
            
        }
    }
}
