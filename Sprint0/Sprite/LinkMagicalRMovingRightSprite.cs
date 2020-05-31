using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint0
{
    public class LinkMagicalMovingRightSprite : ISprite
    {
        private static SpriteBatch mySpriteBatch;
        private static Texture2D myTexture;
        Color myColor = Color.CornflowerBlue;
        Rectangle sourceRec;
        int frame = 0;
        public void Update()
        {
            frame++;
            if (frame == 4)
            {
                frame = 0;
            }
        }
        public void Draw(Vector2 location)
        {
            if (frame == 0)
                sourceRec = new Rectangle(0, 0, 69, 86);
            if (frame == 1)
                sourceRec = new Rectangle(69, 0, 56, 86);
            if (frame == 2)
                sourceRec = new Rectangle(125, 0, 48, 86);
            if (frame == 3)
                sourceRec = new Rectangle(173, 0, 50, 86);

            mySpriteBatch.Begin();
            mySpriteBatch.Draw(myTexture, destinationRec, sourceRec, myColor);
            mySpriteBatch.End();

        }
        public void LoadContent(SpriteBatch spriteBatch, Texture2D texture)
        {
            mySpriteBatch = spriteBatch;
            myTexture = texture;
        }
    }
}
