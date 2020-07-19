using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Sprint0.Controller;
using Sprint0.Interfaces;
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
        public int currentItem = 0;


        public Inventory(Player1 link)
        {
            myLink = link;
        }

        public void addItem(IItem item)
        {
            // add gotten items into list
            myItemList.Add(item);
            Console.WriteLine("obtain new item: " + item.GetType());
            Console.WriteLine("current have " + myItemList.Count + " item");
        }

        public void showItem()
        {
            // In pause state, show items, Map, and Compass
            checkRemain();
            for (int i = 0; i < myItemList.Count; i++)
            {
                string itemType = getItemType(myItemList[i]);
                if (itemType.Equals("Sprint0.Items.Bomb") || itemType.Equals("Sprint0.Items.Bow")
                    || itemType.Equals("Sprint0.Items.Boomerang"))
                {
                    itemSprite = getItemSprite(myItemList[i]);
                    if (itemSprite != null)
                    {
                        Vector2 dest = new Vector2(x + i * 50, y);
                        itemSprite.Draw(dest, false);
                    }
                }
            }
            if (myLink.HaveMapOrCompass()[0])
            {
                itemSprite = new ItemMapSprite();
                Vector2 dest = new Vector2(140, 320);
                itemSprite.Draw(dest, false);
            }
            if (myLink.HaveMapOrCompass()[1])
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
                    sprite = new ItemBowSprite();
                    break;
                case "Sprint0.Items.Boomerang":
                    sprite = new ItemBoomerangSprite();
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
            // show picked item and actually equip it on player
            IItem item = myItemList[itemNum];
            ISprite sprite = getItemSprite(item);
            Vector2 dest = new Vector2(210, 120);
            sprite.Draw(dest, false);

            string itemType = getItemType(item);
            switch (itemType)
            {
                case "Sprint0.Items.Bomb":
                    currentItem = 1;
                    break;
                case "Sprint0.Items.Bow":
                    currentItem = 2;
                    break;
                case "Sprint0.Items.Boomerang":
                    currentItem = 3;
                    break;
                default:
                    break;
            }
            Console.WriteLine("current item: " + currentItem);
        }

        public void checkRemain()
        {
            // if item count = 0, move it out from item list
            for (int i = 0; i < myItemList.Count; i++)
            {
                IItem item = myItemList[i];
                string itemType = getItemType(item);
                switch (itemType)
                {
                    case "Sprint0.Items.Bomb":
                        if (myLink.bombCount == 0)
                        {
                            myItemList.RemoveAt(i);
                        }
                        break;
                    /*
                                        case "Sprint0.Items.Arrow":
                                            if (myLink.bombCount == 0)
                                            {
                                                myItemList.RemoveAt(i);
                                            }
                                            break;
                    */
                    default:
                        break;
                }
            }
        }

        public void pickingItem(int moveCount)
        {
            // A / D for picking item, when itemList is not null, equip the picked item
            moveCountTot += moveCount;
            if (moveCountTot < 0)
            {
                moveCountTot = 0;
            }
            if (moveCountTot == myItemList.Count && moveCountTot != 0)
            {
                moveCountTot = myItemList.Count - 1;
            }
            if (myItemList.Count == 0) moveCountTot = 0;
            Vector2 dest = new Vector2(380 + moveCountTot * 50, 105);
            pickboxSprite.Draw(dest, false);

            if (myItemList.Count != 0)
            {
                equipItem(moveCountTot);
            }
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
