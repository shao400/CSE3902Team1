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
    public class Tektite : IEnemy
    {


        private static ISprite TektiteSprite;
        private int xPosition;
        private int yPosition;
        private int frame = 0;
        bool backmove = false;
        private Rectangle destinationRec;

        public Tektite(int x, int y)
        {
            xPosition = x;
            yPosition = y;
            TektiteSprite = new EnemyTektiteSprite(x, y);
            destinationRec = new Rectangle(x, y, 64, 64);
        }



        public void Draw()
        {
            Vector2 location = new Vector2(xPosition, yPosition);
            TektiteSprite.Draw(location, false);
        }

        public void Update()
        {

            frame++;
            if (frame >= 20) frame = 0;
            if (frame < 10 && !backmove)
            {
                destinationRec.Y += 5;
            }
            else if (frame > 10 && !backmove)
            {
                destinationRec.Y += 5;
            }
            else if (frame < 10 && backmove)
            {
                destinationRec.Y -= 5;
            }
            else if (frame > 10 && backmove)
            {
                destinationRec.Y -= 5;
            }
            if (destinationRec.Y > 555) backmove = true;
            if (destinationRec.Y < 264) backmove = false;
            TektiteSprite.Update();
        }

        public Rectangle GetRectangle()
        {
            return destinationRec;
        }
    }
}
