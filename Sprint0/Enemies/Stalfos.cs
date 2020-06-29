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
    public class Stalfos : IEnemy
    {


        private static ISprite StalfosSprite;
        private int xPosition;
        private int yPosition;
        private int frame = 0;
        bool backmove = false;
        private Rectangle destinationRec;

        public Stalfos(int x, int y)
        {

            xPosition = x;
            yPosition = y;
            StalfosSprite = new EnemyStalfosSprite(x, y);
            destinationRec = new Rectangle(x, y, 45, 45);
        }



        public void Draw()
        {
            Vector2 location = new Vector2(xPosition, yPosition);
            StalfosSprite.Draw(location, false);
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