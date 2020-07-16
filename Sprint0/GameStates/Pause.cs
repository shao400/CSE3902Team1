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
using Microsoft.Xna.Framework.Content;
using Sprint0.Sprite;
using System.Windows;
using Sprint0.HUD;

namespace Sprint0.GameStates
{
    class Pause : IGameState
    {
        Game1 myGame;
        SpriteBatch myBatch;
        roomProperties myCurrentRoom;
        Rectangle pauseDestRec = new Rectangle(0, 0, 768, 528);
        Rectangle pauseSourceRec = new Rectangle(0, 0, 491, 325);
        ContentManager myContent;
        private HudMap map;
        private Hud myHud;
        int x = 0;
        int y = 528;

        public Pause(Game1 game, SpriteBatch batch, ContentManager Content, Hud hud1)
        {
            myGame = game;
            myCurrentRoom = game.currentRoom;
            myBatch = batch;
            myContent = Content;
            myHud = hud1;
            map = hud1.map;
        }
        public void loadNextRoom(int nextRoom)
        {
            // nothing
        }

        public void Draw()
        {
            myBatch.Begin();       
            myBatch.Draw(myContent.Load<Texture2D>("pause"), pauseDestRec, pauseSourceRec, Color.White);
            myBatch.End();
            myHud.Draw(x, y);
            map.Draw(450, 450);
            myGame.link.myInventory.showItem();

        }

        public void Update() 
        {                       
                          
        }

    }
}