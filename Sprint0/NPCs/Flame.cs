using Microsoft.Xna.Framework;
using Sprint0.Sprite;
using Sprint0.Interfaces;
using Sprint0.UtilityClass;

namespace Sprint0.NPCs
{
    public class Flame : INPC
    {
        private static ISprite FlameSprite;
        private int xPosition;
        private int yPosition;
        private Rectangle destinationRec;

        public Flame(int x, int y)
        {
            xPosition = x;
            yPosition = y;
            FlameSprite = SpriteFactory.NPCFlame;
            destinationRec = new Rectangle(x, y, IntegerHolder.FoutyFive, IntegerHolder.FoutyFive);
        }



        public void Draw()
        {
            Vector2 location = new Vector2(xPosition, yPosition);
            FlameSprite.Draw(location, false);
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
