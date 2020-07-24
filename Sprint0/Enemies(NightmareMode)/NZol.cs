using Microsoft.Xna.Framework;
using Sprint0.Sprite;
using Sprint0.Interfaces;

namespace Sprint0.Enemies
{
    public class NZol : AbstractEnemies, IEnemy
    {


        private ISprite ZolSprite;
        private int xPosition;
        private int yPosition;
        private int frame = 0;
        bool backmove = false;
        private Rectangle destinationRec;

        public NZol(int x, int y)
        {

            xPosition = x;
            yPosition = y;
            ZolSprite = new EnemyZolSprite(x, y);
            destinationRec = new Rectangle(x, y, 45, 45);
        }



        public override void Draw()
        {
            if (this.GetHealth() > 0)
            {
                Vector2 location = new Vector2(xPosition, yPosition);
                ZolSprite.Draw(location, false);
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
            ZolSprite.Update();
        }

        public override Rectangle GetRectangle()
        {
            return destinationRec;
        }
    }
}