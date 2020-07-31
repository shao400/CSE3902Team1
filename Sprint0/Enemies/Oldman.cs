using Microsoft.Xna.Framework;
using Sprint0.Sprite;
using Sprint0.Interfaces;
using Sprint0.Player;
using System.Collections.Generic;
using Sprint0.UtilityClass;

namespace Sprint0.Enemies
{
    public class Oldman : IEnemy
    {


        private ISprite OldmanSprite;
        private int xPosition;
        private int yPosition;
        private Rectangle destinationRec;
        private Player1 _link;
        private Vector2 locationB;
        private const int shotDistance = IntegerHolder.Four;
        public int health = 1;
        private ISprite Born;
        private ISprite Death;
        private int counter = 0;
        public Oldman(int x, int y,Player1 link)
        {

            xPosition = x;
            yPosition = y;
            OldmanSprite = new EnemyOldmanSprite(x, y);
            destinationRec = new Rectangle(x, y, IntegerHolder.FoutyFive, IntegerHolder.FoutyFive);
            locationB = new Vector2(x, y);
            _link = link;
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
                Born.Draw(new Vector2(destinationRec.X, yPosition), false);
            }

            if (this.GetHealth() > 0 && counter == IntegerHolder.ThirtyFour)
            {

                Vector2 locationO = new Vector2(xPosition, yPosition);
                OldmanSprite.Draw(locationO, false);
            }
            if (counter < IntegerHolder.Seventy && this.GetHealth() == 0)
            {
                Death.Draw(new Vector2(destinationRec.X, yPosition), false);
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
                if (locationB.X > _link.GetRectangle().X) locationB.X -= shotDistance;
                if (locationB.X < _link.GetRectangle().X) locationB.X += shotDistance;
                if (locationB.Y > _link.GetRectangle().Y) locationB.Y -= shotDistance;
                if (locationB.Y < _link.GetRectangle().Y) locationB.Y += shotDistance;
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