using Microsoft.Xna.Framework;
using Sprint0.Sprite;
using Sprint0.Interfaces;
using Sprint0.UtilityClass;

namespace Sprint0.NPCs
{
    public class Merchant : INPC
    {

        private static ISprite MerchantSprite;
        private int xPosition;
        private int yPosition;
        private Rectangle destinationRec;

        public Merchant(int x, int y)
        {
            xPosition = x;
            yPosition = y;
            MerchantSprite = SpriteFactory.NPCMerchant;
            destinationRec = new Rectangle(x, y, IntegerHolder.FoutyFive, IntegerHolder.FoutyFive);
        }

        public void Draw()
        {
            Vector2 location = new Vector2(xPosition, yPosition);
            MerchantSprite.Draw(location, false);
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