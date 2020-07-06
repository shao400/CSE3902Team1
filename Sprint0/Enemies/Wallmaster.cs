﻿using Microsoft.Xna.Framework;
using Sprint0.Sprite;
using Sprint0.Interfaces;

namespace Sprint0.Enemies
{
    public class Wallmaster : IEnemy
    {


        private static ISprite WallmasterSprite;
        private int xPosition;
        private int yPosition;
        private Rectangle destinationRec;

        public Wallmaster(int x, int y)
        {
            xPosition = x;
            yPosition = y;
            WallmasterSprite = new EnemyWallmasterSprite(x, y);
            destinationRec = new Rectangle(x, y, 45, 45);
        }

        public void Draw()
        {
            Vector2 location = new Vector2(xPosition, yPosition);
            WallmasterSprite.Draw(location, false);
        }

        public void Update()
        {
            WallmasterSprite.Update();
        }

        public Rectangle GetRectangle()
        {
            return destinationRec;
        }
    }
}