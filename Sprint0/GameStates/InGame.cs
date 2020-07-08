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
            Console.WriteLine("ingame drawing");
            myGame.currentRoom.Draw();
            myGame.currentRoom.link.getSprite().Draw(new Vector2(myGame.currentRoom.link.xAxis, myGame.currentRoom.link.yAxis), myGame.currentRoom.link.isTakingDmg());
            if (myGame.currentRoom.link.states.GetCurrentStatus() == "attacking")
            {
                myGame.currentRoom.link.getPlayerItem().Stab(/*new Vector2(myGame.currentRoom.link.xAxis, myGame.currentRoom.link.yAxis), false*/);
            }
            else if (myGame.currentRoom.link.states.GetCurrentStatus() == "shooting")
            {
                myGame.currentRoom.link.getPlayerItem().Shoot();
            }
            else if (myGame.currentRoom.link.states.GetCurrentStatus() == "exploding")
            {
                myGame.currentRoom.link.getPlayerItem().Explode();
            }
        }

        public void Update()
        {
            myGame.currentRoom.link.Update();
            myGame.currentRoom.link.BlockCollisionTest(myGame.currentRoom.blockList);
            myGame.currentRoom.link.EnemyCollisionTest(myGame.currentRoom.enemyList);
            myGame.currentRoom.link.ItemCollisionTest(myGame.currentRoom.itemList);
            myGame.currentRoom.Update();
        }
        public void loadNextRoom(int nextRoom)
        {
            
        }
    }
}
