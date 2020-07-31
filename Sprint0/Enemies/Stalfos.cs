using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Sprint0.Sprite;
using Sprint0.Interfaces;
using Sprint0.UtilityClass;

namespace Sprint0.Enemies
{
    public class Stalfos : IEnemy
    {
        private ISprite StalfosSprite;
        private int xPosition;
        private int yPosition;
        private Rectangle destinationRec;
        private int health = IntegerHolder.One;
        private ISprite Born;
        private ISprite Death;
        private int counter = 0;
        public Stalfos(int x, int y)
        {
            xPosition = x;
            yPosition = y;
            StalfosSprite = new EnemyStalfosSprite(x, y);
            destinationRec = new Rectangle(x, y, IntegerHolder.FoutyFive, IntegerHolder.FoutyFive);
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
            if (counter < IntegerHolder.ThirtyFour) Born.Draw(new Vector2(destinationRec.X, yPosition), false);            
            if (this.GetHealth() > 0 && counter == IntegerHolder.ThirtyFour)
            {
                Vector2 location = new Vector2(xPosition, yPosition);
                StalfosSprite.Draw(location, false);
            }
            if (counter < IntegerHolder.Seventy && this.GetHealth() == 0) Death.Draw(new Vector2(destinationRec.X, yPosition), false);            
        }

        public void Update()
        {
            if (counter < IntegerHolder.ThirtyFour)
            {
                Born.Update();
                counter++;
            }
            else if (counter >= IntegerHolder.ThirtyFour && this.GetHealth() == 0 && counter < IntegerHolder.Seventy)
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