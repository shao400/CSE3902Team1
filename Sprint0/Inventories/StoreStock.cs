using Sprint0.Interfaces;
using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Sprint0.Sprite;
using Sprint0.HUDs;
using Sprint0.UtilityClass;
using Sprint0.Items;
using Sprint0.Player;


namespace Sprint0.Inventories
{
    public class StoreStock
    {
        Player1 myLink;
        Inventory myInventory;
        public List<IItem> storeList = new List<IItem>();
        private Bomb bomb = new Bomb(0, 0);
        private HeartContainer heartC = new HeartContainer(0, 0);
        ISprite pickboxSprite = new PickBoxSprite();
        ISprite itemSprite;

        public int moveCountTot = 0;
        public int currentItem = 0;
        int x = 340;
        int y = 340;

        //donot need that difficult, because item index is fixed

        public StoreStock(Player1 link)
        {
            myLink = link;
            myInventory = link.myInventory;
            storeList.Add(bomb);
            storeList.Add(heartC);

        }
        public void showItem()
        {
            // show items in store interface
            for (int i = 0; i < storeList.Count; i++)
            {               
                itemSprite = getItemSprite(storeList[i]);
                if (itemSprite != null)
                {
                    Vector2 dest = new Vector2(x + i * 50, y);
                    itemSprite.Draw(dest, false);
                }
            }
        }
        public ISprite getItemSprite(IItem item)
        {
            // get item's sprite
            string itemType = item.GetType().ToString();
            ISprite sprite = null;
            switch (itemType)
            {
                case "Sprint0.Items.Bomb":
                    sprite = new ItemBombSprite();
                    break;
                case "Sprint0.Items.HeartContainer":
                    sprite = new ItemHeartContainerSprite();
                    break;
                default:
                    sprite = null;
                    break;
            }
            return sprite;
        }


        public void pickingItem(int moveCount)
        {
            // Use N to pick item
            moveCountTot += moveCount;
            if (moveCountTot > storeList.Count-1)
            {
                moveCountTot = 0;
            }
            Vector2 dest1 = new Vector2(331 + moveCountTot * 54, 335);
            pickboxSprite.Draw(dest1, false);
            Vector2 dest2 = new Vector2(330, 510);
            drawInfo(moveCountTot).Draw(dest2, false);

        }

        public ISprite drawInfo(int index)
        {
            ISprite itemInfoSprite = null;
            switch (index)
            {
                case 0:
                    itemInfoSprite = new BombInfoSprite();
                    break;
                case 1:
                    itemInfoSprite = new HeartCInfoSprite();
                    break;
                default:
                    break;
            }
            return itemInfoSprite;
        }

        public void buyItem()
        {
            // use Z to buy item
            // add purchase sound?
            IItem selectedItem = storeList[moveCountTot];
            if(!(selectedItem.getPrice() > myLink.ruppyCount))
            {
                if (moveCountTot == 0)
                {
                    myLink.bombCount++;
                    myInventory.addItem(bomb);
                }
                else if (moveCountTot == 1)
                {
                    myLink.MaxHealth++;
                }
                myLink.ruppyCount -= selectedItem.getPrice();
            }          

        }
    }
}