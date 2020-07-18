using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Sprint0.Block;
using Sprint0.Controller;
using Sprint0.Enemies;
using Sprint0.Interfaces;
using Microsoft.Xna.Framework.Audio;
using Sprint0.Items;
using Sprint0.Player;
using Sprint0.Sprite;
using System.Collections.Generic;
using System.ComponentModel;
using Sprint0.xml;
using System.Xml;
using Microsoft.Xna.Framework.Media;
using Sprint0.GameStates;
using Sprint0.HUD;
using Sprint0.Collisions;
using Sprint0.Sprite;
using System;

namespace Sprint0
{
    public class Inventory
    {
        Game1 myGame;
        SpriteBatch myBatch;
        ContentManager myContent;
        GraphicsDeviceManager graphics;
        private Player1 myLink;
        private List<IItem> myItemList = new List<IItem>();
        //Rectangle PickingSourceRec = new Rectangle(519, 137, 16, 16);
        //Rectangle PickingDestRec = new Rectangle(300 + moveCountTot * 16, 300, 16, 16);
        //IItem selectedItem;
        ISprite itemSprite;
        ISprite pickboxSprite = new PickBoxSprite();
        int x = 390;
        int y = 110;
        int frame = 0;
        static int moveCountTot = 0;


        public Inventory(Player1 link, Game1 game)
        {
            myGame = game;
            myLink = link;
            myBatch = game.spriteBatch;
        }

        public void addItem(IItem item)
        {
            //OK
            // when get an item, call it, add it in list[]
            myItemList.Add(item);
            Console.WriteLine("obtain new item: " + item.GetType());
            Console.WriteLine("current have " + myItemList.Count + " item");
        }

        public void showItem()
        {
            // in pause state, show each item in the List
            for (int i = 0; i < myItemList.Count; i++)
            {
                string itemType = getItemType(myItemList[i]);

                // Draw Item (Bomb, Arrow, Huixuanbiao)
                if(itemType.Equals("Sprint0.Items.Bomb") || itemType.Equals("Sprint0.Items.Bow"))
                {
                    itemSprite = getItemSprite(myItemList[i]);
                    if (itemSprite != null)
                    {
                        Vector2 dest = new Vector2(x + i * 50, y);
                        itemSprite.Draw(dest, false);                     
                    }
                }
            }
            // Draw Map
            if (myGame.link.HaveMapOrCompass()[0])
            {
                itemSprite = new ItemMapSprite();
                Vector2 dest = new Vector2(140, 320);
                itemSprite.Draw(dest, false);
            }
            //Draw Compass
            if (myGame.link.HaveMapOrCompass()[1])
            {
                itemSprite = new ItemCompassSprite();
                Vector2 dest = new Vector2(140, 450);
                itemSprite.Draw(dest, false);
            }
        }

        public string getItemType(IItem item)
        {
            return item.GetType().ToString();
        }

        public ISprite getItemSprite(IItem item)
        {
            string itemType = getItemType(item);
            ISprite sprite = null;
            switch (itemType)
            {
                case "Sprint0.Items.Bomb":
                    sprite = new ItemBombSprite();
                    break;
                case "Sprint0.Items.Bow":
                    sprite = new ItemArrowSprite();
                    break;
                case "Sprint0.Items.Map":
                    sprite = new ItemMapSprite();
                    break;
                case "Sprint0.Items.Compass":
                    sprite = new ItemCompassSprite();
                    break;
                default:
                    sprite = null;
                    break;
            }
            return sprite;
        }


        public void equipItem(int itemNum)
        {
            IItem item = myItemList[itemNum];
            ISprite sprite = getItemSprite(item);
            Vector2 dest = new Vector2(210, 120); // equipment position
            sprite.Draw(dest, false);

            //equipment item (bomb, bow, huixuanbiao)
            // TODO
            // make link actually EQUIP this item

        }

        public void pickingItem(int moveCount)
        {
            // when click A&D key(<-& ->), move PickingDestRec, and list[i], i+ or -
            // when click enter, call equipItem(), make int selected = list[i]; 
            moveCountTot += moveCount;
            if (moveCountTot < 0)
            {
                moveCountTot = 0;
            }
            if (moveCountTot == myItemList.Count)
            {
                moveCountTot = myItemList.Count-1;
            }
            Vector2 dest = new Vector2(380 + moveCountTot * 50, 105);
            pickboxSprite.Draw(dest, false);

            if (myItemList.Count != 0) equipItem(moveCountTot);
            // return the current picked item
            //selectedItem = myItemList[moveCount];
            //equipItem(selectedItem);
        }

        public void Update()
        {
            frame++;
            if (frame == 0)
            {
                //PickingSourceRec = new Rectangle(519, 137, 16, 16);//red box
            }
            else if (frame == 3)
            {
                //PickingSourceRec = new Rectangle(5, 15, 1, 1); // drak
            }
            else
            {
                //PickingSourceRec = new Rectangle(536, 137, 16, 16); //blue box
                frame = 0;
            }
        }


    }
}
