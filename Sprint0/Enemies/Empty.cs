using Microsoft.Xna.Framework;
using Sprint0.Sprite;
using Sprint0.Interfaces;

namespace Sprint0.Enemies
{
    public class Empty : AbstractEnemies, IEnemy
    {


        private ISprite AquaSprite;
        private int xPosition;
        private int yPosition;
        private Rectangle destinationRec;

        public Empty(int x, int y)
        {

            xPosition = x;
            yPosition = y;
            AquaSprite = new EnemyAquaSprite(x, y);
            destinationRec = new Rectangle(x, y, 45, 60);
        }



        public override void Draw()
        {

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