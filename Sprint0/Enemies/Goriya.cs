using Microsoft.Xna.Framework;
using Sprint0.Sprite;
using Sprint0.Interfaces;
using System.Collections.Generic;

namespace Sprint0.Enemies
{
    public class Goriya :IEnemy
    {


        private ISprite GoriyaSprite;
        private ISprite Born;
        private ISprite Death;
        private int xPosition;
        private int yPosition;
        private int frame = 0;
        private int counter = 0;
        bool backmove = false;
        private Rectangle destinationRec;
        private int health = 4;

        public Goriya(int x, int y)
        {

            xPosition = x;
            yPosition = y;
            GoriyaSprite = new EnemyGoriyaSprite(x, y);
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

        public  void Draw()
        {
            
            if (counter < 34)
            {
                Born.Draw(new Vector2(destinationRec.X, destinationRec.Y), false);
            }
            
            if (this.GetHealth() > 0 && counter == 34)
            {
                Vector2 location = new Vector2(xPosition, yPosition);
                GoriyaSprite.Draw(location, false);
            }if (counter < 70 && this.GetHealth() ==0)
            {
                Death.Draw(new Vector2(destinationRec.X, destinationRec.Y), false);
            }
            
        }

        public  void Update()
        {
            if (counter < 34)
            {
                Born.Update();
                counter++;
            }else if (counter >= 34 && this.GetHealth() == 0 && counter < 70)
            {
                Death.Update();
                counter++;
            }
            else
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