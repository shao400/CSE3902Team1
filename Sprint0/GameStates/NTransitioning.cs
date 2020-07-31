using Sprint0.Interfaces;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Sprint0.xml;
using Microsoft.Xna.Framework.Content;
using Sprint0.HUDs;
using Sprint0.UtilityClass;

namespace Sprint0.GameStates
{
    class NTransitioning : IGameState
    {
        Game1 myGame;
        SpriteBatch myBatch;
        roomProperties myNCurrentRoom;
        int myNextNRoom;
        Rectangle DestRec = new Rectangle(0, IntegerHolder.OneSixEight, IntegerHolder.SevenSixEight, IntegerHolder.FiveTwoEight);
        Rectangle currentSourceRec;
        int frame = 0;
        ContentManager myContent;
        private Hud myHud;
        int x = 0;
        int y = 0;

        public NTransitioning(Game1 game, SpriteBatch batch, ContentManager Content, Hud hud1)
        {
            myGame = game;
            myNCurrentRoom = game.NcurrentRoom;
            currentSourceRec = myNCurrentRoom.sourceRec;
            myBatch = batch;
            myContent = Content;
            myHud = hud1;
        }

        public void loadNextRoom(int nextRoom)
        {
            myNextNRoom = nextRoom;
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
                myGame.NcurrentRoom = myGame.NroomList[myNextNRoom];
                myGame.currentState = myGame.stateList[IntegerHolder.Nine];
                frame = 0;
                currentSourceRec = myGame.NcurrentRoom.sourceRec;
                myNCurrentRoom = myGame.NcurrentRoom;
            }
            else {
                switch (myNCurrentRoom.Connectors.IndexOf(myNextNRoom))
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
