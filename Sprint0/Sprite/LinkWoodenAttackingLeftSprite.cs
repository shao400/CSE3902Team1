using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint0
{
    public class LinkWoodenAttackingLeftSprite : ISprite
    {
        private static SpriteBatch mySpriteBatch;
        private static Texture2D myTexture;
        Color myColor = Color.CornflowerBlue;
        Rectangle sourceRec;
        int frame = 0;
        public void Update()
        {

            frame++;
            if (frame == 5)
            {
                frame = 0;
            }
            switch (frame)
            {
                case 0:
                    sourceRec = new Rectangle(1, 77, 16, 16);
                    break;
                case 1:
                    sourceRec = new Rectangle(18, 77, 16, 16);
                    break;
                case 3:
                    sourceRec = new Rectangle(46, 77, 16, 16);
                    break;
                case 4:
                    sourceRec = new Rectangle(70, 77, 16, 16);
                    break;
                default:
                    break;
            }
        }
        public void LoadContent(SpriteBatch batch, Texture2D texture)
        {
            mySpriteBatch = batch;
            myTexture = texture;
        }
        public void Draw(Vector2 location)
        {
            SpriteEffects effect = SpriteEffects.FlipHorizontally;
            mySpriteBatch.Begin();
            mySpriteBatch.Draw(myTexture, new Rectangle((int)location.X, (int)location.Y, 48, 48), sourceRec, myColor, 0, new Vector2(0, 0), effect, 0);
            mySpriteBatch.End();
        }
    }
}
