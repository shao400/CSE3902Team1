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


        private ISprite StalfosSprite;
        private int xPosition;
        private int yPosition;
        //private int frame = 0;
        //bool backmove = false;
        private Rectangle destinationRec;
        private int health = 1;
        private ISprite Born;
        private ISprite Death;
        private int counter = 0;
        public Stalfos(int x, int y)
        {

            xPosition = x;
            yPosition = y;
            StalfosSprite = new EnemyStalfosSprite(x, y);
            destinationRec = new Rectangle(x, y, 45, 45);
            Born = SpriteFactory.EnemyBorn;
            Death = SpriteFactory.EnemyDeath;
        }

        public void Damaged()
        {
            health--;

        }
        public int GetHealth()
        {
            return health;
        }

        public void Draw()
        {
            if (counter < 34)
            {
                Born.Draw(new Vector2(destinationRec.X, yPosition), false);
            }

            if (this.GetHealth() > 0 && counter == 34)
            {
                Vector2 location = new Vector2(xPosition, yPosition);
                StalfosSprite.Draw(location, false);
            }
            if (counter < 70 && this.GetHealth() == 0)
            {
                Death.Draw(new Vector2(destinationRec.X, yPosition), false);
            }
        }

        public void Update()
        {
            if (counter < 34)
            {
                Born.Update();
                counter++;
            }
            else if (counter >= 34 && this.GetHealth() == 0 && counter < 70)
            {
                Death.Update();
                counter++;
            }
            else
            {
                if (this.GetHealth() > 0)
                {
                    Vector2 location = new Vector2(xPosition, yPosition);
                    StalfosSprite.Draw(location, false);
                }
            }
        }

        public Rectangle GetRectangle()
        {
            return destinationRec;
        }

        public void xReverse(int distance, bool plus)
        {
            throw new System.NotImplementedException();
        }

        public void yReverse(int distance, bool plus)
        {
            throw new System.NotImplementedException();
        }

        public void blockCollisionTest(List<IBlock> blocks)
        {

        }
    }
}