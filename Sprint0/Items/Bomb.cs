﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using Microsoft.Xna.Framework;
using Sprint0.Interfaces;
using Sprint0.Sprite;

namespace Sprint0.Items
{
    class Bomb : IItem
    {
        private ItemBombSprite sprite = SpriteFactory.ItemBomb;
        private int xAix;
        private int yAix;
        private bool picked;
        private int price;
        //private int width;
        //private int height;
        public Bomb(int x, int y)
        {
            xAix = x;
            yAix = y;
            picked = false;
            price = 5;
            //width = w;
            //height = h;
        }
        public void Draw()
        {
            Vector2 location = new Vector2(xAix, yAix);
            if (picked == false)
            {
                sprite.Draw(location, false);
            }
            
        }
        public void PickedUp()
        {
            picked = true;
        }

        public Boolean isPickedUp()
        {
            return picked;
        }

        public void ItemReset()
        {
            picked = false;
        }

        

        public void Update()
        {
            //currently, does not need update
        }


        public Rectangle GetRectangle()
        {
            return new Rectangle(xAix, yAix, 32, 32);
        }
        public int getPrice()
        {
            return price;
        }
    }
}



