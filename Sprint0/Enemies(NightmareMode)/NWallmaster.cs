using Microsoft.Xna.Framework;
using Sprint0.Sprite;
using Sprint0.Interfaces;

namespace Sprint0.Enemies
{
    public class NWallmaster : AbstractEnemies, IEnemy
    {


        private ISprite WallmasterSprite;
        private int xPosition;
        private int yPosition;
        private Rectangle destinationRec;

        public NWallmaster(int x, int y)
        {
            xPosition = x;
            yPosition = y;
            WallmasterSprite = new EnemyWallmasterSprite(x, y);
            destinationRec = new Rectangle(x, y, 45, 45);
        }

        public override void Draw()
        {
            if (this.GetHealth() > 0)
            {
                Vector2 location = new Vector2(xPosition, yPosition);
                WallmasterSprite.Draw(location, false);
            }
        }

        public override void Update()
        {
            WallmasterSprite.Update();
        }

        public override Rectangle GetRectangle()
        {
            return destinationRec;
        }
    }
}