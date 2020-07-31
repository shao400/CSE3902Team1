using Sprint0.Interfaces;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Sprint0.xml;
using Microsoft.Xna.Framework.Content;
using Sprint0.HUDs;
using Sprint0.UtilityClass;

namespace Sprint0.GameStates
{
    class GoToPause : IGameState
    {
        Game1 myGame;
        SpriteBatch myBatch;
        roomProperties myCurrentRoom;
        Rectangle roomDestRec = new Rectangle(0, IntegerHolder.OneSixEight, IntegerHolder.SevenSixEight, IntegerHolder.FiveTwoEight);
        Rectangle pauseDestRec = new Rectangle(0, -IntegerHolder.FiveTwoEight, IntegerHolder.SevenSixEight, IntegerHolder.FiveTwoEight);
        Rectangle roomSourceRec;
        Rectangle pauseSourceRec = new Rectangle(0, 0, 491, 325);
        int frame = 0;
        ContentManager myContent;
        private HudMap map;
        private Hud myHud;
        int x = 0;
        int y = 0;
        int mapx = 450;
        int mapy = 450-IntegerHolder.FiveTwoEight;

        public GoToPause(Game1 game, SpriteBatch batch, ContentManager Content, Hud hud1)
        {
            myGame = game;
            myCurrentRoom = game.currentRoom;
            roomSourceRec = myCurrentRoom.sourceRec;
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
            myBatch.Draw(myContent.Load<Texture2D>(StringHolder.Dungeon), roomDestRec, roomSourceRec, Color.White);
            myBatch.Draw(myContent.Load<Texture2D>(StringHolder.Pause), pauseDestRec, pauseSourceRec, Color.White);
            myBatch.End();
            myHud.Draw(x, y);
            map.Draw(mapx, mapy);
        }

        public void Update() 
        {                       
                frame++;
                if (frame < 89)
                {
                    roomDestRec.Y += IntegerHolder.Six;
                    pauseDestRec.Y += IntegerHolder.Six;
                    y += IntegerHolder.Six;
                    mapy += IntegerHolder.Six;
                }
                else
                {
                    myGame.currentState = myGame.stateList[IntegerHolder.Four];
                    frame = 0;
                    y = 0;
                    mapy = 450 - IntegerHolder.FiveTwoEight;
                    roomDestRec = new Rectangle(0, IntegerHolder.OneSixEight, IntegerHolder.SevenSixEight, IntegerHolder.FiveTwoEight);
                    pauseDestRec = new Rectangle(0, -IntegerHolder.FiveTwoEight, IntegerHolder.SevenSixEight, IntegerHolder.FiveTwoEight);
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