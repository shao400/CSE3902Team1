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
using System;

namespace Sprint0
{
    public class Inventory
    {
        Game1 myGame;
        SpriteBatch myBatch;
        private List<SoundEffect> sounds;
        private Sound soundEffect;
        private Song intro;
        public Hud myHud;
        GraphicsDeviceManager graphics;
        public Player1 myLink;
        public List<IItem> myItemList = new List<IItem>();
        public ISprite itemSprite;
        public ISprite pickBox; // add sprite for this
        int x = 500; 
        int y = 500;
        //Rectangle itemRec;


        public Inventory(Player1 link)
        {
            myLink = link;
            //itemList = itemlist1;

        }

        public void addItem(IItem item)
        {
            // when get an item, call it, add it in list[]
            myItemList.Add(item);
        }

        public void showItem()
        {
            // in pause state, show each item in the List
            for (int i = 1; i < myItemList.Count; i++)
            {
                //itemRec = itemList[i].GetRectangle();
                Vector2 dest = new Vector2(x + i * 5, y);
                itemSprite = SpriteFactory.ItemList[i - 1];
                itemSprite.Draw(dest, false);
                Console.WriteLine("itemlist length: " + myItemList.Count);
            }
        }

        public void equipItem(IItem item)
        {
            //add picked item sprite in “B box”, also show it in game HUD
        }

        public void pickItem()
        {

            // use A&D key(<-& ->), when click, move selecting box destRec, and list[i], i+ or -
            // when click enter, make int selected = list[i], call equipItem(); 
        }

        public void Update()
        {
            //check currentItem? or no needed
        }


    }
}
