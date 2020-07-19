using Microsoft.Xna.Framework;
using Sprint0.Sprite;
using Sprint0.Interfaces;

namespace Sprint0.Enemies
{
    public class Oldman : AbstractEnemies, IEnemy
    {


        private ISprite OldmanSprite;
        private int xPosition;
        private int yPosition;
        private Rectangle destinationRec;

        public Oldman(int x, int y)
        {

            xPosition = x;
            yPosition = y;
            OldmanSprite = new EnemyOldmanSprite(x, y);
            destinationRec = new Rectangle(x, y, 45, 45);
        }



        public override void Draw()
        {
            if (this.GetHealth() > 0)
            {
                Vector2 location = new Vector2(xPosition, yPosition);
                OldmanSprite.Draw(location, false);
            }
        }

        public override void Update()
        {
            
        }

        public override Rectangle GetRectangle()
        {
            return destinationRec;
        }
    }
}