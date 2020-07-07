using Microsoft.Xna.Framework;
using Sprint0.Sprite;
using Sprint0.Interfaces;

namespace Sprint0.Enemies
{
    public class Empty : IEnemy
    {


        private static ISprite AquaSprite;
        private int xPosition;
        private int yPosition;
        private int frame = 0;
        bool backmove = false;
        private Rectangle destinationRec;

        public Empty(int x, int y)
        {

            xPosition = x;
            yPosition = y;
            AquaSprite = new EnemyAquaSprite(x, y);
            destinationRec = new Rectangle(x, y, 45, 60);
        }



        public void Draw()
        {
            //Vector2 location = new Vector2(xPosition, yPosition);
            //AquaSprite.Draw(location, false);
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