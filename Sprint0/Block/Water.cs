using Microsoft.Xna.Framework;
using Sprint0.Interfaces;
using Sprint0.Sprite;
using Sprint0.UtilityClass;

namespace Sprint0.Block
{
    class Water : IBlock
    {
        private ISprite sprite = SpriteFactory.BlockA;
        private int xpos;
        private int ypos;
        private string type;
        public Water(int x, int y)
        {
            xpos = x;
            ypos = y;
            type = StringHolder.WaterType;
        }
        public string getType()
        {
            return type;
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
            return new Rectangle(xpos, ypos, 48, 48);
        }

    }
}