using Microsoft.Xna.Framework;
using Sprint0.Sprite;
using Sprint0.Interfaces;
using System.Collections.Generic;

namespace Sprint0.Enemies
{
    public class Wallmaster : IEnemy
    {


        private ISprite WallmasterSprite;
        private int xPosition;
        private int yPosition;
        private Rectangle destinationRec;
        private int health = 5;

        public Wallmaster(int x, int y)
        {
            xPosition = x;
            yPosition = y;
            WallmasterSprite = new EnemyWallmasterSprite(x, y);
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
        public  void Draw()
        {
            if (this.GetHealth() > 0)
            {
                Vector2 location = new Vector2(xPosition, yPosition);
                WallmasterSprite.Draw(location, false);
            }
        }

        public void Update()
        {
            WallmasterSprite.Update();
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