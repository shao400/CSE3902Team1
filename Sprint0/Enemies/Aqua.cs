using Microsoft.Xna.Framework;
using Sprint0.Sprite;
using Sprint0.Interfaces;

namespace Sprint0.Enemies
{
    public class Aqua : AbstractEnemies, IEnemy 
    {


        private static ISprite AquaSprite;
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
            destinationRec = new Rectangle(x, y, 45, 60);
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
            AquaSprite.Update();
        }

        public override Rectangle GetRectangle()
        {
            return destinationRec;
        }
    }
}