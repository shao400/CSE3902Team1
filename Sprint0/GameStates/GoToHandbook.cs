using Sprint0.Interfaces;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Sprint0.xml;
using Microsoft.Xna.Framework.Content;
using Sprint0.HUDs;
using Sprint0.UtilityClass;

namespace Sprint0.GameStates
{
    class GoToHandbook : IGameState
    {
        Game1 myGame;
        SpriteBatch myBatch;
        roomProperties myCurrentRoom;
        Rectangle roomDestRec = new Rectangle(0, IntegerHolder.OneSixEight, IntegerHolder.SevenSixEight, IntegerHolder.FiveTwoEight);
        Rectangle handbookDestRec = new Rectangle(0, -IntegerHolder.FiveTwoEight, IntegerHolder.SevenSixEight, IntegerHolder.FiveTwoEight);
        Rectangle roomSourceRec;
        Rectangle handbookSourceRec = new Rectangle(0, 0, 797, 536);
        int frame = 0;
        ContentManager myContent;

        private Hud myHud;
        int x = 0;
        int y = 0;


        public GoToHandbook(Game1 game, SpriteBatch batch, ContentManager Content, Hud hud1)
        {
            myGame = game;
            myCurrentRoom = game.currentRoom;
            roomSourceRec = myCurrentRoom.sourceRec;
            myBatch = batch;
            myContent = Content;
            myHud = hud1;

        }
        public void loadNextRoom(int nextRoom)
        {
            // nothing
        }

        public void Draw()
        {
            myBatch.Begin();
            myBatch.Draw(myContent.Load<Texture2D>(StringHolder.Dungeon), roomDestRec, roomSourceRec, Color.White);
            myBatch.Draw(myContent.Load<Texture2D>(StringHolder.Handbook), handbookDestRec, handbookSourceRec, Color.White);
            myBatch.End();
            myHud.Draw(x, y);

        }

        public void Update() 
        {                       
                frame++;
                if (frame < 89)
                {
                    roomDestRec.Y += IntegerHolder.Six;
                    handbookDestRec.Y += IntegerHolder.Six;
                    y += IntegerHolder.Six;

                }
                else
                {
                    myGame.currentState = myGame.stateList[11];
                    frame = 0;
                    y = 0;

                    roomDestRec = new Rectangle(0, IntegerHolder.OneSixEight, IntegerHolder.SevenSixEight, IntegerHolder.FiveTwoEight);
                    handbookDestRec = new Rectangle(0, -IntegerHolder.FiveTwoEight, IntegerHolder.SevenSixEight, IntegerHolder.FiveTwoEight);
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