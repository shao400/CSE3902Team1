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
    class Transitioning : IGameState
    {
        Game1 myGame;
        SpriteBatch myBatch;
        roomProperties myCurrentRoom;
        int myNextRoom;
        Rectangle DestRec = new Rectangle(0, 168, 768, 528);
        Rectangle currentSourceRec;
        int frame = 0;
        ContentManager myContent;

        public Transitioning(Game1 game, SpriteBatch batch, ContentManager Content)
        {
            myGame = game;
            myCurrentRoom = game.currentRoom;
            currentSourceRec = myCurrentRoom.sourceRec;
            myBatch = batch;
            myContent = Content;
        }

        public void loadNextRoom(int nextRoom)
        {
            myNextRoom = nextRoom;
        }

        public void Draw()
        {
            myBatch.Begin();
            myBatch.Draw(myContent.Load<Texture2D>("dungeon"), DestRec, currentSourceRec, Color.White);
            myBatch.End();
        }

        public void Update()
        {
            frame++;
            if (frame >= 33)
            {
                myGame.currentRoom = myGame.roomList[myNextRoom];
                myGame.currentState = myGame.stateList[0];
                frame = 0;
                currentSourceRec = myGame.currentRoom.sourceRec;
                myCurrentRoom = myGame.currentRoom;
            }
            else {
                switch (myCurrentRoom.Connectors.IndexOf(myNextRoom))
                {
                    case 0:
                        if (frame % 2 == 0)
                        {
                            currentSourceRec.Y -= 6;
                        }
                        else
                        {
                            currentSourceRec.Y -= 5;
                        }
                        break;
                    case 1:
                        if (frame % 2 == 0)
                        {
                            currentSourceRec.Y += 6;
                        }
                        else
                        {
                            currentSourceRec.Y += 5;
                        }
                        break;
                    case 2:
                        currentSourceRec.X -= 8;
                        break;
                    case 3:
                        currentSourceRec.X += 8;
                        break;
                }
            }
        }
    }
}
