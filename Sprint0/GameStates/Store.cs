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
using Sprint0.HUDs;
using Sprint0.UtilityClass;
using Sprint0.Items;
using Sprint0.Player;

namespace Sprint0.GameStates
{
    class Store : IGameState
    {
        Game1 myGame;
        Player1 myLink;
        SpriteBatch myBatch;
        Rectangle storeDestRec = new Rectangle(0, 0, 768, 528);
        Rectangle storeSourceRec = new Rectangle(0, 0, 768, 529);
        ISprite pickboxSprite = new PickBoxSprite();
        ContentManager myContent;
        Inventory myInventory;
        ISprite itemSprite, itemInfoSprite;
        public List<IItem> storeList = new List<IItem>();
        private Bomb bomb = new Bomb(0, 0);
        private HeartContainer heartC = new HeartContainer(0, 0);
        public int moveCountTot = 0;
        public int currentItem = 0;
        int x = 390;
        int y = 110;

        public Store(Game1 game, SpriteBatch batch, ContentManager Content)
        {
            myGame = game;
            myLink = game.link;
            myBatch = batch;
            myContent = Content;
            myInventory = myGame.link.myInventory;
            storeList.Add(bomb);
            storeList.Add(heartC);
        }
        public void Draw()
        {
            myBatch.Begin();
            myBatch.Draw(myContent.Load<Texture2D>(StringHolder.Store), storeDestRec, storeSourceRec, Color.White); ;
            myBatch.End();
            showItem();
            pickingItem(0);
        }
        public void showItem()
        {
            for (int i = 0; i < storeList.Count; i++)
            {
                string itemType = myInventory.getItemType(storeList[i]);
                itemSprite = myInventory.getItemSprite(storeList[i]);
                if (itemSprite != null)
                {
                    Vector2 dest = new Vector2(x + i * 50, y);
                    itemSprite.Draw(dest, false);
                }                
            }
        }
        public void pickingItem(int moveCount)
        {
            // Use Z & N to pick item
            moveCountTot += moveCount;
            if (moveCountTot < 0)
            {
                moveCountTot = 0;
            }
            if (moveCountTot == storeList.Count && moveCountTot != 0)
            {
                moveCountTot = storeList.Count - 1;
            }
            if (storeList.Count == 0) moveCountTot = 0;
            Vector2 dest = new Vector2(380 + moveCountTot * 50, 105);
            pickboxSprite.Draw(dest, false);

            //TODO show item's info
        }

        public void buyItem()
        {
            // use 1 to buy item
            // add purchase sound
            IItem selectedItem = storeList[moveCountTot];
            myInventory.addItem(selectedItem);
            myLink.ruppyCount -= selectedItem.getPrice();

        }

        public void loadNextRoom(int nextRoom)
        {
            // nothing
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