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

namespace Sprint0.GameStates
{
    class Win : IGameState
    {
        Game1 myGame;
        SpriteBatch myBatch;
        //roomProperties myCurrentRoom;
        //int myNextRoom;
        Rectangle DestRec = new Rectangle(0, 0, 768, 708);
        Rectangle SourceRec = new Rectangle(0, 0, 509, 347);
        //Rectangle currentSourceRec;
        //int frame = 0;
        ContentManager myContent;

        public Win(Game1 game, SpriteBatch batch, ContentManager Content)
        {
            //myGame = game;
            //myCurrentRoom = game.currentRoom;
            //currentSourceRec = myCurrentRoom.sourceRec;
            myBatch = batch;
            myContent = Content;
        }

        public void loadNextRoom(int nextRoom)
        {

        }

        public void Draw()
        {
            myBatch.Begin();
            myBatch.Draw(myContent.Load<Texture2D>("winning"), DestRec, SourceRec, Color.White);
            myBatch.End();
        }

        public void Update()
        {

        }
    }
}
