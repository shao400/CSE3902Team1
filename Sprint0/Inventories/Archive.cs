using Sprint0.Interfaces;
using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Content;
using Sprint0.Sprite;
using Sprint0.HUDs;
using Sprint0.UtilityClass;
using Sprint0.Items;
using Sprint0.Player;
using Sprint0.Enemies;
using Sprint0.Inventories;


namespace Sprint0.Inventories
{
    public class Archive
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
        int aquaK, DodongoK, GoriyaK, KeeseK, MoblinK, OldmanK, PeahatK = 0;

        //donot need that difficult, because item index is fixed

        public Archive(Player1 link)
        {
            myLink = link;
            myInventory = link.myInventory;
            storeList.Add(bomb);
            storeList.Add(heartC);

        }

        public void showKills(IEnemy enemy)
        {
            String enemyType = enemy.GetType().ToString().Substring(16);
            // if nightmare gamestate, str = substring(31);
            switch (enemyType)
            {
                case ("Aqua"):

                    break;
                default:
                    break;
                
            }
        }

        public void showTime()
        {

        }

        public void showRank()
        {

        }


    }
}