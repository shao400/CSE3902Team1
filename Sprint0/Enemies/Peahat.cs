using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Sprint0.Sprite;
using Sprint0.Interfaces;
using Sprint0.Projectile;

namespace Sprint0.Enemies
{   //Zina
    public class Peahat : AbstractEnemies, IEnemy
    {

        private ISprite PeahatSprite;
        private int xPosition;
        private int yPosition;
        private int frame = 0;
        bool backmove = false;
        private Rectangle destinationRec;
        private int health = 2;

        public Peahat(int x, int y)
        {
            xPosition = x;
            yPosition = y;
            PeahatSprite = new EnemyPeahatSprite(x, y);
            destinationRec = new Rectangle(x, y, 45, 45);
        }

        public void Damaged()
        {
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
                PeahatSprite.Draw(location, false);
            }
        }

        public override void Update()
        {
            frame++;
            if (frame >= 20) frame = 0;
            if (frame < 10 && !backmove)
            {
                destinationRec.Y += 2;
            }
            else if (frame > 10 && !backmove)
            {
                destinationRec.Y += 2;
            }
            else if (frame < 10 && backmove)
            {
                destinationRec.Y -= 2;
            }
            else if (frame > 10 && backmove)
            {
                destinationRec.Y -= 2;
            }
            if (destinationRec.Y > 555) backmove = true;
            if (destinationRec.Y < 264) backmove = false;
            PeahatSprite.Update();
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