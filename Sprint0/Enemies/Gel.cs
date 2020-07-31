using Microsoft.Xna.Framework;
using Sprint0.Sprite;
using Sprint0.Interfaces;
using System.Collections.Generic;
using Sprint0.UtilityClass;

namespace Sprint0.Enemies
{
    public class Gel : IEnemy
    {
        private ISprite GelSprite;
        private int xPosition;
        private int yPosition;
        private int frame = 0;
        bool backmove = false;
        private Rectangle destinationRec;
        private int health = IntegerHolder.One;
        private ISprite Born;
        private ISprite Death;
        private int counter = 0;

        public Gel(int x, int y)
        {
            xPosition = x;
            yPosition = y;
            GelSprite = new EnemyGelSprite(x, y);
            destinationRec = new Rectangle(x, y, IntegerHolder.TwentyFour, IntegerHolder.TwentyFour);
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
            if (counter < IntegerHolder.ThirtyFour)
            {
                Born.Draw(new Vector2(destinationRec.X, destinationRec.Y), false);
            }

            if (this.GetHealth() > 0 && counter == IntegerHolder.ThirtyFour)
            {
                Vector2 location = new Vector2(xPosition, yPosition);
                GelSprite.Draw(location, false);
            }
            if (counter < IntegerHolder.Seventy && this.GetHealth() == 0)
            {
                Death.Draw(new Vector2(destinationRec.X, destinationRec.Y), false);
            }
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
                frame++;
                if (frame >= 20) frame = 0;
                if (frame < IntegerHolder.Ten && !backmove) destinationRec.Y += IntegerHolder.One;                
                else if (frame > IntegerHolder.Ten && !backmove) destinationRec.Y += IntegerHolder.One;                
                else if (frame < IntegerHolder.Ten && backmove) destinationRec.Y -= IntegerHolder.One;                
                else if (frame > IntegerHolder.Ten && backmove) destinationRec.Y -= IntegerHolder.One;               
                if (destinationRec.Y > 555) backmove = true;
                if (destinationRec.Y < IntegerHolder.TwoSixFour) backmove = false;
                GelSprite.Update();
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