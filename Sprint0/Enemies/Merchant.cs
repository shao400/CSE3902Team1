﻿using Microsoft.Xna.Framework;
using Sprint0.Sprite;
using Sprint0.Interfaces;

namespace Sprint0.Enemies
{
    public class Merchant : IEnemy
    {


        private static ISprite MerchantSprite;
        private int xPosition;
        private int yPosition;
        private Rectangle destinationRec;

        public Merchant(int x, int y)
        {

            xPosition = x;
            yPosition = y;
            MerchantSprite = new EnemyMerchantSprite(x, y);
            destinationRec = new Rectangle(x, y, 45, 45);
        }



        public void Draw()
        {
            Vector2 location = new Vector2(xPosition, yPosition);
            MerchantSprite.Draw(location, false);
        }

        public void Update()
        {

        }

        public Rectangle GetRectangle()
        {
            return destinationRec;
        }
    }
}