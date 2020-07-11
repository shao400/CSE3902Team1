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


namespace Sprint0.GameStates
{
    class BackToGame : IGameState
    {
        Game1 myGame;
        SpriteBatch myBatch;
        roomProperties myCurrentRoom;
        Rectangle roomDestRec = new Rectangle(0, -528, 768, 528);
        Rectangle pauseDestRec = new Rectangle(0, 168, 768, 528);
        Rectangle roomSourceRec;
        Rectangle pauseSourceRec = new Rectangle(0, 0, 491, 325);
        int frame = 0;
        ContentManager myContent;

        public BackToGame(Game1 game, SpriteBatch batch, ContentManager Content)
        {
            myGame = game;
            myCurrentRoom = game.currentRoom;
            roomSourceRec = myCurrentRoom.sourceRec;
            myBatch = batch;
            myContent = Content;
        }
        public void loadNextRoom(int nextRoom)
        {
            // nothing
        }

        public void Draw()
        {
            myBatch.Begin();
            myBatch.Draw(myContent.Load<Texture2D>("dungeon"), roomDestRec, roomSourceRec, Color.White);
            myBatch.Draw(myContent.Load<Texture2D>("pause"), pauseDestRec, pauseSourceRec, Color.White);
            myBatch.End();      
            
        }

        public void Update() 
        {                       
            frame++;
                if (frame < 128)
                {
                    roomDestRec.Y -= 6;
                    pauseDestRec.Y -= 6;
                }
            
        }

    }
}