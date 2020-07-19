using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using Microsoft.Xna.Framework;
using Sprint0.Interfaces;
using Sprint0.Sprite;
using Sprint0.UtilityClass;

namespace Sprint0.Block
{
    class BlockC : IBlock
    {
        private ISprite sprite = SpriteFactory.BlockC;
        private int xpos;
        private int ypos;
        private string type;
        public BlockC(int x, int y)
        {
            xpos = x;
            ypos = y;
            type = StringHolder.BlockType;
        }
        public string GetType()
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
