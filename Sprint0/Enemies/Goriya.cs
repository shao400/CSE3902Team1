using Microsoft.Xna.Framework;
using Sprint0.Sprite;
using Sprint0.Interfaces;

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

        public Goriya(int x, int y)
        {

            xPosition = x;
            yPosition = y;
            GoriyaSprite = new EnemyGoriyaSprite(x, y);
            destinationRec = new Rectangle(x, y, 45, 45);
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
            GoriyaSprite.Update();
        }

        public override Rectangle GetRectangle()
        {
            
                return destinationRec;
            
            
            
        }
    }
}