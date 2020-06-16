using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Sprint0.Sprite;
using Sprint0.Interfaces;

namespace Sprint0.Enemies
{
    public class Moblin : IEnemy
    {


        private static ISprite MoblinSprite;
        private int xPosition;
        private int yPosition;
        private int width;
        private int height;
        private Rectangle destinationRectangle;

        public Moblin(int x, int y, int height_e, int width_e)
        {
            
            xPosition = x;
            yPosition = y;
            width = width_e;
            height = height_e;
            MoblinSprite = new EnemyMoblinSprite(x, y);
            destinationRectangle = new Rectangle(x, y, 64, 64);
        }



        public void Draw()
        {
            Vector2 location = new Vector2(xPosition,yPosition);
            MoblinSprite.Draw(location, false);
        }

        public void Update()
        {
            MoblinSprite.Update();
        }

        public Rectangle GetRectangle()
        {
            return new Rectangle(xPosition, yPosition, width, height);
        }
    }
}