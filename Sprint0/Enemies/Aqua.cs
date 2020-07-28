using Microsoft.Xna.Framework;
using Sprint0.Sprite;
using Sprint0.Interfaces;
using System.Collections.Generic;

namespace Sprint0.Enemies
{
    public class Aqua : AbstractEnemies, IEnemy 
    {


        private ISprite AquaSprite;
        private int xPosition;
        private int yPosition;
        private int frame = 0;
        bool backmove = false;
        private Rectangle destinationRec;

        public Aqua(int x, int y)
        {

            xPosition = x;
            yPosition = y;
            AquaSprite = new EnemyAquaSprite(x, y);
            destinationRec = new Rectangle(x, y, 100, 100);
        }



        public override void Draw()
        {
            if (this.GetHealth() > 0)
            {
                Vector2 location = new Vector2(xPosition, yPosition);
                AquaSprite.Draw(location, false);
            }
        }

        public override void Update()
        {
            frame++;
            if (frame >= 5) frame = 0;
            if (frame < 2 && !backmove)
            {
                destinationRec.X += 1;
            }
            else if (frame > 2 && !backmove)
            {
                destinationRec.X += 1;
            }
            else if (frame < 2 && backmove)
            {
                destinationRec.X -= 1;
            }
            else if (frame > 2 && backmove)
            {
                destinationRec.X -= 1;
            }
            if (destinationRec.X > 470) backmove = true;
            if (destinationRec.X < 440) backmove = false;
            AquaSprite.Update();
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