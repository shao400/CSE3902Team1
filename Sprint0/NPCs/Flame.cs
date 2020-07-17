using Microsoft.Xna.Framework;
using Sprint0.Sprite;
using Sprint0.Interfaces;

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
            destinationRec = new Rectangle(x, y, 45, 45);
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
