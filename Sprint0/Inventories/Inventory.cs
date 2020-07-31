using Microsoft.Xna.Framework;
using Sprint0.Interfaces;
using Sprint0.Player;
using Sprint0.Sprite;
using System.Collections.Generic;
using System;
using Sprint0.UtilityClass;

namespace Sprint0.Inventories

{
    public class Inventory
    {
        private Player1 myLink;
        public List<IItem> myItemList = new List<IItem>();
        ISprite itemSprite;
        ISprite pickboxSprite = new PickBoxSprite();
        int x = 390;
        int y = 110;
        public int moveCountTot = 0;
        public int currentItem = 0;

        public Inventory(Player1 link)
        {
            myLink = link;
        }

        public void addItem(IItem item)
        {
            Console.WriteLine(item.GetType());
            if (getItemType(item).Equals("Sprint0.Items.Bomb", StringComparison.CurrentCulture))
            {
                if (myLink.bombCount < 2) myItemList.Add(item);
            }
            else
            {
                myItemList.Add(item);
            }
            Console.WriteLine("obtain new item: " + item.GetType());
            Console.WriteLine("current have " + myItemList.Count + " item");
        }

        public void showItem()
        {
            checkRemain();
            for (int i = 0; i < myItemList.Count; i++)
            {
                string itemType = getItemType(myItemList[i]);
                if (itemType.Equals("Sprint0.Items.Bomb", System.StringComparison.CurrentCulture) || itemType.Equals("Sprint0.Items.Bow", System.StringComparison.CurrentCulture)
                    || itemType.Equals("Sprint0.Items.Boomerang", System.StringComparison.CurrentCulture))
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

        public static string getItemType(IItem item)
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
                    currentItem = IntegerHolder.Three;
                    break;
                default:
                    currentItem = 0;
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
                if(itemType.Equals("Sprint0.Items.Bomb", StringComparison.CurrentCulture)) 
                {            
                        if (myLink.bombCount == 0)
                        {
                            myItemList.RemoveAt(i);
                            currentItem = 0;
                        }
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
        public static void Update()
        {

        }
    }
}
