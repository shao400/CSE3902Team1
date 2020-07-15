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
        private List<IItem> myItemList;
        private ISprite itemSprite;
        Rectangle PickingSourceRec;
        Rectangle PickingDestRec;
        Rectangle itemRec;
        IItem selectedItem;
        int x;
        int y;
        int frame;


        public Inventory(Player1 link, Game1 mygame)
        {
            myLink = link;
            myItemList = new List<IItem>();
            x = 500;
            y = 500;
            frame = 0;
            PickingSourceRec = new Rectangle(519, 137, 16, 16);
            myBatch = mygame.spriteBatch;
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
                string itemType = myItemList[i].GetType().ToString();
                switch (itemType)
                {
                    case "Sprint0.Items.Key":
                        itemSprite = new ItemKeySprite();
                        Console.WriteLine("it's on! ");
                        pickingItem(0);
                        break;
                    case "Sprint0.Items.Bomb":
                        itemSprite = new ItemKeySprite();
                        break;
                    default:
                        break;
                }
                Vector2 dest = new Vector2(x + i * 16, y);
                itemSprite.Draw(dest, false);
            }
        }

        public void equipItem()

        {
            
            //add picked item sprite in “B box”, also show it in game HUD

        }

        public IItem pickingItem(int moveCount)
        {
            // when click A&D key(<-& ->), move PickingDestRec, and list[i], i+ or -
            // when click enter, call equipItem(), make int selected = list[i]; 
            PickingDestRec = new Rectangle(300 + moveCount * 16, 300, 16, 16);
            myBatch.Begin();
            myBatch.Draw(myContent.Load<Texture2D>("Hud"), PickingDestRec, PickingSourceRec, Color.White);
            myBatch.End();
            selectedItem = myItemList[moveCount];
            return selectedItem;
        }

        public void Update()
        {
            frame++;
            if (frame == 0)
            {
                PickingSourceRec = new Rectangle(519, 137, 16, 16);//red box
            }
            else if (frame == 3)
            {
                PickingSourceRec = new Rectangle(5, 15, 1, 1); // drak
            }
            else
            {
                PickingSourceRec = new Rectangle(536, 137, 16, 16); //blue box
                frame = 0;
            }
        }


    }
}
