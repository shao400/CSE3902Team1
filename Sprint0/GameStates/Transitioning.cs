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
using Sprint0.HUDs;
using Sprint0.UtilityClass;

namespace Sprint0.GameStates
{
    class Transitioning : IGameState
    {
        Game1 myGame;
        SpriteBatch myBatch;
        roomProperties myCurrentRoom;
        int myNextRoom;
        Rectangle DestRec = new Rectangle(0, IntegerHolder.OneSixEight, IntegerHolder.SevenSixEight, IntegerHolder.FiveTwoEight);
        Rectangle currentSourceRec;
        int frame = 0;
        ContentManager myContent;
        private Hud myHud;
        int x = 0;
        int y = 0;

        public Transitioning(Game1 game, SpriteBatch batch, ContentManager Content, Hud hud1)
        {
            myGame = game;
            myCurrentRoom = game.currentRoom;
            currentSourceRec = myCurrentRoom.sourceRec;
            myBatch = batch;
            myContent = Content;
            myHud = hud1;
        }

        public void loadNextRoom(int nextRoom)
        {
            myNextRoom = nextRoom;
        }

        public void Draw()
        {
            myBatch.Begin();
            myBatch.Draw(myContent.Load<Texture2D>(StringHolder.Dungeon), DestRec, currentSourceRec, Color.White);
            myBatch.End();
            myHud.Draw(x, y);
        }

        public void Update()
        {
            frame++;
            if (frame >= IntegerHolder.ThirtyThree)
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
                            currentSourceRec.Y -= IntegerHolder.Six;
                        }
                        else
                        {
                            currentSourceRec.Y -= IntegerHolder.Five;
                        }
                        break;
                    case 1:
                        if (frame % 2 == 0)
                        {
                            currentSourceRec.Y += IntegerHolder.Six;
                        }
                        else
                        {
                            currentSourceRec.Y += IntegerHolder.Five;
                        }
                        break;
                    case 2:
                        currentSourceRec.X -= IntegerHolder.Eight;
                        break;
                    case IntegerHolder.Three:
                        currentSourceRec.X += IntegerHolder.Eight;
                        break;
                }
            }
        }

        public void NextOption()
        {

        }
        public void LastOption()
        {

        }

        public void Select()
        {

        }
    }
}
