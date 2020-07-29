using Microsoft.Xna.Framework;
using Sprint0.Sprite;
using Sprint0.Interfaces;
using System.Collections.Generic;

namespace Sprint0.Enemies
{
    public class Goriya : AbstractEnemies, IEnemy
    {


        private ISprite GoriyaSprite;
        private int xPosition;
        private int yPosition;
        private int frame = 0;
        bool backmove = false;
        private Rectangle destinationRec;
        private int health = 4;

        public Goriya(int x, int y)
        {

            xPosition = x;
            yPosition = y;
            GoriyaSprite = new EnemyGoriyaSprite(x, y);
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
                GoriyaSprite.Draw(location, false);
            }
            
        }

        public override void Update()
        {
            frame++;
            if (frame >= 20) frame = 0;
            if (frame < 10 && !backmove)
            {
                destinationRec.X += 1;
            }
            else if (frame > 10 && !backmove)
            {
                destinationRec.X += 1;
            }
            else if (frame < 10 && backmove)
            {
                destinationRec.X -= 1;
            }
            else if (frame > 10 && backmove)
            {
                destinationRec.X -= 1;
            }
            if (destinationRec.X > 627) backmove = true;
            if (destinationRec.X < 96) backmove = false;
            GoriyaSprite.Update();
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