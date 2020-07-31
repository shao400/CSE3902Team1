using Microsoft.Xna.Framework;
using Sprint0.Interfaces;
using Sprint0.Sprite;
using Sprint0.UtilityClass;

namespace Sprint0.Block
{
    class DoorBDown : IDoor
    {
        private ISprite sprite = SpriteFactory.DoorBDown;
        private int xpos;
        private int ypos;
        public DoorBDown(int x, int y)
        {
            xpos = x;
            ypos = y;
        }

        public void Draw()
        {
            Vector2 location = new Vector2(xpos, ypos);
            sprite.Draw(location, false);
        }

        public void Update()
        {
            //nothing to do here
        }

        public Rectangle GetRectangle()
        {
            return new Rectangle(xpos, ypos, IntegerHolder.fourtyEight, IntegerHolder.fourtyEight);
        }

        public bool IsKeyhole()
        {
            return false;
        }
    }
}
