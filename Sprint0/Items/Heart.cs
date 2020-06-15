using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint0.Items
{
    class Heart:IItem
    {
        private int xAix;
        private int yAix;
        private int width;
        private int height;
        public Girl(int x, int y, int w, int h)
        {
            xAix = x;
            yAix = y;
            width = w;
            height = h;
        }
        public void Draw()
        {

        }

        public void Reverse()
        {
        }

        public void Update()
        {
            ItemHeartSprite.update();
        }

        public Rectangle GetRectangle()
        {
            return new Rectangle(xAix, yPosition, width, height);
        }
    }
}
