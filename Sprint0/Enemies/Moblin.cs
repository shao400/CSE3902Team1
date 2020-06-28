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
        private int frame = 0;
        bool backmove = false;
        private Rectangle destinationRec;

        public Moblin(int x, int y)
        {
            
            xPosition = x;
            yPosition = y;
            MoblinSprite = new EnemyMoblinSprite(x, y);
            destinationRec = new Rectangle(x, y, 64, 64);
        }



        public void Draw()
        {
            Vector2 location = new Vector2(xPosition,yPosition);
            MoblinSprite.Draw(location, false);
        }

        public void Update()
        {
            frame++;
            if (frame >= 20) frame = 0;
            if (frame < 10 && !backmove)
            {
                destinationRec.X += 5;
            }
            else if (frame > 10 && !backmove)
            {
                destinationRec.X += 5;
            }
            else if (frame < 10 && backmove)
            {
                destinationRec.X -= 5;
            }
            else if (frame > 10 && backmove)
            {
                destinationRec.X -= 5;
            }
            if (destinationRec.X > 627) backmove = true;
            if (destinationRec.X < 96) backmove = false;
            MoblinSprite.Update();
        }

        public Rectangle GetRectangle()
        {
            return destinationRec;
        }
    }
}