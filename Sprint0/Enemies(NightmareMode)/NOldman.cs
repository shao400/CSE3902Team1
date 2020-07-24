using Microsoft.Xna.Framework;
using Sprint0.Sprite;
using Sprint0.Interfaces;
using Sprint0.Player;

namespace Sprint0.Enemies
{
    public class NOldman : AbstractEnemies, IEnemy
    {


        private ISprite OldmanSprite;
        private ISprite BlastSprite;
        private int xPosition;
        private int yPosition;
        private Rectangle destinationRec;
        private Player1 _link;
        private Vector2 locationB;
        private const int shotDistance = 4;
        public NOldman(int x, int y,Player1 link)
        {

            xPosition = x;
            yPosition = y;
            OldmanSprite = new EnemyOldmanSprite(x, y);
            BlastSprite = new EnemyBlastSprite();
            destinationRec = new Rectangle(x, y, 45, 45);
            locationB = new Vector2(x, y);
            _link = link;
        }



        public override void Draw()
        {
            
            if (this.GetHealth() > 0)
            {
                
                Vector2 locationO = new Vector2(xPosition, yPosition);
                OldmanSprite.Draw(locationO, false);
                BlastSprite.Draw(locationB, false);
            }
        }

        public override void Update()
        {
            if (locationB.X > _link.GetRectangle().X) locationB.X -= shotDistance;
            if (locationB.X < _link.GetRectangle().X) locationB.X += shotDistance;
            if (locationB.Y > _link.GetRectangle().Y) locationB.Y -= shotDistance;
            if (locationB.Y < _link.GetRectangle().Y) locationB.Y += shotDistance;
        }


        public override Rectangle GetRectangle()
        {
            Rectangle destinationRecB = new Rectangle((int)locationB.X, (int)locationB.Y ,32,40);
            return destinationRecB;
        }
    }
}