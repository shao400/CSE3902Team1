using Microsoft.Xna.Framework;
using Sprint0.Sprite;
using Sprint0.Interfaces;

namespace Sprint0.Enemies
{
    public class Dodongo : IEnemy
    {


        private static ISprite DodongoSprite;
        private int xPosition;
        private int yPosition;
        private int frame = 0;
        bool backmove = false;
        private Rectangle destinationRec;

        public Dodongo(int x, int y)
        {

            xPosition = x;
            yPosition = y;
            DodongoSprite = new EnemyDodongoSprite(x, y);
            destinationRec = new Rectangle(x, y, 90, 45);
        }



        public void Draw()
        {
            Vector2 location = new Vector2(xPosition, yPosition);
            DodongoSprite.Draw(location, false);
        }

        public void Update()
        {
            frame++;
            if (frame >= 20) frame = 0;
            if (frame < 10 && !backmove)
            {
                destinationRec.X += 5;
            }
            else if (frame > 10 && !backmove)
            {
                destinationRec.X += 5;
            }
            else if (frame < 10 && backmove)
            {
                destinationRec.X -= 5;
            }
            else if (frame > 10 && backmove)
            {
                destinationRec.X -= 5;
            }
            if (destinationRec.X > 627) backmove = true;
            if (destinationRec.X < 96) backmove = false;
            DodongoSprite.Update();
        }

        public Rectangle GetRectangle()
        {
            return destinationRec;
        }
    }
}