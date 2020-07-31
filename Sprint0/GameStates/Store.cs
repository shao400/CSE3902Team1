using Sprint0.Interfaces;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Content;
using Sprint0.HUDs;
using Sprint0.UtilityClass;
using Sprint0.Inventories;

namespace Sprint0.GameStates
{
    class Store : IGameState
    {
        Game1 myGame;
        SpriteBatch myBatch;     
        Rectangle storeDestRec = new Rectangle(0, IntegerHolder.OneSixEight, IntegerHolder.SevenSixEight, IntegerHolder.FiveTwoEight);
        Rectangle storeSourceRec = new Rectangle(0, 0, IntegerHolder.SevenSixEight, 529);
        ContentManager myContent;
        StoreStock myStock;
        private Hud myHud;

        public Store(Game1 game, SpriteBatch batch, ContentManager Content, Hud hud1)
        {
            myGame = game;
            myBatch = batch;
            myContent = Content;
            myHud = hud1;
            myStock = game.link.myStock;
        }
        public void Draw()
        {
            myBatch.Begin();
            myBatch.Draw(myContent.Load<Texture2D>(StringHolder.Store), storeDestRec, storeSourceRec, Color.White); ;
            myBatch.End();
            myHud.Draw(0,0);
            myStock.showItem();
            myStock.pickingItem(0);
        }
        
        public void loadNextRoom(int nextRoom)
        {

        }

        public void Update() 
        {                       
                          
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