using Microsoft.Xna.Framework;
using Sprint0.Sprite;
using Sprint0.Interfaces;
using System.Collections.Generic;
using System;

namespace Sprint0.Enemies
{
    public class Keese : AbstractEnemies, IEnemy
    {


        private ISprite KeeseSprite;
        private int xPosition;
        private int yPosition;
        private int frame = 0;
        bool backmove = false;
        private Rectangle destinationRec;
        private int health = 3;

        public Keese(int x, int y)
        {

            xPosition = x;
            yPosition = y;
            KeeseSprite = new EnemyKeeseSprite(x, y);
            destinationRec = new Rectangle(x, y, 45, 45);
        }

        public void Damaged()
        {
           Console.WriteLine(health);
           health--;

        }
        public int GetHealth()
        {
            return health;
        }

        public override void Draw()
        {
            if (this.GetHealth() > 0)
            {
                Vector2 location = new Vector2(xPosition, yPosition);
                KeeseSprite.Draw(location, false);
            }
        }

        public override void Update()
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
            KeeseSprite.Update();
        }

        public override Rectangle GetRectangle()
        {
            return destinationRec;
        }

        public override void xReverse(int distance, bool plus)
        {
            throw new System.NotImplementedException();
        }

        public override void yReverse(int distance, bool plus)
        {
            throw new System.NotImplementedException();
        }

        public override void blockCollisionTest(List<IBlock> blocks)
        {
        }
    }
}