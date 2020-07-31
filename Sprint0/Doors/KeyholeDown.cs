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
    class KeyholeDown : IDoor
    {
        private ISprite sprite = SpriteFactory.KeyholeDown;
        private int xpos;
        private int ypos;
        public KeyholeDown(int x, int y)
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
            return true;
        }
    }
}
