using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Sprint0
{
    public class LinkNoneMovingLeftSprite : ISprite
    {
        private static SpriteBatch mySpriteBatch;
        private static Texture2D myTexture;
        Color myColor = Color.CornflowerBlue;
        Rectangle sourceRec;
        int frame = 0;
        SpriteEffect spriteEffect = SpriteEffects.FlipHorizontally
        public void Update()
        {
            frame++;
            if (frame == 2)
            {
                frame = 0;
            }
            switch (frame)
            {
                case 1:
                    sourceRec = new Rectangle(35, 11, 16, 16);
                    
                    break;
                case 2:
                    sourceRec = new Rectangle(52, 11, 16, 16);
                    break;
                default:
                    break;
            }

        }
        public void Draw(Vector2 location)
        {
            mySpriteBatch.Begin();
            mySpriteBatch.Draw(myTexture, location, sourceRec, myColor);
            mySpriteBatch.End();

        }
        public void LoadContent(SpriteBatch spriteBatch, Texture2D texture)
        {
            mySpriteBatch = spriteBatch;
            myTexture = texture;
        }
    }
}
