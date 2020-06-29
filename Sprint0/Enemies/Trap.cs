using Microsoft.Xna.Framework;
using Sprint0.Sprite;
using Sprint0.Interfaces;

namespace Sprint0.Enemies
{
    public class Trap : IEnemy
    {


        private static ISprite TrapSprite;
        private int xPosition;
        private int yPosition;
        private Rectangle destinationRec;

        public Trap(int x, int y)
        {

            xPosition = x;
            yPosition = y;
            TrapSprite = new EnemyTrapSprite(x, y);
            destinationRec = new Rectangle(x, y, 45, 45);
        }



        public void Draw()
        {
            Vector2 location = new Vector2(xPosition, yPosition);
            TrapSprite.Draw(location, false);
        }

        public void Update()
        {
            
        }

        public Rectangle GetRectangle()
        {
            return destinationRec;
        }
    }
}